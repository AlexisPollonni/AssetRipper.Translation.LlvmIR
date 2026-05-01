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

	// ── pthread_cond_t backing type ───────────────────────────────────────────

	private sealed class PthreadCondVar
	{
		// Explicit Monitor target for Wait/Pulse; separate from the mutex.
		public readonly object WaitLock = new();
	}

	// ── Helpers retained for TypeInjector / direct-POSIX fallback ───────────

	private static PthreadMutexBase GetOrCreateMutex(IntPtr* mutex) =>
		GetOrCreateSyncObject<PthreadMutexBase>(mutex, static () => new NormalPthreadMutex());

	private static PthreadMutexBase CreateMutexForType(PthreadMutexType type) =>
		type switch
		{
			PthreadMutexType.Recursive => new RecursivePthreadMutex(),
			PthreadMutexType.Errorcheck => new ErrorCheckPthreadMutex(),
			_ => new NormalPthreadMutex(),
		};

	private static ReaderWriterLockSlim GetOrCreateRwLock(IntPtr* rwlock) =>
		GetOrCreateSyncObject(
			rwlock,
			static () => new ReaderWriterLockSlim(LockRecursionPolicy.NoRecursion)
		);

	private static PthreadCondVar GetOrCreateCondVar(IntPtr* cond) =>
		GetOrCreateSyncObject(cond, static () => new PthreadCondVar());

	private static SemaphoreSlim GetOrCreateSemaphore(IntPtr* sem) =>
		GetOrCreateSyncObject(sem, static () => new SemaphoreSlim(0, int.MaxValue));

	// All [MangledName("pthread_*")] / [MangledName("sem_*")] / time functions
	// have been removed.  When using llvm-libc, those symbols are resolved by
	// llvm-libc's own CIL (produced by the transpiler) which calls
	// __dotnet_syscall / __dotnet_clone in IntrinsicFunctions.Linux.Syscalls.cs.
}
#pragma warning restore IDE0060 // Remove unused parameter
