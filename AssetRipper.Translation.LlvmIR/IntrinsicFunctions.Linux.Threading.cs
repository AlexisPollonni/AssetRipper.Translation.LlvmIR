using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Attributes;

namespace AssetRipper.Translation.LlvmIR;

#pragma warning disable IDE0060 // Remove unused parameter
internal static unsafe partial class IntrinsicFunctions
{
	// ── pthread / POSIX threading & time ─────────────────────────────────────
	//
	// Sync-primitive structs (mutex, rwlock, cond, sem) store a GCHandle<T>
	// cookie as their first 8 bytes.  GCHandle<T>.ToIntPtr() returns an opaque
	// index into the GC handle table – NOT a raw object address – so the backing
	// object never needs to be pinned and the GC can move it freely.
	//
	// pthread_once_t  (4 bytes): 3-state atomic int (0=uninit, 1=running, 2=done).
	// pthread_key_t   (4 bytes): index into a static ThreadLocal<nint>[] table.
	// pthread_t       (8 bytes): GCHandle<Thread> cookie to a managed Thread.
	//
	// errno values: ESRCH=3, ENOMEM=12, EBUSY=16, EINVAL=22, EDEADLK=35, ETIMEDOUT=110

	// ── GCHandle<T> cookie helpers ────────────────────────────────────────────

	// Lock-free CAS install of a new GCHandle<T> at *slot.
	// The factory is only invoked when the slot is uninitialized (lazy).
	// Returns whichever typed object owns the winning handle.
	private static T GetOrCreateSyncObject<T>(IntPtr* slot, Func<T> factory)
		where T : class
	{
		IntPtr existing = Volatile.Read(ref *slot);
		if (existing != IntPtr.Zero)
			return GCHandle<T>.FromIntPtr(existing).Target;

		T newObj = factory();
		GCHandle<T> handle = new GCHandle<T>(newObj);
		IntPtr cookie = GCHandle<T>.ToIntPtr(handle);
		IntPtr prev = Interlocked.CompareExchange(ref *slot, cookie, IntPtr.Zero);
		if (prev != IntPtr.Zero)
		{
			// Lost the race – release the handle we just created.
			handle.Dispose();
			return GCHandle<T>.FromIntPtr(prev).Target;
		}
		return newObj;
	}

	// Release the GCHandle stored at *slot (if any).
	// Type-agnostic: uses GCHandle<object> since we only need to free.
	private static void FreeSyncSlot(IntPtr* slot)
	{
		IntPtr cookie = Interlocked.Exchange(ref *slot, IntPtr.Zero);
		if (cookie != IntPtr.Zero)
			GCHandle<object>.FromIntPtr(cookie).Dispose();
	}

	// Read the typed object stored at *slot; returns null when uninitialized.
	private static T? TryGetSyncObject<T>(IntPtr* slot)
		where T : class
	{
		IntPtr cookie = Volatile.Read(ref *slot);
		return cookie == IntPtr.Zero ? null : GCHandle<T>.FromIntPtr(cookie).Target;
	}

	// ── pthread_mutex_t backing types ────────────────────────────────────────
	// pthread_mutexattr_t on Linux x86-64 is a plain 4-byte int whose value is
	// the mutex type enum.  We read/write it directly as *(int*)attr.
	//
	// Glibc type values: NORMAL/DEFAULT=0, RECURSIVE=1, ERRORCHECK=2.

	private enum PthreadMutexType
	{
		Normal = 0,
		Recursive = 1,
		Errorcheck = 2,
	}

	private abstract class PthreadMutexBase
	{
		public abstract void Enter();
		public abstract bool TryEnter();
		public abstract bool TryEnter(int ms);
		public abstract void Exit();
	}

	private sealed class NormalPthreadMutex : PthreadMutexBase
	{
		private readonly Lock _lock = new Lock();

		public override void Enter() => _lock.Enter();

		public override bool TryEnter() => _lock.TryEnter();

		public override bool TryEnter(int ms) => _lock.TryEnter(ms);

		public override void Exit() => _lock.Exit();
	}

	private sealed class RecursivePthreadMutex : PthreadMutexBase
	{
		private readonly Lock _lock = new Lock();
		private Thread? _owner;
		private int _depth;

		public override void Enter()
		{
			if (_owner == Thread.CurrentThread)
			{
				_depth++;
				return;
			}
			_lock.Enter();
			_owner = Thread.CurrentThread;
			_depth = 1;
		}

		public override bool TryEnter()
		{
			if (_owner == Thread.CurrentThread)
			{
				_depth++;
				return true;
			}
			if (!_lock.TryEnter())
				return false;
			_owner = Thread.CurrentThread;
			_depth = 1;
			return true;
		}

		public override bool TryEnter(int ms)
		{
			if (_owner == Thread.CurrentThread)
			{
				_depth++;
				return true;
			}
			if (!_lock.TryEnter(ms))
				return false;
			_owner = Thread.CurrentThread;
			_depth = 1;
			return true;
		}

		public override void Exit()
		{
			if (--_depth == 0)
			{
				_owner = null;
				_lock.Exit();
			}
		}
	}

	private sealed class ErrorCheckPthreadMutex : PthreadMutexBase
	{
		private readonly Lock _lock = new Lock();
		private Thread? _owner;

		public override void Enter()
		{
			if (_owner == Thread.CurrentThread)
				throw new SynchronizationLockException(
					"pthread EDEADLK: mutex already owned by this thread"
				);
			_lock.Enter();
			_owner = Thread.CurrentThread;
		}

		public override bool TryEnter()
		{
			if (_owner == Thread.CurrentThread)
				return false; // EDEADLK → report as busy
			if (!_lock.TryEnter())
				return false;
			_owner = Thread.CurrentThread;
			return true;
		}

		public override bool TryEnter(int ms)
		{
			if (_owner == Thread.CurrentThread)
				return false;
			if (!_lock.TryEnter(ms))
				return false;
			_owner = Thread.CurrentThread;
			return true;
		}

		public override void Exit()
		{
			_owner = null;
			_lock.Exit();
		}
	}

	// ── pthread_mutex_t ───────────────────────────────────────────────────────
	// Linux x86-64 layout: 40 bytes; first 8 bytes = GCHandle<PthreadMutexBase>.
	// Lazily defaults to NormalPthreadMutex (matches PTHREAD_MUTEX_INITIALIZER).

	private static PthreadMutexBase GetOrCreateMutex(IntPtr* mutex) =>
		GetOrCreateSyncObject<PthreadMutexBase>(mutex, static () => new NormalPthreadMutex());

	private static PthreadMutexBase CreateMutexForType(PthreadMutexType type) =>
		type switch
		{
			PthreadMutexType.Recursive => new RecursivePthreadMutex(),
			PthreadMutexType.Errorcheck => new ErrorCheckPthreadMutex(),
			_ => new NormalPthreadMutex(),
		};

	[MangledName("pthread_mutex_init")]
	public static int PthreadMutexInit(IntPtr* mutex, void* attr)
	{
		if (mutex == null)
			return 22; // EINVAL
		// pthread_mutexattr_t is a 4-byte int on Linux; read type directly.
		var type = attr != null ? *(PthreadMutexType*)attr : PthreadMutexType.Normal;
		PthreadMutexBase backing = CreateMutexForType(type);
		GetOrCreateSyncObject(mutex, () => backing);
		return 0;
	}

	[MangledName("pthread_mutex_destroy")]
	public static int PthreadMutexDestroy(IntPtr* mutex)
	{
		if (mutex == null)
			return 22;
		FreeSyncSlot(mutex);
		return 0;
	}

	[MangledName("pthread_mutex_lock")]
	public static int PthreadMutexLock(IntPtr* mutex)
	{
		if (mutex == null)
			return 22;
		GetOrCreateMutex(mutex).Enter();
		return 0;
	}

	[MangledName("pthread_mutex_trylock")]
	public static int PthreadMutexTrylock(IntPtr* mutex)
	{
		if (mutex == null)
			return 22;
		return GetOrCreateMutex(mutex).TryEnter() ? 0 : 16; // EBUSY
	}

	[MangledName("pthread_mutex_unlock")]
	public static int PthreadMutexUnlock(IntPtr* mutex)
	{
		if (mutex == null)
			return 22;
		PthreadMutexBase? m = TryGetSyncObject<PthreadMutexBase>(mutex);
		if (m == null)
			return 22;
		m.Exit();
		return 0;
	}

	[MangledName("pthread_mutex_timedlock")]
	public static int PthreadMutexTimedlock(IntPtr* mutex, long* abstime)
	{
		if (mutex == null)
			return 22;
		int ms = abstime != null ? (int)Math.Max(0L, ComputeTimeoutMs(abstime)) : Timeout.Infinite;
		return GetOrCreateMutex(mutex).TryEnter(ms) ? 0 : 110; // ETIMEDOUT
	}

	// ── pthread_mutexattr_t ───────────────────────────────────────────────────
	// pthread_mutexattr_t is a plain int on Linux – read/write directly.

	[MangledName("pthread_mutexattr_init")]
	public static int PthreadMutexattrInit(void* attr)
	{
		if (attr != null)
			*(int*)attr = (int)PthreadMutexType.Normal;
		return 0;
	}

	[MangledName("pthread_mutexattr_destroy")]
	public static int PthreadMutexattrDestroy(void* attr) => 0;

	[MangledName("pthread_mutexattr_settype")]
	public static int PthreadMutexattrSettype(void* attr, int type)
	{
		if (attr != null)
			*(int*)attr = type;
		return 0;
	}

	[MangledName("pthread_mutexattr_gettype")]
	public static int PthreadMutexattrGettype(void* attr, int* type)
	{
		if (type != null)
			*type = attr != null ? *(int*)attr : (int)PthreadMutexType.Normal;
		return 0;
	}

	[MangledName("pthread_mutexattr_setpshared")]
	public static int PthreadMutexattrSetpshared(void* attr, int pshared) => 0;

	[MangledName("pthread_mutexattr_getpshared")]
	public static int PthreadMutexattrGetpshared(void* attr, int* pshared)
	{
		if (pshared != null)
			*pshared = 0;
		return 0;
	}

	// ── pthread_rwlock_t ──────────────────────────────────────────────────────
	// Linux x86-64 layout: 56 bytes; first 8 bytes = GCHandle slot.
	// Backed by ReaderWriterLockSlim.

	private static ReaderWriterLockSlim GetOrCreateRwLock(IntPtr* rwlock) =>
		GetOrCreateSyncObject(
			rwlock,
			static () => new ReaderWriterLockSlim(LockRecursionPolicy.NoRecursion)
		);

	[MangledName("pthread_rwlock_init")]
	public static int PthreadRwlockInit(IntPtr* rwlock, void* attr)
	{
		if (rwlock == null)
			return 22;
		GetOrCreateRwLock(rwlock);
		return 0;
	}

	[MangledName("pthread_rwlock_destroy")]
	public static int PthreadRwlockDestroy(IntPtr* rwlock)
	{
		if (rwlock == null)
			return 22;
		ReaderWriterLockSlim? rw = TryGetSyncObject<ReaderWriterLockSlim>(rwlock);
		FreeSyncSlot(rwlock);
		rw?.Dispose();
		return 0;
	}

	[MangledName("pthread_rwlock_rdlock")]
	public static int PthreadRwlockRdlock(IntPtr* rwlock)
	{
		if (rwlock == null)
			return 22;
		GetOrCreateRwLock(rwlock).EnterReadLock();
		return 0;
	}

	[MangledName("pthread_rwlock_tryrdlock")]
	public static int PthreadRwlockTryrdlock(IntPtr* rwlock)
	{
		if (rwlock == null)
			return 22;
		return GetOrCreateRwLock(rwlock).TryEnterReadLock(0) ? 0 : 16; // EBUSY
	}

	[MangledName("pthread_rwlock_timedrdlock")]
	public static int PthreadRwlockTimedrdlock(IntPtr* rwlock, long* abstime)
	{
		if (rwlock == null)
			return 22;
		int ms = abstime != null ? (int)Math.Max(0L, ComputeTimeoutMs(abstime)) : Timeout.Infinite;
		return GetOrCreateRwLock(rwlock).TryEnterReadLock(ms) ? 0 : 110; // ETIMEDOUT
	}

	[MangledName("pthread_rwlock_wrlock")]
	public static int PthreadRwlockWrlock(IntPtr* rwlock)
	{
		if (rwlock == null)
			return 22;
		GetOrCreateRwLock(rwlock).EnterWriteLock();
		return 0;
	}

	[MangledName("pthread_rwlock_trywrlock")]
	public static int PthreadRwlockTrywrlock(IntPtr* rwlock)
	{
		if (rwlock == null)
			return 22;
		return GetOrCreateRwLock(rwlock).TryEnterWriteLock(0) ? 0 : 16; // EBUSY
	}

	[MangledName("pthread_rwlock_timedwrlock")]
	public static int PthreadRwlockTimedwrlock(IntPtr* rwlock, long* abstime)
	{
		if (rwlock == null)
			return 22;
		int ms = abstime != null ? (int)Math.Max(0L, ComputeTimeoutMs(abstime)) : Timeout.Infinite;
		return GetOrCreateRwLock(rwlock).TryEnterWriteLock(ms) ? 0 : 110; // ETIMEDOUT
	}

	[MangledName("pthread_rwlock_unlock")]
	public static int PthreadRwlockUnlock(IntPtr* rwlock)
	{
		if (rwlock == null)
			return 22;
		ReaderWriterLockSlim? rw = TryGetSyncObject<ReaderWriterLockSlim>(rwlock);
		if (rw == null)
			return 22;
		if (rw.IsWriteLockHeld)
			rw.ExitWriteLock();
		else if (rw.IsReadLockHeld)
			rw.ExitReadLock();
		return 0;
	}

	// ── pthread_rwlockattr_t stubs ────────────────────────────────────────────

	[MangledName("pthread_rwlockattr_init")]
	public static int PthreadRwlockattrInit(void* attr) => 0;

	[MangledName("pthread_rwlockattr_destroy")]
	public static int PthreadRwlockattrDestroy(void* attr) => 0;

	// ── pthread_cond_t ────────────────────────────────────────────────────────
	// Linux x86-64 layout: 48 bytes; first 8 bytes = GCHandle slot.
	// Backed by PthreadCondVar which wraps Monitor.Wait/Pulse semantics.

	private sealed class PthreadCondVar
	{
		// Explicit Monitor target for Wait/Pulse; separate from the mutex.
		public readonly object WaitLock = new object();
	}

	private static PthreadCondVar GetOrCreateCondVar(IntPtr* cond) =>
		GetOrCreateSyncObject(cond, static () => new PthreadCondVar());

	[MangledName("pthread_cond_init")]
	public static int PthreadCondInit(IntPtr* cond, void* attr)
	{
		if (cond == null)
			return 22;
		GetOrCreateCondVar(cond);
		return 0;
	}

	[MangledName("pthread_cond_destroy")]
	public static int PthreadCondDestroy(IntPtr* cond)
	{
		if (cond == null)
			return 22;
		FreeSyncSlot(cond);
		return 0;
	}

	[MangledName("pthread_cond_wait")]
	public static int PthreadCondWait(IntPtr* cond, IntPtr* mutex)
	{
		if (cond == null || mutex == null)
			return 22;
		PthreadCondVar cv = GetOrCreateCondVar(cond);
		PthreadMutexBase? mutexBase = TryGetSyncObject<PthreadMutexBase>(mutex);
		if (mutexBase == null)
			return 22;

		// Release the mutex, wait on the CV, re-acquire – re-entry is
		// guaranteed by the finally even if the wait is interrupted.
		mutexBase.Exit();
		try
		{
			lock (cv.WaitLock)
				Monitor.Wait(cv.WaitLock);
		}
		finally
		{
			mutexBase.Enter();
		}
		return 0;
	}

	[MangledName("pthread_cond_timedwait")]
	public static int PthreadCondTimedwait(IntPtr* cond, IntPtr* mutex, long* abstime)
	{
		if (cond == null || mutex == null)
			return 22;
		PthreadCondVar cv = GetOrCreateCondVar(cond);
		PthreadMutexBase? mutexBase = TryGetSyncObject<PthreadMutexBase>(mutex);
		if (mutexBase == null)
			return 22;

		int ms = abstime != null ? (int)Math.Max(0L, ComputeTimeoutMs(abstime)) : Timeout.Infinite;
		bool signaled;
		mutexBase.Exit();
		try
		{
			lock (cv.WaitLock)
				signaled = Monitor.Wait(cv.WaitLock, ms);
		}
		finally
		{
			mutexBase.Enter();
		}
		return signaled ? 0 : 110; // ETIMEDOUT
	}

	[MangledName("pthread_cond_signal")]
	public static int PthreadCondSignal(IntPtr* cond)
	{
		if (cond == null)
			return 22;
		PthreadCondVar? cv = TryGetSyncObject<PthreadCondVar>(cond);
		if (cv == null)
			return 0; // nobody waiting yet
		lock (cv.WaitLock)
			Monitor.Pulse(cv.WaitLock);
		return 0;
	}

	[MangledName("pthread_cond_broadcast")]
	public static int PthreadCondBroadcast(IntPtr* cond)
	{
		if (cond == null)
			return 22;
		PthreadCondVar? cv = TryGetSyncObject<PthreadCondVar>(cond);
		if (cv == null)
			return 0;
		lock (cv.WaitLock)
			Monitor.PulseAll(cv.WaitLock);
		return 0;
	}

	// ── pthread_condattr_t stubs ──────────────────────────────────────────────

	[MangledName("pthread_condattr_init")]
	public static int PthreadCondattrInit(void* attr) => 0;

	[MangledName("pthread_condattr_destroy")]
	public static int PthreadCondattrDestroy(void* attr) => 0;

	[MangledName("pthread_condattr_setclock")]
	public static int PthreadCondattrSetclock(void* attr, int clockId) => 0;

	[MangledName("pthread_condattr_getclock")]
	public static int PthreadCondattrGetclock(void* attr, int* clockId)
	{
		if (clockId != null)
			*clockId = 1; // CLOCK_MONOTONIC
		return 0;
	}

	// ── sem_t ─────────────────────────────────────────────────────────────────
	// Linux x86-64 layout: 32 bytes; first 8 bytes = GCHandle slot.
	// Backed by SemaphoreSlim.

	private static SemaphoreSlim GetOrCreateSemaphore(IntPtr* sem) =>
		GetOrCreateSyncObject(sem, static () => new SemaphoreSlim(0, int.MaxValue));

	[MangledName("sem_init")]
	public static int SemInit(IntPtr* sem, int pshared, uint value)
	{
		if (sem == null)
			return 22;
		// Need to capture value; use a local Func to avoid a closure over uint.
		int iv = (int)value;
		GetOrCreateSyncObject<SemaphoreSlim>(sem, () => new SemaphoreSlim(iv, int.MaxValue));
		return 0;
	}

	[MangledName("sem_destroy")]
	public static int SemDestroy(IntPtr* sem)
	{
		if (sem == null)
			return 22;
		SemaphoreSlim? s = TryGetSyncObject<SemaphoreSlim>(sem);
		FreeSyncSlot(sem);
		s?.Dispose();
		return 0;
	}

	[MangledName("sem_wait")]
	public static int SemWait(IntPtr* sem)
	{
		if (sem == null)
			return 22;
		GetOrCreateSemaphore(sem).Wait();
		return 0;
	}

	[MangledName("sem_trywait")]
	public static int SemTrywait(IntPtr* sem)
	{
		if (sem == null)
			return 22;
		return GetOrCreateSemaphore(sem).Wait(0) ? 0 : 16; // EBUSY
	}

	[MangledName("sem_timedwait")]
	public static int SemTimedwait(IntPtr* sem, long* abstime)
	{
		if (sem == null)
			return 22;
		int ms = abstime != null ? (int)Math.Max(0L, ComputeTimeoutMs(abstime)) : Timeout.Infinite;
		return GetOrCreateSemaphore(sem).Wait(ms) ? 0 : 110; // ETIMEDOUT
	}

	[MangledName("sem_post")]
	public static int SemPost(IntPtr* sem)
	{
		if (sem == null)
			return 22;
		GetOrCreateSemaphore(sem).Release();
		return 0;
	}

	[MangledName("sem_getvalue")]
	public static int SemGetvalue(IntPtr* sem, int* sval)
	{
		if (sem == null)
			return 22;
		if (sval != null)
			*sval = GetOrCreateSemaphore(sem).CurrentCount;
		return 0;
	}

	// Named semaphores (stub – process-local, no kernel backing).
	[MangledName("sem_open")]
	public static IntPtr* SemOpen(byte* name, int oflag, uint mode, uint value)
	{
		IntPtr* sem = (IntPtr*)NativeMemoryHelper.Allocate(sizeof(IntPtr));
		int iv = (int)value;
		GetOrCreateSyncObject<SemaphoreSlim>(sem, () => new SemaphoreSlim(iv, int.MaxValue));
		return sem;
	}

	[MangledName("sem_close")]
	public static int SemClose(IntPtr* sem)
	{
		if (sem == null)
			return 22;
		SemaphoreSlim? s = TryGetSyncObject<SemaphoreSlim>(sem);
		FreeSyncSlot(sem);
		s?.Dispose();
		NativeMemoryHelper.Free(sem);
		return 0;
	}

	[MangledName("sem_unlink")]
	public static int SemUnlink(byte* name) => 0; // no-op: named semaphores are process-local stubs

	// ── pthread_once_t ────────────────────────────────────────────────────────
	// 4 bytes on Linux.  3-state atomic int: 0=not started, 1=in progress, 2=done.

	[MangledName("pthread_once")]
	public static int PthreadOnce(int* onceControl, delegate* <void> initRoutine)
	{
		if (onceControl == null || initRoutine == null)
			return 22;

		if (Volatile.Read(ref *onceControl) == 2)
			return 0; // fast path – already initialized

		int prev = Interlocked.CompareExchange(ref *onceControl, 1, 0);
		if (prev == 0)
		{
			// We won the race – run the initializer.
			try
			{
				initRoutine();
			}
			finally
			{
				Volatile.Write(ref *onceControl, 2);
			}
		}
		else
		{
			// Another thread is running the initializer; spin until it finishes.
			SpinWait sw = default;
			while (Volatile.Read(ref *onceControl) != 2)
				sw.SpinOnce();
		}
		return 0;
	}

	// ── pthread_key_t ─────────────────────────────────────────────────────────
	// 4 bytes on Linux.  Used as an index into _tls[], a static array of
	// ThreadLocal<nint> slots.  4096 slots is generous for any real workload.

	private static readonly ThreadLocal<nint>?[] _tls = new ThreadLocal<nint>?[4096];
	private static int _tlsNextKey;

	[MangledName("pthread_key_create")]
	public static int PthreadKeyCreate(int* key, delegate* <void*, void> destructor)
	{
		// Note: TLS destructors are not called on thread exit in this implementation.
		if (key == null)
			return 22;
		int idx = Interlocked.Increment(ref _tlsNextKey) - 1;
		if ((uint)idx >= (uint)_tls.Length)
			return 12; // ENOMEM
		_tls[idx] = new ThreadLocal<nint>();
		*key = idx;
		return 0;
	}

	[MangledName("pthread_key_delete")]
	public static int PthreadKeyDelete(int key)
	{
		if ((uint)key >= (uint)_tls.Length)
			return 22;
		ThreadLocal<nint>? tl = Interlocked.Exchange(ref _tls[key], null);
		tl?.Dispose();
		return 0;
	}

	[MangledName("pthread_getspecific")]
	public static void* PthreadGetspecific(int key)
	{
		if ((uint)key >= (uint)_tls.Length)
			return null;
		ThreadLocal<nint>? tl = _tls[key];
		return tl == null ? null : (void*)tl.Value;
	}

	[MangledName("pthread_setspecific")]
	public static int PthreadSetspecific(int key, void* value)
	{
		if ((uint)key >= (uint)_tls.Length)
			return 22;
		ThreadLocal<nint>? tl = _tls[key];
		if (tl == null)
			return 22;
		tl.Value = (nint)value;
		return 0;
	}

	// ── pthread_t ─────────────────────────────────────────────────────────────
	// 8 bytes on Linux.  Stored as a GCHandle<Thread> cookie.

	[MangledName("pthread_create")]
	public static int PthreadCreate(
		IntPtr* threadOut,
		void* attr,
		delegate* <void*, void*> startRoutine,
		void* arg
	)
	{
		if (threadOut == null || startRoutine == null)
			return 22;

		// Capture as nint so the closure does not hold an unsafe pointer.
		nint fnPtr = (nint)startRoutine;
		nint argPtr = (nint)arg;
		Thread t = new Thread(() => ((delegate* <void*, void*>)fnPtr)((void*)argPtr))
		{
			IsBackground = true,
		};
		GCHandle<Thread> handle = new GCHandle<Thread>(t);
		*threadOut = GCHandle<Thread>.ToIntPtr(handle);
		t.Start();
		return 0;
	}

	[MangledName("pthread_join")]
	public static int PthreadJoin(IntPtr thread, void** retval)
	{
		if (thread == IntPtr.Zero)
			return 22;
		GCHandle<Thread> handle = GCHandle<Thread>.FromIntPtr(thread);
		handle.Target.Join();
		if (retval != null)
			*retval = null;
		handle.Dispose();
		return 0;
	}

	[MangledName("pthread_detach")]
	public static int PthreadDetach(IntPtr thread)
	{
		if (thread == IntPtr.Zero)
			return 22;
		// Release our reference; thread keeps running as background.
		GCHandle<Thread>.FromIntPtr(thread).Dispose();
		return 0;
	}

	[MangledName("pthread_self")]
	public static IntPtr PthreadSelf()
	{
		// Per-thread stable cookie; [ThreadStatic] means no cross-thread race.
		if (_currentThreadHandle == IntPtr.Zero)
		{
			GCHandle<Thread> h = new GCHandle<Thread>(Thread.CurrentThread);
			_currentThreadHandle = GCHandle<Thread>.ToIntPtr(h);
		}
		return _currentThreadHandle;
	}

	[ThreadStatic]
	private static IntPtr _currentThreadHandle;

	[MangledName("pthread_equal")]
	public static int PthreadEqual(IntPtr t1, IntPtr t2) => t1 == t2 ? 1 : 0;

	[MangledName("pthread_exit")]
	[DoesNotReturn]
	public static void PthreadExit(void* retval) =>
		throw new ThreadInterruptedException("pthread_exit");

	[MangledName("pthread_cancel")]
	public static int PthreadCancel(IntPtr thread)
	{
		if (thread == IntPtr.Zero)
			return 22;
		GCHandle<Thread>.FromIntPtr(thread).Target.Interrupt();
		return 0;
	}

	[MangledName("pthread_setcancelstate")]
	public static int PthreadSetcancelstate(int state, int* oldstate)
	{
		if (oldstate != null)
			*oldstate = 0; // PTHREAD_CANCEL_ENABLE
		return 0;
	}

	[MangledName("pthread_setcanceltype")]
	public static int PthreadSetcanceltype(int type, int* oldtype)
	{
		if (oldtype != null)
			*oldtype = 0; // PTHREAD_CANCEL_DEFERRED
		return 0;
	}

	[MangledName("pthread_testcancel")]
	public static void PthreadTestcancel() { }

	// ── pthread_attr_t stubs ──────────────────────────────────────────────────

	[MangledName("pthread_attr_init")]
	public static int PthreadAttrInit(void* attr) => 0;

	[MangledName("pthread_attr_destroy")]
	public static int PthreadAttrDestroy(void* attr) => 0;

	[MangledName("pthread_attr_setdetachstate")]
	public static int PthreadAttrSetdetachstate(void* attr, int detachstate) => 0;

	[MangledName("pthread_attr_getdetachstate")]
	public static int PthreadAttrGetdetachstate(void* attr, int* detachstate)
	{
		if (detachstate != null)
			*detachstate = 0; // PTHREAD_CREATE_JOINABLE
		return 0;
	}

	[MangledName("pthread_attr_setstacksize")]
	public static int PthreadAttrSetstacksize(void* attr, long stacksize) => 0;

	[MangledName("pthread_attr_getstacksize")]
	public static int PthreadAttrGetstacksize(void* attr, long* stacksize)
	{
		if (stacksize != null)
			*stacksize = 8 * 1024 * 1024; // 8 MiB default
		return 0;
	}

	[MangledName("pthread_attr_setstackaddr")]
	public static int PthreadAttrSetstackaddr(void* attr, void* stackaddr) => 0;

	[MangledName("pthread_attr_getstackaddr")]
	public static int PthreadAttrGetstackaddr(void* attr, void** stackaddr)
	{
		if (stackaddr != null)
			*stackaddr = null;
		return 0;
	}

	[MangledName("pthread_attr_setschedpolicy")]
	public static int PthreadAttrSetschedpolicy(void* attr, int policy) => 0;

	[MangledName("pthread_attr_getschedpolicy")]
	public static int PthreadAttrGetschedpolicy(void* attr, int* policy)
	{
		if (policy != null)
			*policy = 0; // SCHED_OTHER
		return 0;
	}

	[MangledName("pthread_attr_setschedparam")]
	public static int PthreadAttrSetschedparam(void* attr, void* param) => 0;

	[MangledName("pthread_attr_getschedparam")]
	public static int PthreadAttrGetschedparam(void* attr, void* param) => 0;

	[MangledName("pthread_attr_setinheritsched")]
	public static int PthreadAttrSetinheritsched(void* attr, int inheritsched) => 0;

	[MangledName("pthread_attr_getinheritsched")]
	public static int PthreadAttrGetinheritsched(void* attr, int* inheritsched)
	{
		if (inheritsched != null)
			*inheritsched = 0;
		return 0;
	}

	// ── Thread ID / misc ──────────────────────────────────────────────────────

	[MangledName("pthread_getname_np")]
	public static int PthreadGetnameNp(IntPtr thread, byte* name, long len)
	{
		if (name == null || len <= 0)
			return 22;
		name[0] = 0;
		return 0;
	}

	[MangledName("pthread_setname_np")]
	public static int PthreadSetnameNp(IntPtr thread, byte* name)
	{
		if (thread != IntPtr.Zero && name != null)
			GCHandle<Thread>.FromIntPtr(thread).Target.Name = Marshal.PtrToStringUTF8((IntPtr)name);
		return 0;
	}

	[MangledName("pthread_kill")]
	public static int PthreadKill(IntPtr thread, int sig)
	{
		// Signal delivery to a managed thread is not supported; 0 for harmless signals.
		return sig == 0 ? 0 : 22; // EINVAL
	}

	[MangledName("pthread_sigmask")]
	public static int PthreadSigmask(int how, void* set, void* oldset) => 0; // no-op

	// ── POSIX time ────────────────────────────────────────────────────────────
	// struct timespec { long tv_sec; long tv_nsec; }
	// struct timeval  { long tv_sec; long tv_usec; }

	[MangledName("clock_gettime")]
	public static int ClockGettime(int clockId, long* tp)
	{
		if (tp == null)
			return 22; // EINVAL
		// CLOCK_REALTIME=0, CLOCK_MONOTONIC=1, CLOCK_PROCESS_CPUTIME_ID=2, CLOCK_THREAD_CPUTIME_ID=3
		long nanos = clockId switch
		{
			0 => DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() * 1_000_000L,
			_ => (long)(Stopwatch.GetTimestamp() * (1_000_000_000.0 / Stopwatch.Frequency)),
		};
		tp[0] = nanos / 1_000_000_000L; // tv_sec
		tp[1] = nanos % 1_000_000_000L; // tv_nsec
		return 0;
	}

	[MangledName("clock_getres")]
	public static int ClockGetres(int clockId, long* res)
	{
		if (res != null)
		{
			res[0] = 0;
			res[1] = 1; // 1 nanosecond resolution
		}
		return 0;
	}

	[MangledName("clock_nanosleep")]
	public static int ClockNanosleep(int clockId, int flags, long* req, long* rem)
	{
		if (req == null)
			return 22;
		long nsRelative;
		if (flags == 1) // TIMER_ABSTIME
		{
			long targetNs = req[0] * 1_000_000_000L + req[1];
			long nowNs = (long)(Stopwatch.GetTimestamp() * (1_000_000_000.0 / Stopwatch.Frequency));
			nsRelative = Math.Max(0L, targetNs - nowNs);
		}
		else
		{
			nsRelative = req[0] * 1_000_000_000L + req[1];
		}
		if (nsRelative > 0)
			Thread.Sleep((int)Math.Max(1L, nsRelative / 1_000_000L));
		if (rem != null)
		{
			rem[0] = 0;
			rem[1] = 0;
		}
		return 0;
	}

	[MangledName("gettimeofday")]
	public static int Gettimeofday(long* tv, void* tz)
	{
		if (tv == null)
			return 22;
		long ms = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
		tv[0] = ms / 1000L; // tv_sec
		tv[1] = (ms % 1000L) * 1000L; // tv_usec
		return 0;
	}

	[MangledName("nanosleep")]
	public static int Nanosleep(long* req, long* rem)
	{
		if (req == null)
			return 22;
		long ns = req[0] * 1_000_000_000L + req[1];
		if (ns > 0)
			Thread.Sleep((int)Math.Max(1L, ns / 1_000_000L));
		if (rem != null)
		{
			rem[0] = 0;
			rem[1] = 0;
		}
		return 0;
	}

	[MangledName("usleep")]
	public static int Usleep(uint useconds)
	{
		Thread.Sleep((int)Math.Max(1u, useconds / 1000u));
		return 0;
	}

	[MangledName("sleep")]
	public static uint SleepSeconds(uint seconds)
	{
		Thread.Sleep((int)(seconds * 1000u));
		return 0;
	}

	[MangledName("sched_yield")]
	public static int SchedYield()
	{
		Thread.Yield();
		return 0;
	}

	// ── Helper: absolute timespec → relative milliseconds ─────────────────────

	// abstime points to a { long tv_sec; long tv_nsec; } struct.
	private static long ComputeTimeoutMs(long* abstime)
	{
		long now = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
		long target = abstime[0] * 1000L + abstime[1] / 1_000_000L;
		return target - now;
	}
}
#pragma warning restore IDE0060 // Remove unused parameter
