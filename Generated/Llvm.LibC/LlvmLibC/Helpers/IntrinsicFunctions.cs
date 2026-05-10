using System;
using System.Buffers;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace LlvmLibC.Helpers;

internal static partial class IntrinsicFunctions
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	private partial struct RttiTypeDescriptor
	{
	}

	private partial struct CatchableType
	{
		public int field_0;

		public int RttiTypeDescriptorIndex;

		public int field_2;

		public int field_3;

		public int field_4;

		public int field_5;

		public int ConstructorIndex;

		public unsafe readonly RttiTypeDescriptor* RttiTypeDescriptor => unchecked((RttiTypeDescriptor*)PointerIndices.GetPointer(RttiTypeDescriptorIndex));

		public unsafe readonly delegate*<void*, void*, void*> Constructor => unchecked((delegate*<void*, void*, void*>)PointerIndices.GetPointer(ConstructorIndex));
	}

	private partial struct CatchableTypeArray
	{
		public int Count;
	}

	private partial struct ThrowInfo
	{
		public int field_0;

		public int DestructorIndex;

		public int CatchableTypeArrayIndex;

		public unsafe readonly delegate*<void*, void> Destructor => unchecked((delegate*<void*, void>)PointerIndices.GetPointer(DestructorIndex));

		public unsafe readonly ReadOnlySpan<CatchableType> CatchableTypeArray
		{
			get
			{
				unchecked
				{
					CatchableTypeArray* pointer = (CatchableTypeArray*)PointerIndices.GetPointer(CatchableTypeArrayIndex);
					if (pointer == null || pointer->Count <= 0)
					{
						return default(ReadOnlySpan<CatchableType>);
					}
					return new ReadOnlySpan<CatchableType>((void*)checked(unchecked((nuint)pointer) + (nuint)4u), pointer->Count);
				}
			}
		}
	}

	private sealed partial class NativeExceptionInfo : ExceptionInfo
	{
		public unsafe void* ExceptionPointer { get; private set; }

		public unsafe ThrowInfo* ThrowInfo { get; private set; }

		public unsafe NativeExceptionInfo(void* exceptionPointer, ThrowInfo* throwInfo)
		{
			ExceptionPointer = exceptionPointer;
			ThrowInfo = throwInfo;
		}

		public unsafe bool Contains(RttiTypeDescriptor* rttiTypeDescriptor)
		{
			if (ThrowInfo == null)
			{
				return false;
			}
			ReadOnlySpan<CatchableType> catchableTypeArray = ThrowInfo->CatchableTypeArray;
			for (int i = 0; i < catchableTypeArray.Length; i = unchecked(i + 1))
			{
				if (catchableTypeArray[i].RttiTypeDescriptor == rttiTypeDescriptor)
				{
					return true;
				}
			}
			return false;
		}

		protected unsafe override void Dispose(bool disposing)
		{
			if (ExceptionPointer != null && ThrowInfo != null)
			{
				delegate*<void*, void> destructor = ThrowInfo->Destructor;
				if (destructor != unchecked((delegate*<void*, void>)null))
				{
					destructor(ExceptionPointer);
				}
			}
			ExceptionPointer = null;
			ThrowInfo = null;
		}
	}

	private sealed partial class PthreadCondVar
	{
		public readonly object WaitLock = new object();
	}

	private sealed partial class ErrorCheckPthreadMutex : PthreadMutexBase
	{
		private readonly Lock _lock = new Lock();

		private Thread? _owner;

		public override void Enter()
		{
			if (_owner == Thread.CurrentThread)
			{
				throw new SynchronizationLockException("pthread EDEADLK: mutex already owned by this thread");
			}
			_lock.Enter();
			_owner = Thread.CurrentThread;
		}

		public override bool TryEnter()
		{
			if (_owner == Thread.CurrentThread)
			{
				return false;
			}
			if (!_lock.TryEnter())
			{
				return false;
			}
			_owner = Thread.CurrentThread;
			return true;
		}

		public override bool TryEnter(int ms)
		{
			if (_owner == Thread.CurrentThread)
			{
				return false;
			}
			if (!_lock.TryEnter(ms))
			{
				return false;
			}
			_owner = Thread.CurrentThread;
			return true;
		}

		public override void Exit()
		{
			_owner = null;
			_lock.Exit();
		}
	}

	private sealed partial class RecursivePthreadMutex : PthreadMutexBase
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
			{
				return false;
			}
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
			{
				return false;
			}
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

	private sealed partial class NormalPthreadMutex : PthreadMutexBase
	{
		private readonly Lock _lock = new Lock();

		public override void Enter()
		{
			_lock.Enter();
		}

		public override bool TryEnter()
		{
			return _lock.TryEnter();
		}

		public override bool TryEnter(int ms)
		{
			return _lock.TryEnter(ms);
		}

		public override void Exit()
		{
			_lock.Exit();
		}
	}

	private abstract partial class PthreadMutexBase
	{
		public abstract void Enter();

		public abstract bool TryEnter();

		public abstract bool TryEnter(int ms);

		public abstract void Exit();
	}

	private enum PthreadMutexType
	{
		Normal,
		Recursive,
		Errorcheck
	}

	private sealed partial class DirectoryFd
	{
		public readonly string Path;

		public string[]? Entries;

		public int Position;

		public DirectoryFd(string path)
		{
			Path = path;
		}
	}

	private sealed partial class FutexWaiter
	{
		public readonly object Lock = new object();

		public int WaiterCount;
	}

	private partial struct Rlimit64Struct
	{
		public ulong RlimCur;

		public ulong RlimMax;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private partial struct LinuxDirent64Header
	{
		public ulong DIno;

		public long DOff;

		public ushort DReclen;

		public DirentType DType;
	}

	[StructLayout(LayoutKind.Explicit, Size = 256)]
	private partial struct StatxStruct
	{
		[FieldOffset(0)]
		public StatxMask Mask;

		[FieldOffset(4)]
		public uint Blksize;

		[FieldOffset(8)]
		public ulong Attributes;

		[FieldOffset(16)]
		public uint Nlink;

		[FieldOffset(20)]
		public uint Uid;

		[FieldOffset(24)]
		public uint Gid;

		[FieldOffset(28)]
		public ushort Mode;

		[FieldOffset(32)]
		public ulong Ino;

		[FieldOffset(40)]
		public ulong Size;

		[FieldOffset(48)]
		public ulong Blocks;

		[FieldOffset(56)]
		public ulong AttributesMask;

		[FieldOffset(64)]
		public StatxTimestampStruct Atime;

		[FieldOffset(80)]
		public StatxTimestampStruct Btime;

		[FieldOffset(96)]
		public StatxTimestampStruct Ctime;

		[FieldOffset(112)]
		public StatxTimestampStruct Mtime;

		[FieldOffset(128)]
		public uint RdevMajor;

		[FieldOffset(132)]
		public uint RdevMinor;

		[FieldOffset(136)]
		public uint DevMajor;

		[FieldOffset(140)]
		public uint DevMinor;

		[FieldOffset(144)]
		public ulong MntId;
	}

	private partial struct StatxTimestampStruct
	{
		public long TvSec;

		public uint TvNsec;

		public int Reserved;
	}

	private partial struct TimevalStruct
	{
		public long TvSec;

		public long TvUsec;
	}

	private partial struct ThreadStartArgs
	{
		public nint FnPtr;

		public nint ArgPtr;
	}

	private partial struct UnameStruct
	{
		public unsafe fixed byte Sysname[65];

		public unsafe fixed byte Nodename[65];

		public unsafe fixed byte Release[65];

		public unsafe fixed byte Version[65];

		public unsafe fixed byte Machine[65];

		public unsafe fixed byte Domainname[65];
	}

	private partial struct WinsizeStruct
	{
		public ushort WsRow;

		public ushort WsCol;

		public ushort WsXpixel;

		public ushort WsYpixel;
	}

	private partial struct IovecStruct
	{
		public nint IovBase;

		public nuint IovLen;
	}

	[StructLayout(LayoutKind.Explicit, Size = 144)]
	private partial struct StatStructX64
	{
		[FieldOffset(0)]
		public ulong StDev;

		[FieldOffset(8)]
		public ulong StIno;

		[FieldOffset(16)]
		public ulong StNlink;

		[FieldOffset(24)]
		public StatMode StMode;

		[FieldOffset(28)]
		public uint StUid;

		[FieldOffset(32)]
		public uint StGid;

		[FieldOffset(40)]
		public ulong StRdev;

		[FieldOffset(48)]
		public long StSize;

		[FieldOffset(56)]
		public long StBlksize;

		[FieldOffset(64)]
		public long StBlocks;

		[FieldOffset(72)]
		public TimespecStruct StAtim;

		[FieldOffset(88)]
		public TimespecStruct StMtim;

		[FieldOffset(104)]
		public TimespecStruct StCtim;
	}

	private partial struct TimespecStruct
	{
		public long TvSec;

		public long TvNsec;

		public static TimespecStruct FromUtc(DateTime utc)
		{
			long num = new DateTimeOffset(utc).ToUnixTimeMilliseconds();
			return new TimespecStruct
			{
				TvSec = unchecked(num / 1000),
				TvNsec = unchecked(num % 1000) * 1000000
			};
		}

		public static TimespecStruct FromStopwatch()
		{
			return FromNanos((long)((double)Stopwatch.GetTimestamp() * (1000000000.0 / (double)Stopwatch.Frequency)));
		}

		public static TimespecStruct FromNanos(long ns)
		{
			return unchecked(new TimespecStruct
			{
				TvSec = ns / 1000000000,
				TvNsec = ns % 1000000000
			});
		}

		public long ToMilliseconds()
		{
			return TvSec * 1000 + unchecked(TvNsec / 1000000);
		}
	}

	private enum DirentType : byte
	{
		Unknown = 0,
		Fifo = 1,
		Chr = 2,
		Dir = 4,
		Blk = 6,
		Reg = 8,
		Lnk = 10,
		Sock = 12
	}

	[Flags]
	private enum StatxMask : uint
	{
		Type = 1u,
		Mode = 2u,
		Nlink = 4u,
		Uid = 8u,
		Gid = 0x10u,
		Atime = 0x20u,
		Mtime = 0x40u,
		Ctime = 0x80u,
		Ino = 0x100u,
		Size = 0x200u,
		Blocks = 0x400u,
		BasicStats = 0x7FFu,
		Btime = 0x800u,
		MntId = 0x1000u
	}

	private enum RlimitResource
	{
		RLIMIT_CPU = 0,
		RLIMIT_FSIZE = 1,
		RLIMIT_DATA = 2,
		RLIMIT_STACK = 3,
		RLIMIT_CORE = 4,
		RLIMIT_NOFILE = 7,
		RLIMIT_NPROC = 6,
		RLIMIT_AS = 9
	}

	[Flags]
	private enum PipeFlags
	{
		None = 0,
		O_CLOEXEC = 0x80000,
		O_NONBLOCK = 0x800,
		O_DIRECT = 0x4000
	}

	private enum ArchPrctlCode : long
	{
		ARCH_SET_GS = 4097L,
		ARCH_SET_FS = 4098L,
		ARCH_GET_FS = 4099L,
		ARCH_GET_GS = 4100L,
		ARCH_GET_CPUID = 4113L,
		ARCH_SET_CPUID = 4114L
	}

	[Flags]
	private enum AtFlags
	{
		RemoveDir = 0x200,
		SymlinkNoFollow = 0x100
	}

	private enum AtDirfd
	{
		FDCWD = -100
	}

	[Flags]
	private enum TimerFlags
	{
		Relative = 0,
		AbsoluteTime = 1
	}

	private enum ClockId
	{
		Realtime,
		Monotonic,
		ProcessCpu,
		ThreadCpu
	}

	private enum IoctlRequest : long
	{
		TIOCGWINSZ = 21523L,
		TIOCSWINSZ = 21524L,
		FIONREAD = 21531L
	}

	private enum FcntlCommand : long
	{
		F_DUPFD = 0L,
		F_GETFD = 1L,
		F_SETFD = 2L,
		F_GETFL = 3L,
		F_SETFL = 4L,
		F_DUPFD_CLOEXEC = 1030L
	}

	[Flags]
	private enum CloneFlags : long
	{
		Thread = 0x10000L,
		Vm = 0x100L,
		Fs = 0x200L,
		Files = 0x400L,
		Sighand = 0x800L,
		Sysvsem = 0x40000L,
		Settls = 0x80000L,
		ParentSetTid = 0x100000L,
		ChildClearTid = 0x200000L
	}

	[Flags]
	private enum MmapFlags
	{
		Shared = 1,
		Private = 2,
		Fixed = 0x10,
		Anonymous = 0x20
	}

	[Flags]
	private enum MmapProtection
	{
		None = 0,
		Read = 1,
		Write = 2,
		Exec = 4
	}

	[Flags]
	private enum FutexOperation
	{
		Wait = 0,
		Wake = 1,
		Requeue = 3,
		WaitBitset = 9,
		WakeBitset = 0xA,
		PrivateFlag = 0x80,
		ClockFlag = 0x100
	}

	[Flags]
	private enum StatMode : uint
	{
		S_IFMT = 0xF000u,
		S_IFREG = 0x8000u,
		S_IFDIR = 0x4000u,
		S_IFCHR = 0x2000u,
		S_IRUSR = 0x100u,
		S_IWUSR = 0x80u,
		S_IXUSR = 0x40u,
		S_IRGRP = 0x20u,
		S_IWGRP = 0x10u,
		S_IXGRP = 8u,
		S_IROTH = 4u,
		S_IWOTH = 2u,
		S_IXOTH = 1u,
		RegFile644 = 0x81A4u,
		Dir755 = 0x41EDu,
		ChrDev = 0x21B6u
	}

	private enum LinuxErrno : long
	{
		Success = 0L,
		EPERM = -1L,
		ENOENT = -2L,
		EIO = -5L,
		EBADF = -9L,
		ECHILD = -10L,
		EAGAIN = -11L,
		ENOMEM = -12L,
		EACCES = -13L,
		EFAULT = -14L,
		EBUSY = -16L,
		EEXIST = -17L,
		ENOTDIR = -20L,
		EINVAL = -22L,
		ESPIPE = -29L,
		ERANGE = -34L,
		ENOSYS = -38L,
		ENOTEMPTY = -39L,
		ELOOP = -40L,
		ENOTSUP = -95L,
		EAFNOSUPPORT = -97L,
		ETIMEDOUT = -110L,
		ECONNREFUSED = -111L
	}

	private enum SyscallNumber : long
	{
		Read = 0L,
		Write = 1L,
		Open = 2L,
		Close = 3L,
		Stat = 4L,
		Fstat = 5L,
		Lstat = 6L,
		Poll = 7L,
		Lseek = 8L,
		Mmap = 9L,
		Mprotect = 10L,
		Munmap = 11L,
		Brk = 12L,
		RtSigaction = 13L,
		RtSigprocmask = 14L,
		Pread64 = 17L,
		Pwrite64 = 18L,
		Readv = 19L,
		Writev = 20L,
		Access = 21L,
		Pipe = 22L,
		Select = 23L,
		SchedYield = 24L,
		Madvise = 28L,
		Dup = 32L,
		Dup2 = 33L,
		Nanosleep = 35L,
		Getpid = 39L,
		Sendfile = 40L,
		Socket = 41L,
		Connect = 42L,
		Accept = 43L,
		SendTo = 44L,
		RecvFrom = 45L,
		SendMsg = 46L,
		RecvMsg = 47L,
		Shutdown = 48L,
		Bind = 49L,
		Listen = 50L,
		Getsockname = 51L,
		Getpeername = 52L,
		Setsockopt = 54L,
		Getsockopt = 55L,
		Clone = 56L,
		Exit = 60L,
		Wait4 = 61L,
		Kill = 62L,
		Uname = 63L,
		Fcntl = 72L,
		Fsync = 74L,
		Fdatasync = 75L,
		Ftruncate = 77L,
		Getcwd = 79L,
		Chdir = 80L,
		Rename = 82L,
		Mkdir = 83L,
		Rmdir = 84L,
		Unlink = 87L,
		Readlink = 89L,
		Fchmod = 91L,
		Gettimeofday = 96L,
		Getuid = 102L,
		Getgid = 104L,
		Getppid = 110L,
		Ioctl = 16L,
		Prctl = 157L,
		ArchPrctl = 158L,
		Gettid = 186L,
		Futex = 202L,
		Getdents64 = 217L,
		SetTidAddress = 218L,
		ClockGettime = 228L,
		ClockGetres = 229L,
		ClockNanosleep = 230L,
		ExitGroup = 231L,
		Tgkill = 234L,
		Waitid = 247L,
		Openat = 257L,
		Mkdirat = 258L,
		Newfstatat = 262L,
		Unlinkat = 263L,
		Renameat = 264L,
		Symlinkat = 266L,
		Readlinkat = 267L,
		Pselect6 = 270L,
		SetRobustList = 273L,
		Accept4 = 288L,
		Dup3 = 292L,
		Pipe2 = 293L,
		Prlimit64 = 302L,
		Getrandom = 318L,
		CopyFileRange = 326L,
		Statx = 332L,
		Rseq = 334L
	}

	[Flags]
	public enum PosixAccessMode
	{
		F_OK = 0,
		X_OK = 1,
		W_OK = 2,
		R_OK = 4
	}

	public enum PosixSeekWhence
	{
		SEEK_SET,
		SEEK_CUR,
		SEEK_END
	}

	[Flags]
	public enum PosixOpenFlags
	{
		O_RDONLY = 0,
		O_WRONLY = 1,
		O_RDWR = 2,
		O_CREAT = 0x40,
		O_EXCL = 0x80,
		O_TRUNC = 0x200,
		O_APPEND = 0x400
	}

	private sealed partial class ItaniumExceptionInfo : ExceptionInfo
	{
		private unsafe delegate*<void*, void> _destructor;

		public unsafe void* ExceptionPointer { get; private set; }

		public unsafe void* TypeInfo { get; private set; }

		public unsafe ItaniumExceptionInfo(void* exceptionPointer, void* typeInfo, delegate*<void*, void> destructor)
		{
			ExceptionPointer = exceptionPointer;
			TypeInfo = typeInfo;
			_destructor = destructor;
		}

		protected unsafe override void Dispose(bool disposing)
		{
			if (ExceptionPointer != null && _destructor != unchecked((delegate*<void*, void>)null))
			{
				_destructor(ExceptionPointer);
			}
			ExceptionPointer = null;
			TypeInfo = null;
			_destructor = null;
		}
	}

	private sealed partial class AssertExceptionInfo : ExceptionInfo
	{
		public string Message { get; }

		public AssertExceptionInfo(string message)
		{
			Message = message;
		}

		public override string? GetMessage()
		{
			return Message;
		}
	}

	private static readonly ConcurrentStack<nint> atexitFunctions = new ConcurrentStack<nint>();

	private static Random? _randomField;

	private static readonly long StartTicks = Environment.TickCount64;

	[ThreadStatic]
	private unsafe static int* _errnoPtr;

	private unsafe static byte* _strerrorBuf;

	private static readonly ConcurrentDictionary<string, nint> _envCache = new ConcurrentDictionary<string, nint>();

	private static readonly ConcurrentStack<nint> _cxaAtexitFuncs = new ConcurrentStack<nint>();

	private static readonly ConcurrentStack<nint> _cxaAtexitArgs = new ConcurrentStack<nint>();

	private unsafe static byte* _cLocale;

	private static readonly ConcurrentDictionary<int, Stream> _fileDescriptors = new ConcurrentDictionary<int, Stream>();

	private static int _nextFd = 3;

	private const int FD_CLOEXEC = 1;

	private const uint DefaultUid = 1000u;

	private const uint DefaultGid = 1000u;

	private static readonly ConcurrentDictionary<nint, FutexWaiter> _futexWaiters = new ConcurrentDictionary<nint, FutexWaiter>();

	private static readonly ConcurrentDictionary<nint, nuint> _mmapAllocations = new ConcurrentDictionary<nint, nuint>();

	private static readonly ConcurrentDictionary<int, DirectoryFd> _directoryFds = new ConcurrentDictionary<int, DirectoryFd>();

	[ThreadStatic]
	private unsafe static int* _tidAddress;

	internal unsafe static void* StandardInput => unchecked((void*)(nuint)1u);

	internal unsafe static void* StandardOutput => unchecked((void*)(nuint)2u);

	internal unsafe static void* StandardError => unchecked((void*)(nuint)3u);

	private static Random _random => _randomField ?? (_randomField = new Random());

	[MangledName("llvm.experimental.noalias.scope.decl")]
	[MangledName("llvm.lifetime.start.p0")]
	[MangledName("llvm.lifetime.end.p0")]
	[MangledName("llvm.assume")]
	public static void DoNothing(object parameter)
	{
	}

	[MangledName("llvm.dbg.value")]
	[MangledName("llvm.dbg.declare")]
	[MangledName("llvm.dbg.label")]
	public static void DoNothingDebug(object p1, object p2, object p3)
	{
	}

	[MangledName("llvm.x86.sse2.pause")]
	public static void Sse2Pause()
	{
		Thread.SpinWait(1);
	}

	[MangledName("llvm.x86.sse.stmxcsr")]
	public unsafe static void SseStoreMxcsr(uint* mem)
	{
		if (mem != null)
		{
			*mem = 8064u;
		}
	}

	[MangledName("llvm.x86.sse.ldmxcsr")]
	public unsafe static void SseLoadMxcsr(uint* mem)
	{
	}

	[DoesNotReturn]
	[MangledName("terminate")]
	[MangledName("llvm.trap")]
	[MangledName("llvm.debugtrap")]
	public static void Terminate()
	{
		throw new FatalException("Terminate");
	}

	[DoesNotReturn]
	[MangledName("exit")]
	public static void Exit(int exitCode)
	{
		Environment.Exit(exitCode);
	}

	[MangledName("atexit")]
	public unsafe static int AtExit(delegate*<void> func)
	{
		unchecked
		{
			if (atexitFunctions.IsEmpty)
			{
				lock (atexitFunctions)
				{
					if (atexitFunctions.IsEmpty)
					{
						AppDomain.CurrentDomain.ProcessExit += delegate
						{
							nint result;
							while (atexitFunctions.TryPop(out result))
							{
								((delegate*<void>)checked((nuint)result))();
							}
						};
					}
				}
			}
		}
		atexitFunctions.Push((nint)func);
		return 0;
	}

	[MangledName("llvm.va_start.p0")]
	public unsafe static void llvm_va_start(void** va_list)
	{
		throw new NotSupportedException();
	}

	[MangledName("llvm.va_copy.p0")]
	public unsafe static void llvm_va_copy(void** destination, void** source)
	{
		*destination = *source;
	}

	[MangledName("llvm.va_end.p0")]
	public unsafe static void llvm_va_end(void** va_list)
	{
	}

	[MangledName("puts")]
	public unsafe static int PutString(sbyte* str)
	{
		try
		{
			string text = Marshal.PtrToStringAnsi((nint)str);
			Console.WriteLine(text);
			return text?.Length ?? 0;
		}
		catch
		{
			return -1;
		}
	}

	[MangledName("fputs")]
	public unsafe static int PutString(sbyte* str, void* file)
	{
		try
		{
			string text = Marshal.PtrToStringAnsi((nint)str);
			if (file == StandardOutput)
			{
				Console.Write(text);
			}
			else
			{
				if (file != StandardError)
				{
					return -1;
				}
				Console.Error.Write(text);
			}
			return text?.Length ?? 0;
		}
		catch
		{
			return -1;
		}
	}

	[MangledName("fflush")]
	public unsafe static int FFlush(void* file)
	{
		if (file == StandardOutput || file == null)
		{
			Console.Out.Flush();
		}
		if (file == StandardError || file == null)
		{
			Console.Error.Flush();
		}
		return 0;
	}

	[MangledName("putchar")]
	[MangledName("putchar_unlocked")]
	public static int Putchar(int c)
	{
		unchecked
		{
			Console.Write((char)checked((byte)c));
			return c;
		}
	}

	[MangledName("getchar")]
	[MangledName("getchar_unlocked")]
	public static int Getchar()
	{
		return Console.Read();
	}

	[MangledName("fputc")]
	[MangledName("putc")]
	public unsafe static int FPutc(int c, void* file)
	{
		unchecked
		{
			char value = (char)checked((byte)c);
			if (file == StandardOutput)
			{
				Console.Write(value);
			}
			else
			{
				if (file != StandardError)
				{
					return -1;
				}
				Console.Error.Write(value);
			}
			return c;
		}
	}

	[MangledName("fgetc")]
	[MangledName("getc")]
	public unsafe static int FGetc(void* file)
	{
		return (file == StandardInput) ? Console.Read() : (-1);
	}

	[MangledName("perror")]
	public unsafe static void Perror(byte* s)
	{
		string text = ((s != null) ? Marshal.PtrToStringUTF8((nint)s) : null);
		Console.Error.WriteLine((text != null && text.Length > 0) ? (text + ": error") : "error");
	}

	internal unsafe static string? FormatPrintf(byte* format, ReadOnlySpan<nint> args)
	{
		if (format == null)
		{
			return null;
		}
		string text = Marshal.PtrToStringUTF8((nint)format) ?? "";
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		int num2 = 0;
		while (num2 < text.Length)
		{
			if (text[num2] != '%')
			{
				stringBuilder.Append(text[num2++]);
				continue;
			}
			num2++;
			if (num2 >= text.Length)
			{
				break;
			}
			if (text[num2] == '%')
			{
				stringBuilder.Append('%');
				num2++;
				continue;
			}
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			while (num2 < text.Length)
			{
				switch (text[num2])
				{
				case '-':
					flag = true;
					num2++;
					continue;
				case '+':
					flag2 = true;
					num2++;
					continue;
				case ' ':
					flag3 = true;
					num2++;
					continue;
				case '0':
					flag4 = true;
					num2++;
					continue;
				case '#':
					flag5 = true;
					num2++;
					continue;
				}
				break;
			}
			int num3 = 0;
			if (num2 < text.Length && text[num2] == '*')
			{
				num3 = (int)((num < args.Length) ? args[num++] : 0);
				if (num3 < 0)
				{
					flag = true;
					num3 = -num3;
				}
				num2++;
			}
			else
			{
				while (num2 < text.Length && char.IsAsciiDigit(text[num2]))
				{
					num3 = num3 * 10 + (text[num2++] - 48);
				}
			}
			int num4 = -1;
			if (num2 < text.Length && text[num2] == '.')
			{
				num2++;
				if (num2 < text.Length && text[num2] == '*')
				{
					num4 = (int)((num < args.Length) ? args[num++] : 0);
					if (num4 < 0)
					{
						num4 = -1;
					}
					num2++;
				}
				else
				{
					num4 = 0;
					while (num2 < text.Length && char.IsAsciiDigit(text[num2]))
					{
						num4 = num4 * 10 + (text[num2++] - 48);
					}
				}
			}
			int num5 = 0;
			if (num2 < text.Length)
			{
				switch (text[num2])
				{
				case 'h':
					num2++;
					if (num2 < text.Length && text[num2] == 'h')
					{
						num2++;
						num5 = -1;
					}
					else
					{
						num5 = 1;
					}
					break;
				case 'l':
					num2++;
					if (num2 < text.Length && text[num2] == 'l')
					{
						num2++;
						num5 = 3;
					}
					else
					{
						num5 = 2;
					}
					break;
				case 'j':
					num2++;
					num5 = 3;
					break;
				case 'z':
					num2++;
					num5 = 4;
					break;
				case 't':
					num2++;
					num5 = 5;
					break;
				case 'L':
					num2++;
					num5 = 6;
					break;
				case 'I':
					if (num2 + 2 < text.Length && text[num2 + 1] == '6' && text[num2 + 2] == '4')
					{
						num2 += 3;
						num5 = 3;
					}
					else if (num2 + 2 < text.Length && text[num2 + 1] == '3' && text[num2 + 2] == '2')
					{
						num2 += 3;
						num5 = 2;
					}
					else
					{
						num2++;
					}
					break;
				}
			}
			if (num2 >= text.Length)
			{
				break;
			}
			char c = text[num2++];
			string value;
			switch (c)
			{
			case 'd':
			case 'i':
				value = FmtSignedInt((num5 < 2) ? ((int)((num < args.Length) ? args[num++] : 0)) : ((num < args.Length) ? args[num++] : 0), num3, num4, flag, flag2, flag3, flag4);
				break;
			case 'u':
			{
				string text4 = ((num5 >= 2) ? ((ulong)((num < args.Length) ? args[num++] : 0)) : ((uint)((num < args.Length) ? args[num++] : 0))).ToString();
				if (num4 >= 0 && text4.Length < num4)
				{
					text4 = text4.PadLeft(num4, '0');
				}
				value = (flag ? text4.PadRight(num3) : ((flag4 && num4 < 0) ? text4.PadLeft(num3, '0') : text4.PadLeft(num3)));
				break;
			}
			case 'X':
			case 'x':
			{
				ulong num10 = ((num5 >= 2) ? ((ulong)((num < args.Length) ? args[num++] : 0)) : ((uint)((num < args.Length) ? args[num++] : 0)));
				string text5 = ((c == 'x') ? num10.ToString("x") : num10.ToString("X"));
				if (num4 >= 0 && text5.Length < num4)
				{
					text5 = text5.PadLeft(num4, '0');
				}
				if (flag5 && num10 != 0)
				{
					text5 = ((c == 'x') ? "0x" : "0X") + text5;
				}
				value = (flag ? text5.PadRight(num3) : ((flag4 && num4 < 0) ? text5.PadLeft(num3, '0') : text5.PadLeft(num3)));
				break;
			}
			case 'o':
			{
				string text8 = Convert.ToString((long)((num5 >= 2) ? ((ulong)((num < args.Length) ? args[num++] : 0)) : ((uint)((num < args.Length) ? args[num++] : 0))), 8);
				if (flag5 && !text8.StartsWith('0'))
				{
					text8 = "0" + text8;
				}
				if (num4 >= 0 && text8.Length < num4)
				{
					text8 = text8.PadLeft(num4, '0');
				}
				value = (flag ? text8.PadRight(num3) : text8.PadLeft(num3));
				break;
			}
			case 'F':
			case 'f':
			{
				nint num13 = ((num < args.Length) ? args[num++] : 0);
				double num14 = *unchecked((double*)(&num13));
				int num15 = ((num4 >= 0) ? num4 : 6);
				string text9 = ((num14 < 0.0) ? "-" : (flag2 ? "+" : (flag3 ? " " : ""))) + Math.Abs(num14).ToString("F" + num15, CultureInfo.InvariantCulture);
				value = (flag ? text9.PadRight(num3) : text9.PadLeft(num3));
				break;
			}
			case 'E':
			case 'e':
			{
				nint num7 = ((num < args.Length) ? args[num++] : 0);
				double num8 = *unchecked((double*)(&num7));
				int num9 = ((num4 >= 0) ? num4 : 6);
				string s = num8.ToString(((c == 'e') ? "e" : "E") + num9, CultureInfo.InvariantCulture);
				value = (flag ? NormSciExp(s).PadRight(num3) : NormSciExp(s).PadLeft(num3));
				break;
			}
			case 'G':
			case 'g':
			{
				nint num6 = ((num < args.Length) ? args[num++] : 0);
				string text3 = ((double)(*unchecked((double*)(&num6)))).ToString("G" + ((num4 < 0) ? 6 : ((num4 == 0) ? 1 : num4)), CultureInfo.InvariantCulture);
				if (c == 'g')
				{
					text3 = text3.Replace("E+", "e+").Replace("E-", "e-");
				}
				text3 = NormSciExp(text3);
				if (!flag5 && text3.Contains('.') && !text3.Contains('e') && !text3.Contains('E'))
				{
					text3 = text3.TrimEnd('0').TrimEnd('.');
				}
				value = (flag ? text3.PadRight(num3) : text3.PadLeft(num3));
				break;
			}
			case 'c':
			{
				nint num11 = ((num < args.Length) ? args[num++] : 0);
				unchecked
				{
					string text6 = ((num5 >= 2) ? ((char)checked((ushort)(int)num11)).ToString() : ((char)checked((byte)(int)num11)).ToString());
					value = (flag ? text6.PadRight(num3) : text6.PadLeft(num3));
					break;
				}
			}
			case 's':
			{
				nint num12 = ((num < args.Length) ? args[num++] : 0);
				string text7 = ((num12 == 0) ? "(null)" : ((num5 >= 2) ? (Marshal.PtrToStringUni(num12) ?? "") : (Marshal.PtrToStringUTF8(num12) ?? "")));
				if (num4 >= 0 && text7.Length > num4)
				{
					text7 = text7.Substring(0, num4);
				}
				value = (flag ? text7.PadRight(num3) : text7.PadLeft(num3));
				break;
			}
			case 'p':
				unchecked
				{
					string text2 = "0x" + ((ulong)checked((nuint)((num < args.Length) ? args[num++] : 0))).ToString("x");
					value = (flag ? text2.PadRight(num3) : text2.PadLeft(num3));
					break;
				}
			case 'n':
				value = "";
				break;
			default:
				value = "%" + c;
				break;
			}
			stringBuilder.Append(value);
		}
		return stringBuilder.ToString();
	}

	private static string FmtSignedInt(long v, int width, int prec, bool minus, bool plus, bool space, bool zero)
	{
		string text = ((v < 0) ? "-" : (plus ? "+" : (space ? " " : "")));
		string text2 = ((v < 0) ? unchecked((ulong)(-v)) : ((ulong)v)).ToString();
		if (prec >= 0 && text2.Length < prec)
		{
			text2 = text2.PadLeft(prec, '0');
		}
		string text3 = text + text2;
		if (minus)
		{
			return text3.PadRight(width);
		}
		if (zero && prec < 0)
		{
			return text + text2.PadLeft(width - text.Length, '0');
		}
		return text3.PadLeft(width);
	}

	private static string NormSciExp(string s)
	{
		int num = s.IndexOfAny(new char[2] { 'e', 'E' });
		if (num < 0)
		{
			return s;
		}
		string text = s.Substring(0, num);
		char c = s[num];
		string text2 = s;
		int num2 = num + 1;
		unchecked
		{
			string text3 = text2.Substring(num2, text2.Length - num2);
			char c2 = text3[0];
			text2 = text3;
			string text4 = text2.Substring(1, text2.Length - 1).TrimStart('0');
			if (text4.Length == 0)
			{
				text4 = "0";
			}
			if (text4.Length < 2)
			{
				text4 = text4.PadLeft(2, '0');
			}
			return text + c + c2 + text4;
		}
	}

	[MangledName("strcmp")]
	public unsafe static int strcmp(byte* p1, byte* p2)
	{
		unchecked
		{
			while (*p1 == *p2 && *p1 != 0)
			{
				p1 = (byte*)checked(unchecked((nuint)p1) + (nuint)1u);
				p2 = (byte*)checked(unchecked((nuint)p2) + (nuint)1u);
			}
		}
		return *p1 - *p2;
	}

	[MangledName("strncmp")]
	public unsafe static int strncmp(byte* p1, byte* p2, long count)
	{
		for (long num = 0L; num < count; num++)
		{
			if (p1[num] != p2[num])
			{
				return p1[num] - p2[num];
			}
			if (p1[num] == 0)
			{
				return 0;
			}
		}
		return 0;
	}

	[MangledName("memchr")]
	public unsafe static byte* memchr(byte* data, int c, long length)
	{
		if (data == null)
		{
			return null;
		}
		unchecked
		{
			byte b = (byte)c;
			for (long num = 0L; num < length; num = checked(num + 1))
			{
				if (data[num] == b)
				{
					return (byte*)checked(unchecked((nuint)data) + unchecked((nuint)num));
				}
			}
			return null;
		}
	}

	[MangledName("strchr")]
	public unsafe static byte* strchr(byte* str, int c)
	{
		if (str == null)
		{
			return null;
		}
		unchecked
		{
			byte b = (byte)c;
			while (*str != 0)
			{
				if (*str == b)
				{
					return str;
				}
				str = (byte*)checked(unchecked((nuint)str) + (nuint)1u);
			}
			return (b == 0) ? str : null;
		}
	}

	[MangledName("strstr")]
	public unsafe static byte* strstr(byte* haystack, byte* needle)
	{
		if (haystack == null || needle == null)
		{
			return null;
		}
		long num = strlen(haystack);
		int num2 = MemoryExtensions.IndexOf(value: new ReadOnlySpan<byte>(needle, (int)strlen(needle)), span: new ReadOnlySpan<byte>(haystack, (int)num));
		unchecked
		{
			return (byte*)((num2 >= 0) ? checked(unchecked((nuint)haystack) + unchecked((nuint)num2)) : 0u);
		}
	}

	[MangledName("strrchr")]
	public unsafe static byte* strrchr(byte* str, int c)
	{
		if (str == null)
		{
			return null;
		}
		int num = new ReadOnlySpan<byte>(str, (int)strlen(str)).LastIndexOf((byte)c);
		unchecked
		{
			return (byte*)((num >= 0) ? checked(unchecked((nuint)str) + unchecked((nuint)num)) : 0u);
		}
	}

	[MangledName("strrstr")]
	public unsafe static byte* strrstr(byte* haystack, byte* needle)
	{
		if (haystack == null || needle == null)
		{
			return null;
		}
		long num = strlen(haystack);
		int num2 = MemoryExtensions.LastIndexOf(value: new ReadOnlySpan<byte>(needle, (int)strlen(needle)), span: new ReadOnlySpan<byte>(haystack, (int)num));
		unchecked
		{
			return (byte*)((num2 >= 0) ? checked(unchecked((nuint)haystack) + unchecked((nuint)num2)) : 0u);
		}
	}

	[MangledName("strlen")]
	public unsafe static long strlen(byte* str)
	{
		if (str == null)
		{
			return 0L;
		}
		long num = 0L;
		while (*str != 0)
		{
			num++;
			unchecked
			{
				str = (byte*)checked(unchecked((nuint)str) + (nuint)1u);
			}
		}
		return num;
	}

	[MangledName("strnlen")]
	public unsafe static long strnlen(byte* str, long maxLen)
	{
		if (str == null)
		{
			return 0L;
		}
		long num = 0L;
		while (num < maxLen && *str != 0)
		{
			num++;
			unchecked
			{
				str = (byte*)checked(unchecked((nuint)str) + (nuint)1u);
			}
		}
		return num;
	}

	[MangledName("wcslen")]
	public unsafe static long wcslen(char* str)
	{
		if (str == null)
		{
			return 0L;
		}
		long num = 0L;
		while (*str != 0)
		{
			num++;
			unchecked
			{
				str = (char*)checked(unchecked((nuint)str) + (nuint)2u);
			}
		}
		return num;
	}

	[MangledName("strcpy")]
	public unsafe static byte* strcpy(byte* dst, byte* src)
	{
		if (dst == null || src == null)
		{
			return dst;
		}
		long num = strlen(src);
		Buffer.MemoryCopy(src, dst, num + 1, num + 1);
		return dst;
	}

	[MangledName("strncpy")]
	public unsafe static byte* strncpy(byte* destination, byte* source, long count)
	{
		if (destination == null || source == null)
		{
			return null;
		}
		long num = StringLengthWithMaximum(source, count);
		if (num > 0)
		{
			Buffer.MemoryCopy(source, destination, count, num);
		}
		if (num < count)
		{
			new Span<byte>(unchecked((void*)checked(unchecked((nuint)destination) + unchecked((nuint)num))), (int)(count - num)).Clear();
		}
		return destination;
	}

	[MangledName("strncat")]
	public unsafe static byte* strncat(byte* destination, byte* source, long count)
	{
		if (destination == null || source == null)
		{
			return null;
		}
		long num = strlen(destination);
		long num2 = StringLengthWithMaximum(source, (int)count);
		unchecked
		{
			if (num2 > 0)
			{
				Buffer.MemoryCopy(source, (void*)checked(unchecked((nuint)destination) + unchecked((nuint)num)), count, num2);
			}
		}
		destination[num + num2] = 0;
		return destination;
	}

	[MangledName("strcat")]
	public unsafe static byte* strcat(byte* destination, byte* source)
	{
		return strncat(destination, source, 2147483647L);
	}

	[MangledName("strdup")]
	public unsafe static byte* strdup(byte* str)
	{
		if (str == null)
		{
			return null;
		}
		long num = strlen(str);
		byte* ptr;
		unchecked
		{
			ptr = (byte*)NativeMemoryHelper.Allocate(checked(num + 1));
		}
		Buffer.MemoryCopy(str, ptr, num + 1, num + 1);
		return ptr;
	}

	[MangledName("strndup")]
	public unsafe static byte* strndup(byte* str, long n)
	{
		if (str == null)
		{
			return null;
		}
		long num = strnlen(str, n);
		unchecked
		{
			byte* ptr = (byte*)NativeMemoryHelper.Allocate(checked(num + 1));
			if (num > 0)
			{
				Buffer.MemoryCopy(str, ptr, num, num);
			}
			ptr[num] = 0;
			return ptr;
		}
	}

	private unsafe static long StringLengthWithMaximum(byte* str, long maxLength)
	{
		if (str == null)
		{
			return 0L;
		}
		long num = 0L;
		while (num < maxLength && *str != 0)
		{
			num++;
			unchecked
			{
				str = (byte*)checked(unchecked((nuint)str) + (nuint)1u);
			}
		}
		return num;
	}

	[MangledName("tolower")]
	public static int ToLower(int character)
	{
		unchecked
		{
			if ((uint)character >= 65535u)
			{
				return character;
			}
			return char.ToLowerInvariant((char)character);
		}
	}

	[MangledName("toupper")]
	public static int ToUpper(int character)
	{
		unchecked
		{
			if ((uint)character >= 65535u)
			{
				return character;
			}
			return char.ToUpperInvariant((char)character);
		}
	}

	[MangledName("isalpha")]
	public static int IsAlpha(int c)
	{
		return IsCClass(c, char.IsLetter);
	}

	[MangledName("isdigit")]
	public static int IsDigit(int c)
	{
		return IsCClass(c, char.IsAsciiDigit);
	}

	[MangledName("isalnum")]
	public static int IsAlNum(int c)
	{
		return IsCClass(c, char.IsLetterOrDigit);
	}

	[MangledName("isspace")]
	public static int IsSpace(int c)
	{
		return IsCClass(c, char.IsWhiteSpace);
	}

	[MangledName("isupper")]
	public static int IsUpper(int c)
	{
		return IsCClass(c, char.IsUpper);
	}

	[MangledName("islower")]
	public static int IsLower(int c)
	{
		return IsCClass(c, char.IsLower);
	}

	[MangledName("isprint")]
	public static int IsPrint(int c)
	{
		return IsCClass(c, (char ch) => !char.IsControl(ch));
	}

	[MangledName("isgraph")]
	public static int IsGraph(int c)
	{
		return IsCClass(c, (char ch) => !char.IsControl(ch) && ch != ' ');
	}

	[MangledName("ispunct")]
	public static int IsPunct(int c)
	{
		return IsCClass(c, char.IsPunctuation);
	}

	[MangledName("iscntrl")]
	public static int IsCntrl(int c)
	{
		return IsCClass(c, char.IsControl);
	}

	[MangledName("isblank")]
	public static int IsBlank(int c)
	{
		return (c == 32 || c == 9) ? 1 : 0;
	}

	[MangledName("isxdigit")]
	public static int IsXDigit(int c)
	{
		return IsCClass(c, char.IsAsciiHexDigit);
	}

	private static int IsCClass(int character, Func<char, bool> predicate)
	{
		return unchecked((uint)character <= 65535u && predicate((char)character)) ? 1 : 0;
	}

	[MangledName("atoi")]
	public unsafe static int AsciiToInteger(byte* str)
	{
		return (int)strtol(str, null, 10);
	}

	[MangledName("atol")]
	public unsafe static long atol(byte* str)
	{
		return strtol(str, null, 10);
	}

	[MangledName("atoll")]
	public unsafe static long atoll(byte* str)
	{
		return strtol(str, null, 10);
	}

	[MangledName("atof")]
	public unsafe static double atof(byte* str)
	{
		return strtod(str, null);
	}

	[MangledName("strtol")]
	[MangledName("strtoll")]
	public unsafe static long strtol(byte* str, byte** endptr, int numBase)
	{
		if (str == null)
		{
			if (endptr != null)
			{
				*endptr = str;
			}
			return 0L;
		}
		string text = Marshal.PtrToStringUTF8((nint)str) ?? "";
		int i;
		for (i = 0; i < text.Length && char.IsWhiteSpace(text[i]); i++)
		{
		}
		long num = 1L;
		if (i < text.Length && text[i] == '-')
		{
			num = -1L;
			i++;
		}
		else if (i < text.Length && text[i] == '+')
		{
			i++;
		}
		if (numBase == 0)
		{
			bool flag = i + 1 < text.Length && text[i] == '0';
			if (flag)
			{
				char c = text[i + 1];
				flag = ((c == 'X' || c == 'x') ? true : false);
			}
			numBase = (flag ? 16 : ((i >= text.Length || text[i] != '0') ? 10 : 8));
		}
		bool flag2 = numBase == 16 && i + 1 < text.Length && text[i] == '0';
		if (flag2)
		{
			char c = text[i + 1];
			flag2 = ((c == 'X' || c == 'x') ? true : false);
		}
		if (flag2)
		{
			i += 2;
		}
		int num2 = i;
		long num3 = 0L;
		for (; i < text.Length; i++)
		{
			int num4 = ParseDigit(text[i], numBase);
			if (num4 < 0)
			{
				break;
			}
			num3 = num3 * numBase + num4;
		}
		unchecked
		{
			if (endptr != null)
			{
				*endptr = (byte*)checked(unchecked((nuint)str) + unchecked((nuint)i));
			}
		}
		return (i == num2) ? 0 : (num * num3);
		static int ParseDigit(char c2, int b)
		{
			int num5 = ((c2 >= '0' && c2 <= '9') ? (c2 - 48) : ((c2 >= 'a' && c2 <= 'z') ? (c2 - 97 + 10) : ((c2 >= 'A' && c2 <= 'Z') ? (c2 - 65 + 10) : (-1))));
			return (num5 >= 0 && num5 < b) ? num5 : (-1);
		}
	}

	[MangledName("strtoul")]
	[MangledName("strtoull")]
	public unsafe static ulong strtoul(byte* str, byte** endptr, int numBase)
	{
		return (ulong)strtol(str, endptr, numBase);
	}

	[MangledName("strtod")]
	public unsafe static double strtod(byte* str, byte** endptr)
	{
		if (str == null)
		{
			if (endptr != null)
			{
				*endptr = str;
			}
			return 0.0;
		}
		string text = Marshal.PtrToStringUTF8((nint)str) ?? "";
		int i;
		for (i = 0; i < text.Length && char.IsWhiteSpace(text[i]); i++)
		{
		}
		int num = i;
		bool flag = i < text.Length;
		if (flag)
		{
			char c = text[i];
			flag = ((c == '+' || c == '-') ? true : false);
		}
		if (flag)
		{
			i++;
		}
		for (; i < text.Length && (char.IsAsciiDigit(text[i]) || text[i] == '.' || text[i] == 'e' || text[i] == 'E' || text[i] == '+' || text[i] == '-'); i++)
		{
		}
		unchecked
		{
			if (endptr != null)
			{
				*endptr = (byte*)checked(unchecked((nuint)str) + unchecked((nuint)i));
			}
			int num2 = num;
			double result;
			return double.TryParse(text.Substring(num2, i - num2), NumberStyles.Float, CultureInfo.InvariantCulture, out result) ? result : 0.0;
		}
	}

	[MangledName("strtof")]
	public unsafe static float strtof(byte* str, byte** endptr)
	{
		return (float)strtod(str, endptr);
	}

	[MangledName("strtold")]
	public unsafe static double strtold(byte* str, byte** endptr)
	{
		return strtod(str, endptr);
	}

	[MangledName("sqrt")]
	public static double Sqrt(double d)
	{
		return double.Sqrt(d);
	}

	[MangledName("sqrtf")]
	public static float Sqrtf(float f)
	{
		return float.Sqrt(f);
	}

	[MangledName("fabs")]
	public static double Fabs(double x)
	{
		return Math.Abs(x);
	}

	[MangledName("fabsf")]
	public static float Fabsf(float x)
	{
		return Math.Abs(x);
	}

	[MangledName("abs")]
	[MangledName("labs")]
	[MangledName("llabs")]
	public static long AbsL(long x)
	{
		return Math.Abs(x);
	}

	[MangledName("ceil")]
	public static double Ceil(double x)
	{
		return Math.Ceiling(x);
	}

	[MangledName("ceilf")]
	public static float Ceilf(float x)
	{
		return MathF.Ceiling(x);
	}

	[MangledName("floor")]
	public static double Floor(double x)
	{
		return Math.Floor(x);
	}

	[MangledName("floorf")]
	public static float Floorf(float x)
	{
		return MathF.Floor(x);
	}

	[MangledName("round")]
	public static double Round(double x)
	{
		return Math.Round(x, MidpointRounding.AwayFromZero);
	}

	[MangledName("roundf")]
	public static float Roundf(float x)
	{
		return MathF.Round(x, MidpointRounding.AwayFromZero);
	}

	[MangledName("trunc")]
	public static double Trunc(double x)
	{
		return Math.Truncate(x);
	}

	[MangledName("truncf")]
	public static float Truncf(float x)
	{
		return MathF.Truncate(x);
	}

	[MangledName("fmod")]
	public static double Fmod(double x, double y)
	{
		return x % y;
	}

	[MangledName("fmodf")]
	public static float Fmodf(float x, float y)
	{
		return x % y;
	}

	[MangledName("pow")]
	public static double Pow(double x, double y)
	{
		return Math.Pow(x, y);
	}

	[MangledName("powf")]
	public static float Powf(float x, float y)
	{
		return MathF.Pow(x, y);
	}

	[MangledName("exp")]
	public static double Exp(double x)
	{
		return Math.Exp(x);
	}

	[MangledName("expf")]
	public static float Expf(float x)
	{
		return MathF.Exp(x);
	}

	[MangledName("exp2")]
	public static double Exp2(double x)
	{
		return Math.Pow(2.0, x);
	}

	[MangledName("exp2f")]
	public static float Exp2f(float x)
	{
		return MathF.Pow(2f, x);
	}

	[MangledName("log")]
	public static double Log(double x)
	{
		return Math.Log(x);
	}

	[MangledName("logf")]
	public static float Logf(float x)
	{
		return MathF.Log(x);
	}

	[MangledName("log2")]
	public static double Log2(double x)
	{
		return Math.Log2(x);
	}

	[MangledName("log2f")]
	public static float Log2f(float x)
	{
		return MathF.Log2(x);
	}

	[MangledName("log10")]
	public static double Log10(double x)
	{
		return Math.Log10(x);
	}

	[MangledName("log10f")]
	public static float Log10f(float x)
	{
		return MathF.Log10(x);
	}

	[MangledName("sin")]
	public static double Sin(double x)
	{
		return Math.Sin(x);
	}

	[MangledName("sinf")]
	public static float Sinf(float x)
	{
		return MathF.Sin(x);
	}

	[MangledName("cos")]
	public static double Cos(double x)
	{
		return Math.Cos(x);
	}

	[MangledName("cosf")]
	public static float Cosf(float x)
	{
		return MathF.Cos(x);
	}

	[MangledName("tan")]
	public static double Tan(double x)
	{
		return Math.Tan(x);
	}

	[MangledName("tanf")]
	public static float Tanf(float x)
	{
		return MathF.Tan(x);
	}

	[MangledName("asin")]
	public static double Asin(double x)
	{
		return Math.Asin(x);
	}

	[MangledName("asinf")]
	public static float Asinf(float x)
	{
		return MathF.Asin(x);
	}

	[MangledName("acos")]
	public static double Acos(double x)
	{
		return Math.Acos(x);
	}

	[MangledName("acosf")]
	public static float Acosf(float x)
	{
		return MathF.Acos(x);
	}

	[MangledName("atan")]
	public static double Atan(double x)
	{
		return Math.Atan(x);
	}

	[MangledName("atanf")]
	public static float Atanf(float x)
	{
		return MathF.Atan(x);
	}

	[MangledName("atan2")]
	public static double Atan2(double y, double x)
	{
		return Math.Atan2(y, x);
	}

	[MangledName("atan2f")]
	public static float Atan2f(float y, float x)
	{
		return MathF.Atan2(y, x);
	}

	[MangledName("hypot")]
	public static double Hypot(double x, double y)
	{
		return Math.Sqrt(x * x + y * y);
	}

	[MangledName("hypotf")]
	public static float Hypotf(float x, float y)
	{
		return MathF.Sqrt(x * x + y * y);
	}

	[MangledName("cbrt")]
	public static double Cbrt(double x)
	{
		return Math.Cbrt(x);
	}

	[MangledName("cbrtf")]
	public static float Cbrtf(float x)
	{
		return MathF.Cbrt(x);
	}

	[MangledName("fmin")]
	public static double Fmin(double x, double y)
	{
		return Math.Min(x, y);
	}

	[MangledName("fminf")]
	public static float Fminf(float x, float y)
	{
		return Math.Min(x, y);
	}

	[MangledName("fmax")]
	public static double Fmax(double x, double y)
	{
		return Math.Max(x, y);
	}

	[MangledName("fmaxf")]
	public static float Fmaxf(float x, float y)
	{
		return Math.Max(x, y);
	}

	[MangledName("sinh")]
	public static double Sinh(double x)
	{
		return Math.Sinh(x);
	}

	[MangledName("cosh")]
	public static double Cosh(double x)
	{
		return Math.Cosh(x);
	}

	[MangledName("tanh")]
	public static double Tanh(double x)
	{
		return Math.Tanh(x);
	}

	[MangledName("sinhf")]
	public static float Sinhf(float x)
	{
		return MathF.Sinh(x);
	}

	[MangledName("coshf")]
	public static float Coshf(float x)
	{
		return MathF.Cosh(x);
	}

	[MangledName("tanhf")]
	public static float Tanhf(float x)
	{
		return MathF.Tanh(x);
	}

	[MangledName("ldexp")]
	public static double Ldexp(double x, int exp)
	{
		return x * Math.Pow(2.0, exp);
	}

	[MangledName("ldexpf")]
	public static float Ldexpf(float x, int exp)
	{
		return x * MathF.Pow(2f, exp);
	}

	[MangledName("frexp")]
	public unsafe static double Frexp(double x, int* exp)
	{
		if (x == 0.0)
		{
			if (exp != null)
			{
				*exp = 0;
			}
			return 0.0;
		}
		long num = BitConverter.DoubleToInt64Bits(x);
		int num2 = (int)((num >> 52) & 0x7FF) - 1022;
		double result = BitConverter.Int64BitsToDouble((num & -9218868437227405313L) | 0x3FE0000000000000L);
		if (exp != null)
		{
			*exp = num2;
		}
		return result;
	}

	[MangledName("modf")]
	public unsafe static double Modf(double x, double* intpart)
	{
		double num = Math.Truncate(x);
		if (intpart != null)
		{
			*intpart = num;
		}
		return x - num;
	}

	[MangledName("rand")]
	public static int Rand()
	{
		return _random.Next(0, 32768);
	}

	[MangledName("srand")]
	public static void Srand(uint s)
	{
		_randomField = new Random((int)s);
	}

	[MangledName("clock")]
	public static long Clock()
	{
		return (Environment.TickCount64 - StartTicks) * 1000;
	}

	[MangledName("memcmp")]
	public unsafe static int memcmp(byte* p1, byte* p2, long count)
	{
		for (long num = 0L; num < count; num++)
		{
			if (p1[num] != p2[num])
			{
				return p1[num] - p2[num];
			}
		}
		return 0;
	}

	[MangledName("memcpy")]
	public unsafe static void* memcpy(void* dst, void* src, long n)
	{
		Unsafe.CopyBlock(dst, src, (uint)n);
		return dst;
	}

	[MangledName("memmove")]
	public unsafe static void* memmove(void* dst, void* src, long n)
	{
		byte[] array = ArrayPool<byte>.Shared.Rent((int)n);
		new ReadOnlySpan<byte>(src, (int)n).CopyTo(new Span<byte>(array, 0, (int)n));
		new Span<byte>(array, 0, (int)n).CopyTo(new Span<byte>(dst, (int)n));
		ArrayPool<byte>.Shared.Return(array);
		return dst;
	}

	[MangledName("memset")]
	public unsafe static void* memset(void* dst, int val, long n)
	{
		new Span<byte>(dst, (int)n).Fill(unchecked((byte)val));
		return dst;
	}

	[MangledName("llvm.memcpy.p0.p0.i32")]
	public unsafe static void llvm_memcpy_p0_p0_i32(void* destination, void* source, int length, bool isVolatile)
	{
		Unsafe.CopyBlock(destination, source, (uint)length);
	}

	[MangledName("llvm.memcpy.p0.p0.i64")]
	public unsafe static void llvm_memcpy_p0_p0_i64(void* destination, void* source, long length, bool isVolatile)
	{
		Unsafe.CopyBlock(destination, source, (uint)length);
	}

	[MangledName("llvm.memmove.p0.p0.i32")]
	public unsafe static void llvm_memmove_p0_p0_i32(void* destination, void* source, int length, bool isVolatile)
	{
		byte[] array = ArrayPool<byte>.Shared.Rent(length);
		Span<byte> destination2 = new Span<byte>(array, 0, length);
		new ReadOnlySpan<byte>(source, length).CopyTo(destination2);
		destination2.CopyTo(new Span<byte>(destination, length));
		ArrayPool<byte>.Shared.Return(array);
	}

	[MangledName("llvm.memmove.p0.p0.i64")]
	public unsafe static void llvm_memmove_p0_p0_i64(void* destination, void* source, long length, bool isVolatile)
	{
		llvm_memmove_p0_p0_i32(destination, source, (int)length, isVolatile);
	}

	[MangledName("llvm.memset.p0.i32")]
	public unsafe static void llvm_memset_p0_i32(void* destination, sbyte value, int length, bool isVolatile)
	{
		new Span<byte>(destination, length).Fill(unchecked((byte)value));
	}

	[MangledName("llvm.memset.p0.i64")]
	public unsafe static void llvm_memset_p0_i64(void* destination, sbyte value, long length, bool isVolatile)
	{
		llvm_memset_p0_i32(destination, value, (int)length, isVolatile);
	}

	[MangledName("calloc")]
	public unsafe static void* CAlloc(long elementCount, long elementSize)
	{
		if (elementCount <= 0 || elementSize <= 0)
		{
			return null;
		}
		if (elementCount > int.MaxValue || elementSize > int.MaxValue)
		{
			return null;
		}
		long num = elementCount * elementSize;
		if (num > int.MaxValue)
		{
			return null;
		}
		void* ptr = Alloc(num);
		new Span<byte>(ptr, (int)num).Clear();
		return ptr;
	}

	[MangledName("malloc")]
	public unsafe static void* Alloc(long size)
	{
		return NativeMemoryHelper.Allocate(size);
	}

	[MangledName("realloc")]
	public unsafe static void* ReAlloc(void* ptr, long size)
	{
		return NativeMemoryHelper.Reallocate(ptr, size);
	}

	[MangledName("free")]
	public unsafe static void Free(void* ptr)
	{
		NativeMemoryHelper.Free(ptr);
	}

	[MangledName("printf")]
	public unsafe static int printf(byte* format, ReadOnlySpan<nint> args)
	{
		string text = FormatPrintf(format, args);
		if (text == null)
		{
			return -1;
		}
		Console.Write(text);
		return text.Length;
	}

	[MangledName("fprintf")]
	public unsafe static int fprintf(void* stream, byte* format, ReadOnlySpan<nint> args)
	{
		string text = FormatPrintf(format, args);
		if (text == null)
		{
			return -1;
		}
		if (stream == StandardOutput)
		{
			Console.Write(text);
		}
		else
		{
			if (stream != StandardError)
			{
				return -1;
			}
			Console.Error.Write(text);
		}
		return text.Length;
	}

	[MangledName("sprintf")]
	public unsafe static int sprintf(byte* buffer, byte* format, ReadOnlySpan<nint> args)
	{
		string text = FormatPrintf(format, args);
		if (text == null || buffer == null)
		{
			return -1;
		}
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		new Span<byte>(bytes).CopyTo(new Span<byte>(buffer, bytes.Length));
		buffer[bytes.Length] = 0;
		return bytes.Length;
	}

	[MangledName("snprintf")]
	public unsafe static int snprintf(byte* buffer, long size, byte* format, ReadOnlySpan<nint> args)
	{
		string text = FormatPrintf(format, args);
		if (text == null)
		{
			return -1;
		}
		if (buffer == null || size <= 0)
		{
			return text.Length;
		}
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		long num = Math.Min(bytes.Length, size - 1);
		bytes.AsSpan(0, (int)num).CopyTo(new Span<byte>(buffer, (int)size));
		buffer[num] = 0;
		return bytes.Length;
	}

	[MangledName("vprintf")]
	public unsafe static int vprintf(byte* format, void* ap)
	{
		string text = FormatPrintf(format, new ReadOnlySpan<nint>(ap, 64));
		if (text == null)
		{
			return -1;
		}
		Console.Write(text);
		return text.Length;
	}

	[MangledName("vfprintf")]
	public unsafe static int vfprintf(void* stream, byte* format, void* ap)
	{
		string text = FormatPrintf(format, new ReadOnlySpan<nint>(ap, 64));
		if (text == null)
		{
			return -1;
		}
		if (stream == StandardOutput)
		{
			Console.Write(text);
		}
		else
		{
			if (stream != StandardError)
			{
				return -1;
			}
			Console.Error.Write(text);
		}
		return text.Length;
	}

	[MangledName("vsprintf")]
	public unsafe static int vsprintf(byte* buffer, byte* format, void* ap)
	{
		string text = FormatPrintf(format, new ReadOnlySpan<nint>(ap, 64));
		if (text == null || buffer == null)
		{
			return -1;
		}
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		new Span<byte>(bytes).CopyTo(new Span<byte>(buffer, bytes.Length));
		buffer[bytes.Length] = 0;
		return bytes.Length;
	}

	[MangledName("vsnprintf")]
	public unsafe static int vsnprintf(byte* buffer, long size, byte* format, void* ap)
	{
		string text = FormatPrintf(format, new ReadOnlySpan<nint>(ap, 64));
		if (text == null)
		{
			return -1;
		}
		if (buffer == null || size <= 0)
		{
			return text.Length;
		}
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		long num = Math.Min(bytes.Length, size - 1);
		bytes.AsSpan(0, (int)num).CopyTo(new Span<byte>(buffer, (int)size));
		buffer[num] = 0;
		return bytes.Length;
	}

	[DoesNotReturn]
	[MangledName("abort")]
	public static void Abort()
	{
		throw new FatalException("Abort");
	}

	[DoesNotReturn]
	[MangledName("_exit")]
	[MangledName("_Exit")]
	[MangledName("quick_exit")]
	public static void ExitNoCleanup(int exitCode)
	{
		Environment.Exit(exitCode);
	}

	[MangledName("__assert_fail")]
	[MightThrow]
	public unsafe static void AssertFail(byte* assertion, byte* file, uint line, byte* function)
	{
		ExceptionInfo.Current = new AssertExceptionInfo($"Assertion `{Marshal.PtrToStringUTF8((nint)assertion)}' failed: {Marshal.PtrToStringUTF8((nint)file)}:{line}: {Marshal.PtrToStringUTF8((nint)function)}");
	}

	[MangledName("__assert_perror_fail")]
	[MightThrow]
	public unsafe static void AssertPerrorFail(int errnum, byte* file, uint line, byte* function)
	{
		ExceptionInfo.Current = new AssertExceptionInfo($"Assertion failed (errno={errnum}): {Marshal.PtrToStringUTF8((nint)file)}:{line}: {Marshal.PtrToStringUTF8((nint)function)}");
	}

	[MangledName("__errno_location")]
	public unsafe static int* ErrnoLocation()
	{
		if (_errnoPtr == null)
		{
			_errnoPtr = unchecked((int*)NativeMemoryHelper.Allocate(4));
		}
		return _errnoPtr;
	}

	[MangledName("strerror")]
	public unsafe static byte* Strerror(int errnum)
	{
		string obj = ((errnum == 0) ? "Success" : $"Error {errnum}");
		byte[] bytes = Encoding.UTF8.GetBytes(obj + "\0");
		if (_strerrorBuf == null)
		{
			_strerrorBuf = unchecked((byte*)NativeMemoryHelper.Allocate(256));
		}
		int num = Math.Min(bytes.Length, 255);
		new Span<byte>(bytes, 0, num).CopyTo(new Span<byte>(_strerrorBuf, 256));
		_strerrorBuf[num] = 0;
		return _strerrorBuf;
	}

	[MangledName("strerror_r")]
	public unsafe static int StrerrorR(int errnum, byte* buf, long buflen)
	{
		if (buf == null || buflen <= 0)
		{
			return -1;
		}
		string obj = ((errnum == 0) ? "Success" : $"Error {errnum}");
		byte[] bytes = Encoding.UTF8.GetBytes(obj + "\0");
		int num = (int)Math.Min(bytes.Length, buflen - 1);
		new Span<byte>(bytes, 0, num).CopyTo(new Span<byte>(buf, (int)buflen));
		buf[num] = 0;
		return 0;
	}

	[MangledName("getenv")]
	public unsafe static byte* Getenv(byte* name)
	{
		if (name == null)
		{
			return null;
		}
		string text = Marshal.PtrToStringUTF8((nint)name);
		if (text == null)
		{
			return null;
		}
		string environmentVariable = Environment.GetEnvironmentVariable(text);
		if (environmentVariable == null)
		{
			return null;
		}
		unchecked
		{
			return (byte*)checked((nuint)_envCache.GetOrAdd(environmentVariable, delegate(string v)
			{
				byte[] bytes = Encoding.UTF8.GetBytes(v + "\0");
				byte* ptr = unchecked((byte*)NativeMemoryHelper.Allocate(bytes.Length));
				new Span<byte>(bytes).CopyTo(new Span<byte>(ptr, bytes.Length));
				return (nint)ptr;
			}));
		}
	}

	[DoesNotReturn]
	[MangledName("__stack_chk_fail")]
	public static void StackChkFail()
	{
		throw new FatalException("Stack smashing detected (__stack_chk_fail)");
	}

	[MangledName("malloc_usable_size")]
	public unsafe static long MallocUsableSize(void* ptr)
	{
		return (ptr == null) ? 0 : NativeMemoryHelper.Size(ptr);
	}

	[MangledName("posix_memalign")]
	public unsafe static int PosixMemalign(void** memptr, long alignment, long size)
	{
		if (memptr == null)
		{
			return 22;
		}
		*memptr = NativeMemoryHelper.Allocate(size);
		return 0;
	}

	[MangledName("_Znwm")]
	[MangledName("_ZnwmRKSt9nothrow_t")]
	public unsafe static void* CxxNew(long size)
	{
		return NativeMemoryHelper.Allocate(size);
	}

	[MangledName("_Znam")]
	[MangledName("_ZnamRKSt9nothrow_t")]
	public unsafe static void* CxxNewArray(long size)
	{
		return NativeMemoryHelper.Allocate(size);
	}

	[MangledName("_ZnwmSt11align_val_t")]
	public unsafe static void* CxxNewAligned(long size, long alignment)
	{
		return NativeMemoryHelper.Allocate(size);
	}

	[MangledName("_ZnamSt11align_val_t")]
	public unsafe static void* CxxNewArrayAligned(long size, long alignment)
	{
		return NativeMemoryHelper.Allocate(size);
	}

	[MangledName("_ZdlPv")]
	[MangledName("_ZdlPvRKSt9nothrow_t")]
	public unsafe static void CxxDelete(void* ptr)
	{
		NativeMemoryHelper.Free(ptr);
	}

	[MangledName("_ZdaPv")]
	[MangledName("_ZdaPvRKSt9nothrow_t")]
	public unsafe static void CxxDeleteArray(void* ptr)
	{
		NativeMemoryHelper.Free(ptr);
	}

	[MangledName("_ZdlPvm")]
	[MangledName("_ZdlPvSt11align_val_t")]
	public unsafe static void CxxDeleteSized(void* ptr, long sizeOrAlignment)
	{
		NativeMemoryHelper.Free(ptr);
	}

	[MangledName("_ZdaPvm")]
	[MangledName("_ZdaPvSt11align_val_t")]
	public unsafe static void CxxDeleteArraySized(void* ptr, long sizeOrAlignment)
	{
		NativeMemoryHelper.Free(ptr);
	}

	[MangledName("__cxa_allocate_exception")]
	public unsafe static void* CxaAllocateException(long thrownSize)
	{
		return NativeMemoryHelper.Allocate(thrownSize);
	}

	[MangledName("__cxa_free_exception")]
	public unsafe static void CxaFreeException(void* thrownException)
	{
		NativeMemoryHelper.Free(thrownException);
	}

	[MangledName("__cxa_throw")]
	[MightThrow]
	public unsafe static void CxaThrow(void* thrownException, void* typeInfo, delegate*<void*, void> destructor)
	{
		ExceptionInfo.Current = new ItaniumExceptionInfo(thrownException, typeInfo, destructor);
	}

	[MangledName("__cxa_rethrow")]
	[MightThrow]
	public static void CxaRethrow()
	{
	}

	[MangledName("__cxa_begin_catch")]
	public unsafe static void* CxaBeginCatch(void* exceptionObject)
	{
		if (!(ExceptionInfo.Current is ItaniumExceptionInfo { ExceptionPointer: var exceptionPointer }))
		{
			return exceptionObject;
		}
		return exceptionPointer;
	}

	[MangledName("__cxa_end_catch")]
	public static void CxaEndCatch()
	{
	}

	[MangledName("__cxa_pure_virtual")]
	[DoesNotReturn]
	public static void CxaPureVirtual()
	{
		throw new FatalException("Pure virtual function called");
	}

	[MangledName("__cxa_bad_cast")]
	[DoesNotReturn]
	public static void CxaBadCast()
	{
		throw new FatalException("Bad dynamic_cast");
	}

	[MangledName("__cxa_bad_typeid")]
	[DoesNotReturn]
	public static void CxaBadTypeid()
	{
		throw new FatalException("Null pointer in typeid");
	}

	[MangledName("__gxx_personality_v0")]
	public static int GxxPersonalityV0(ReadOnlySpan<nint> args)
	{
		return 0;
	}

	[MangledName("__cxa_guard_acquire")]
	public unsafe static int CxaGuardAcquire(long* guardObject)
	{
		if (*unchecked((bool*)guardObject))
		{
			return 0;
		}
		return (Interlocked.CompareExchange(ref *guardObject, 256L, 0L) == 0L) ? 1 : 0;
	}

	[MangledName("__cxa_guard_release")]
	public unsafe static void CxaGuardRelease(long* guardObject)
	{
		*unchecked((sbyte*)guardObject) = 1;
		Thread.MemoryBarrier();
	}

	[MangledName("__cxa_guard_abort")]
	public unsafe static void CxaGuardAbort(long* guardObject)
	{
		Interlocked.Exchange(ref *guardObject, 0L);
	}

	[MangledName("__cxa_atexit")]
	public unsafe static int CxaAtexit(delegate*<void*, void> func, void* arg, void* dsoHandle)
	{
		unchecked
		{
			if (_cxaAtexitFuncs.IsEmpty)
			{
				lock (_cxaAtexitFuncs)
				{
					if (_cxaAtexitFuncs.IsEmpty)
					{
						AppDomain.CurrentDomain.ProcessExit += delegate
						{
							nint result;
							nint result2;
							while (_cxaAtexitFuncs.TryPop(out result) && _cxaAtexitArgs.TryPop(out result2))
							{
								((delegate*<void*, void>)checked((nuint)result))((void*)checked((nuint)result2));
							}
						};
					}
				}
			}
		}
		_cxaAtexitFuncs.Push((nint)func);
		_cxaAtexitArgs.Push((nint)arg);
		return 0;
	}

	[MangledName("__cxa_finalize")]
	public unsafe static void CxaFinalize(void* dsoHandle)
	{
		unchecked
		{
			nint result;
			nint result2;
			while (_cxaAtexitFuncs.TryPop(out result) && _cxaAtexitArgs.TryPop(out result2))
			{
				((delegate*<void*, void>)checked((nuint)result))((void*)checked((nuint)result2));
			}
		}
	}

	[MangledName("__libc_start_main")]
	public unsafe static int LibcStartMain(delegate*<int, byte**, byte**, int> main, int argc, byte** argv, delegate*<void> init, delegate*<void> fini, delegate*<void> rtldFini, void* stackEnd)
	{
		return main(argc, argv, null);
	}

	[MangledName("wcscmp")]
	public unsafe static int wcscmp(char* s1, char* s2)
	{
		unchecked
		{
			while (*s1 == *s2 && *s1 != 0)
			{
				s1 = (char*)checked(unchecked((nuint)s1) + (nuint)2u);
				s2 = (char*)checked(unchecked((nuint)s2) + (nuint)2u);
			}
		}
		return *s1 - *s2;
	}

	[MangledName("wcsncmp")]
	public unsafe static int wcsncmp(char* s1, char* s2, long count)
	{
		for (long num = 0L; num < count; num++)
		{
			if (unchecked(*(ushort*)((byte*)s1 + checked(num * 2)) != *(ushort*)((byte*)s2 + checked(num * 2))))
			{
				return *unchecked((ushort*)((byte*)s1 + checked(num * 2))) - *unchecked((ushort*)((byte*)s2 + checked(num * 2)));
			}
			unchecked
			{
				if (*(ushort*)((byte*)s1 + checked(num * 2)) == 0)
				{
					return 0;
				}
			}
		}
		return 0;
	}

	[MangledName("wcscpy")]
	public unsafe static char* wcscpy(char* dst, char* src)
	{
		if (dst == null || src == null)
		{
			return dst;
		}
		long num = wcslen(src);
		Buffer.MemoryCopy(src, dst, (num + 1) * 2, (num + 1) * 2);
		return dst;
	}

	[MangledName("wcsncpy")]
	public unsafe static char* wcsncpy(char* dst, char* src, long count)
	{
		if (dst == null || src == null)
		{
			return dst;
		}
		unchecked
		{
			long num;
			for (num = 0L; num < count && *(ushort*)((byte*)src + checked(num * 2)) != 0; num = checked(num + 1))
			{
				*(short*)((byte*)dst + checked(num * 2)) = *(short*)((byte*)src + checked(num * 2));
			}
			for (; num < count; num = checked(num + 1))
			{
				*(short*)((byte*)dst + checked(num * 2)) = 0;
			}
			return dst;
		}
	}

	[MangledName("wcscat")]
	public unsafe static char* wcscat(char* dst, char* src)
	{
		if (dst == null || src == null)
		{
			return dst;
		}
		long num = wcslen(dst);
		long num2 = wcslen(src);
		Buffer.MemoryCopy(src, unchecked((void*)checked(unchecked((nuint)dst) + unchecked((nuint)checked(num * 2)))), (num2 + 1) * 2, (num2 + 1) * 2);
		return dst;
	}

	[MangledName("wcsncat")]
	public unsafe static char* wcsncat(char* dst, char* src, long count)
	{
		if (dst == null || src == null)
		{
			return dst;
		}
		long num = wcslen(dst);
		unchecked
		{
			long num2;
			for (num2 = 0L; num2 < count && *(ushort*)((byte*)src + checked(num2 * 2)) != 0; num2 = checked(num2 + 1))
			{
				*(short*)((byte*)dst + checked((num + num2) * 2)) = *(short*)((byte*)src + checked(num2 * 2));
			}
			*(short*)((byte*)dst + checked((num + num2) * 2)) = 0;
			return dst;
		}
	}

	[MangledName("wcschr")]
	public unsafe static char* wcschr(char* str, int c)
	{
		if (str == null)
		{
			return null;
		}
		unchecked
		{
			char c2 = (char)checked((ushort)c);
			while (*str != 0)
			{
				if (*str == c2)
				{
					return str;
				}
				str = (char*)checked(unchecked((nuint)str) + (nuint)2u);
			}
			return (c2 == '\0') ? str : null;
		}
	}

	[MangledName("wcsrchr")]
	public unsafe static char* wcsrchr(char* str, int c)
	{
		if (str == null)
		{
			return null;
		}
		long num = wcslen(str);
		char c2;
		unchecked
		{
			c2 = (char)checked((ushort)c);
		}
		for (long num2 = num - 1; num2 >= 0; num2--)
		{
			unchecked
			{
				if (*(ushort*)((byte*)str + checked(num2 * 2)) == c2)
				{
					return (char*)checked(unchecked((nuint)str) + unchecked((nuint)checked(num2 * 2)));
				}
			}
		}
		return null;
	}

	[MangledName("wcsstr")]
	public unsafe static char* wcsstr(char* haystack, char* needle)
	{
		if (haystack == null || needle == null)
		{
			return null;
		}
		long num = wcslen(haystack);
		int num2 = MemoryExtensions.IndexOf(value: new ReadOnlySpan<char>(needle, (int)wcslen(needle)), span: new ReadOnlySpan<char>(haystack, (int)num));
		unchecked
		{
			return (char*)((num2 >= 0) ? checked(unchecked((nuint)haystack) + unchecked((nuint)checked(unchecked((nint)num2) * (nint)2))) : 0u);
		}
	}

	[MangledName("wmemcpy")]
	public unsafe static char* wmemcpy(char* dst, char* src, long count)
	{
		Buffer.MemoryCopy(src, dst, count * 2, count * 2);
		return dst;
	}

	[MangledName("wmemmove")]
	public unsafe static char* wmemmove(char* dst, char* src, long count)
	{
		long num = count * 2;
		byte[] array = new byte[num];
		new ReadOnlySpan<byte>(src, (int)num).CopyTo(array);
		new Span<byte>(array).CopyTo(new Span<byte>(dst, (int)num));
		return dst;
	}

	[MangledName("wmemset")]
	public unsafe static char* wmemset(char* dst, int c, long count)
	{
		unchecked
		{
			char c2 = (char)checked((ushort)c);
			for (long num = 0L; num < count; num = checked(num + 1))
			{
				*(char*)((byte*)dst + checked(num * 2)) = c2;
			}
			return dst;
		}
	}

	[MangledName("wmemcmp")]
	public unsafe static int wmemcmp(char* s1, char* s2, long count)
	{
		for (long num = 0L; num < count; num++)
		{
			if (unchecked(*(ushort*)((byte*)s1 + checked(num * 2)) != *(ushort*)((byte*)s2 + checked(num * 2))))
			{
				return *unchecked((ushort*)((byte*)s1 + checked(num * 2))) - *unchecked((ushort*)((byte*)s2 + checked(num * 2)));
			}
		}
		return 0;
	}

	[MangledName("wmemchr")]
	public unsafe static char* wmemchr(char* s, int c, long count)
	{
		unchecked
		{
			char c2 = (char)checked((ushort)c);
			for (long num = 0L; num < count; num = checked(num + 1))
			{
				if (*(ushort*)((byte*)s + checked(num * 2)) == c2)
				{
					return (char*)checked(unchecked((nuint)s) + unchecked((nuint)checked(num * 2)));
				}
			}
			return null;
		}
	}

	[MangledName("towlower")]
	public static int Towlower(int c)
	{
		unchecked
		{
			return char.ToLowerInvariant((char)checked((ushort)c));
		}
	}

	[MangledName("towupper")]
	public static int Towupper(int c)
	{
		unchecked
		{
			return char.ToUpperInvariant((char)checked((ushort)c));
		}
	}

	[MangledName("iswspace")]
	public static int Iswspace(int c)
	{
		return IsWClass(c, char.IsWhiteSpace);
	}

	[MangledName("iswalpha")]
	public static int Iswalpha(int c)
	{
		return IsWClass(c, char.IsLetter);
	}

	[MangledName("iswdigit")]
	public static int Iswdigit(int c)
	{
		return IsWClass(c, char.IsAsciiDigit);
	}

	[MangledName("iswalnum")]
	public static int Iswalnum(int c)
	{
		return IsWClass(c, char.IsLetterOrDigit);
	}

	[MangledName("iswupper")]
	public static int Iswupper(int c)
	{
		return IsWClass(c, char.IsUpper);
	}

	[MangledName("iswlower")]
	public static int Iswlower(int c)
	{
		return IsWClass(c, char.IsLower);
	}

	[MangledName("iswprint")]
	public static int Iswprint(int c)
	{
		return IsWClass(c, (char ch) => !char.IsControl(ch));
	}

	[MangledName("iswpunct")]
	public static int Iswpunct(int c)
	{
		return IsWClass(c, char.IsPunctuation);
	}

	[MangledName("iswcntrl")]
	public static int Iswcntrl(int c)
	{
		return IsWClass(c, char.IsControl);
	}

	[MangledName("iswblank")]
	public static int Iswblank(int c)
	{
		return (c == 32 || c == 9) ? 1 : 0;
	}

	[MangledName("iswxdigit")]
	public static int Iswxdigit(int c)
	{
		return IsWClass(c, char.IsAsciiHexDigit);
	}

	[MangledName("iswgraph")]
	public static int Iswgraph(int c)
	{
		return IsWClass(c, (char ch) => !char.IsControl(ch) && ch != ' ');
	}

	private static int IsWClass(int c, Func<char, bool> pred)
	{
		return unchecked((uint)c <= 65535u && pred((char)c)) ? 1 : 0;
	}

	[MangledName("setlocale")]
	public unsafe static byte* Setlocale(int category, byte* locale)
	{
		if (_cLocale == null)
		{
			_cLocale = unchecked((byte*)NativeMemoryHelper.Allocate(2));
			*_cLocale = 67;
			_cLocale[1] = 0;
		}
		return _cLocale;
	}

	[MangledName("__dotnet_syscall")]
	public unsafe static long DotnetSyscall(long n, long a1, long a2, long a3, long a4, long a5, long a6)
	{
		if (1 == 0)
		{
		}
		long result;
		unchecked
		{
			if (n <= 247)
			{
				if (n <= 186)
				{
					if (n <= 157)
					{
						if ((ulong)n <= 110uL)
						{
							switch ((int)n)
							{
							case 0:
								goto IL_039d;
							case 1:
								goto IL_03ad;
							case 2:
								goto IL_03bd;
							case 3:
								goto IL_03ce;
							case 8:
								goto IL_03db;
							case 19:
								goto IL_03eb;
							case 20:
								goto IL_03fc;
							case 17:
								goto IL_040d;
							case 18:
								goto IL_041f;
							case 40:
								goto IL_0431;
							case 72:
								goto IL_045a;
							case 16:
								goto IL_0469;
							case 32:
								goto IL_048a;
							case 33:
								goto IL_0497;
							case 22:
								goto IL_04b5;
							case 4:
								goto IL_04d2;
							case 5:
								goto IL_04e1;
							case 6:
								goto IL_04f0;
							case 9:
								goto IL_052a;
							case 10:
								goto IL_0543;
							case 11:
								goto IL_054b;
							case 12:
								goto IL_0558;
							case 28:
								goto IL_0560;
							case 21:
								goto IL_0568;
							case 83:
								goto IL_059c;
							case 84:
								goto IL_05ab;
							case 87:
								goto IL_05b8;
							case 82:
								goto IL_05d6;
							case 79:
								goto IL_05f5;
							case 80:
								goto IL_0604;
							case 89:
								goto IL_0611;
							case 77:
								goto IL_0647;
							case 74:
								goto IL_0655;
							case 75:
								goto IL_0662;
							case 91:
								goto IL_066f;
							case 35:
								goto IL_0677;
							case 96:
								goto IL_0686;
							case 39:
								goto IL_06c5;
							case 110:
								goto IL_06d1;
							case 102:
								goto IL_06dd;
							case 104:
								goto IL_06e9;
							case 24:
								goto IL_0701;
							case 56:
								goto IL_070c;
							case 60:
								goto IL_0722;
							case 62:
								goto IL_073c;
							case 61:
								goto IL_074c;
							case 13:
								goto IL_0788;
							case 14:
								goto IL_078d;
							case 23:
								goto IL_0797;
							case 7:
								goto IL_079c;
							case 63:
								goto IL_07bd;
							case 41:
							case 42:
							case 43:
							case 44:
							case 45:
							case 46:
							case 47:
							case 48:
							case 49:
							case 50:
							case 51:
							case 52:
							case 54:
							case 55:
								goto IL_07d8;
							case 15:
							case 25:
							case 26:
							case 27:
							case 29:
							case 30:
							case 31:
							case 34:
							case 36:
							case 37:
							case 38:
							case 53:
							case 57:
							case 58:
							case 59:
							case 64:
							case 65:
							case 66:
							case 67:
							case 68:
							case 69:
							case 70:
							case 71:
							case 73:
							case 76:
							case 78:
							case 81:
							case 85:
							case 86:
							case 88:
							case 90:
							case 92:
							case 93:
							case 94:
							case 95:
							case 97:
							case 98:
							case 99:
							case 100:
							case 101:
							case 103:
							case 105:
							case 106:
							case 107:
							case 108:
							case 109:
								goto IL_07de;
							}
						}
						if (n != 157)
						{
							goto IL_07de;
						}
						result = 0L;
					}
					else if (n != 158)
					{
						if (n != 186)
						{
							goto IL_07de;
						}
						result = Environment.CurrentManagedThreadId;
					}
					else
					{
						result = SysArchPrctl((ArchPrctlCode)a1, a2);
					}
				}
				else if (n <= 217)
				{
					if (n != 202)
					{
						if (n != 217)
						{
							goto IL_07de;
						}
						result = SysGetdents64(checked((int)a1), (byte*)checked((nuint)a2), checked((int)a3));
					}
					else
					{
						result = SysFutex((int*)checked((nuint)a1), (FutexOperation)checked((int)a2), checked((int)a3), (TimespecStruct*)checked((nuint)a4), (int*)checked((nuint)a5), checked((int)a6));
					}
				}
				else if (n != 218)
				{
					long num = n - 228;
					if ((ulong)num <= 6uL)
					{
						switch ((int)num)
						{
						case 0:
							goto IL_0693;
						case 1:
							goto IL_06a2;
						case 2:
							goto IL_06b1;
						case 3:
							goto IL_072f;
						case 6:
							goto IL_0744;
						case 4:
						case 5:
							goto IL_07de;
						}
					}
					if (n != 247)
					{
						goto IL_07de;
					}
					result = -10L;
				}
				else
				{
					result = SysSetTidAddress((int*)checked((nuint)a1));
				}
			}
			else if (n <= 293)
			{
				if (n <= 288)
				{
					long num2 = n - 257;
					if ((ulong)num2 <= 16uL)
					{
						switch ((int)num2)
						{
						case 5:
							goto IL_04ff;
						case 0:
							goto IL_0577;
						case 1:
							goto IL_058b;
						case 6:
							goto IL_05c5;
						case 7:
							goto IL_05e5;
						case 10:
							goto IL_0623;
						case 9:
							goto IL_0636;
						case 16:
							goto IL_0768;
						case 13:
							goto IL_07a1;
						case 2:
						case 3:
						case 4:
						case 8:
						case 11:
						case 12:
						case 14:
						case 15:
							goto IL_07de;
						}
					}
					if (n == 288)
					{
						goto IL_07d8;
					}
					goto IL_07de;
				}
				if (n != 292)
				{
					if (n != 293)
					{
						goto IL_07de;
					}
					result = SysPipe2((int*)checked((nuint)a1), (PipeFlags)checked((int)a2));
				}
				else
				{
					result = checked(SysDup2((int)a1, (int)a2));
				}
			}
			else if (n <= 318)
			{
				if (n != 302)
				{
					if (n != 318)
					{
						goto IL_07de;
					}
					result = SysGetrandom((byte*)checked((nuint)a1), checked((nuint)a2));
				}
				else
				{
					result = (long)SysPrlimit64(checked((int)a1), (RlimitResource)checked((int)a2), (Rlimit64Struct*)checked((nuint)a3), (Rlimit64Struct*)checked((nuint)a4));
				}
			}
			else if (n != 326)
			{
				if (n != 332)
				{
					if (n != 334)
					{
						goto IL_07de;
					}
					result = 0L;
				}
				else
				{
					result = (long)SysStatx(checked((int)a1), (byte*)checked((nuint)a2), checked((int)a3), (StatxMask)checked((uint)a4), (StatxStruct*)checked((nuint)a5));
				}
			}
			else
			{
				result = SysCopyFileRange(checked((int)a1), (long*)checked((nuint)a2), checked((int)a3), (long*)checked((nuint)a4), a5);
			}
			goto IL_07e4;
		}
		IL_078d:
		result = 0L;
		goto IL_07e4;
		IL_040d:
		result = SysPread64((int)a1, unchecked((void*)checked((nuint)a2)), a3, a4);
		goto IL_07e4;
		IL_0662:
		unchecked
		{
			result = (long)SysFsync(checked((int)a1));
			goto IL_07e4;
		}
		IL_066f:
		result = 0L;
		goto IL_07e4;
		IL_04b5:
		unchecked
		{
			result = SysPipe2((int*)checked((nuint)a1), PipeFlags.None);
			goto IL_07e4;
		}
		IL_06d1:
		result = Environment.ProcessId;
		goto IL_07e4;
		IL_07de:
		result = -38L;
		goto IL_07e4;
		IL_0701:
		result = SysSchedYield();
		goto IL_07e4;
		IL_07e4:
		if (1 == 0)
		{
		}
		return result;
		IL_0611:
		unchecked
		{
			result = SysReadlinkat(-100, (byte*)checked((nuint)a1), (byte*)checked((nuint)a2), a3);
			goto IL_07e4;
		}
		IL_06dd:
		result = 1000L;
		goto IL_07e4;
		IL_0686:
		unchecked
		{
			result = (long)SysGettimeofday((TimevalStruct*)checked((nuint)a1));
			goto IL_07e4;
		}
		IL_06e9:
		result = 1000L;
		goto IL_07e4;
		IL_0655:
		unchecked
		{
			result = (long)SysFsync(checked((int)a1));
			goto IL_07e4;
		}
		IL_05f5:
		result = SysGetcwd(unchecked((byte*)checked((nuint)a1)), (nuint)a2);
		goto IL_07e4;
		IL_05ab:
		unchecked
		{
			result = (long)SysRmdir((byte*)checked((nuint)a1));
			goto IL_07e4;
		}
		IL_059c:
		unchecked
		{
			result = (long)SysMkdir((byte*)checked((nuint)a1), checked((uint)a2));
			goto IL_07e4;
		}
		IL_05b8:
		unchecked
		{
			result = (long)SysUnlink((byte*)checked((nuint)a1));
			goto IL_07e4;
		}
		IL_0647:
		unchecked
		{
			result = (long)SysFtruncate(checked((int)a1), a2);
			goto IL_07e4;
		}
		IL_05d6:
		unchecked
		{
			result = (long)SysRename((byte*)checked((nuint)a1), (byte*)checked((nuint)a2));
			goto IL_07e4;
		}
		IL_0577:
		unchecked
		{
			result = SysOpenat(checked((int)a1), (byte*)checked((nuint)a2), (PosixOpenFlags)checked((int)a3), checked((uint)a4));
			goto IL_07e4;
		}
		IL_058b:
		unchecked
		{
			result = (long)SysMkdirat(checked((int)a1), (byte*)checked((nuint)a2), checked((uint)a3));
			goto IL_07e4;
		}
		IL_04ff:
		unchecked
		{
			result = (long)SysNewfstatat(checked((int)a1), (byte*)checked((nuint)a2), (StatStructX64*)checked((nuint)a3), checked((int)a4));
			goto IL_07e4;
		}
		IL_05c5:
		unchecked
		{
			result = (long)SysUnlinkat(checked((int)a1), (byte*)checked((nuint)a2), (AtFlags)checked((int)a3));
			goto IL_07e4;
		}
		IL_05e5:
		unchecked
		{
			result = (long)SysRename((byte*)checked((nuint)a2), (byte*)checked((nuint)a4));
			goto IL_07e4;
		}
		IL_0636:
		unchecked
		{
			result = (long)SysSymlinkat((byte*)checked((nuint)a1), checked((int)a2), (byte*)checked((nuint)a3));
			goto IL_07e4;
		}
		IL_0623:
		unchecked
		{
			result = SysReadlinkat(checked((int)a1), (byte*)checked((nuint)a2), (byte*)checked((nuint)a3), a4);
			goto IL_07e4;
		}
		IL_07a1:
		result = 0L;
		goto IL_07e4;
		IL_0768:
		result = 0L;
		goto IL_07e4;
		IL_0604:
		unchecked
		{
			result = (long)SysChdir((byte*)checked((nuint)a1));
			goto IL_07e4;
		}
		IL_0469:
		unchecked
		{
			result = (long)SysIoctl(checked((int)a1), (IoctlRequest)a2, (void*)checked((nuint)a3));
			goto IL_07e4;
		}
		IL_03eb:
		result = SysReadv((int)a1, unchecked((IovecStruct*)checked((nuint)a2)), (int)a3);
		goto IL_07e4;
		IL_06c5:
		result = Environment.ProcessId;
		goto IL_07e4;
		IL_074c:
		result = -10L;
		goto IL_07e4;
		IL_0722:
		result = SysExit((int)a1);
		goto IL_07e4;
		IL_07bd:
		unchecked
		{
			result = (long)SysUname((UnameStruct*)checked((nuint)a1));
			goto IL_07e4;
		}
		IL_0693:
		unchecked
		{
			result = (long)SysClockGettime((ClockId)checked((int)a1), (TimespecStruct*)checked((nuint)a2));
			goto IL_07e4;
		}
		IL_06a2:
		unchecked
		{
			result = (long)SysClockGetres((ClockId)checked((int)a1), (TimespecStruct*)checked((nuint)a2));
			goto IL_07e4;
		}
		IL_06b1:
		unchecked
		{
			result = (long)SysClockNanosleep((ClockId)checked((int)a1), (TimerFlags)checked((int)a2), (TimespecStruct*)checked((nuint)a3), (TimespecStruct*)checked((nuint)a4));
			goto IL_07e4;
		}
		IL_072f:
		result = SysExit((int)a1);
		goto IL_07e4;
		IL_0744:
		result = 0L;
		goto IL_07e4;
		IL_073c:
		result = 0L;
		goto IL_07e4;
		IL_045a:
		result = SysFcntl((int)a1, unchecked((FcntlCommand)a2), a3);
		goto IL_07e4;
		IL_0677:
		unchecked
		{
			result = (long)SysNanosleep((TimespecStruct*)checked((nuint)a1), (TimespecStruct*)checked((nuint)a2));
			goto IL_07e4;
		}
		IL_07d8:
		result = -97L;
		goto IL_07e4;
		IL_0431:
		result = SysSendfile((int)a1, (int)a2, unchecked((long*)checked((nuint)a3)), a4);
		goto IL_07e4;
		IL_070c:
		unchecked
		{
			result = SysClone((CloneFlags)a1, (ThreadStartArgs*)checked((nuint)a2), (int*)checked((nuint)a3), (int*)checked((nuint)a4), (void*)checked((nuint)a5));
			goto IL_07e4;
		}
		IL_041f:
		result = SysPwrite64((int)a1, unchecked((void*)checked((nuint)a2)), a3, a4);
		goto IL_07e4;
		IL_0568:
		unchecked
		{
			result = (long)SysAccess((byte*)checked((nuint)a1), (PosixAccessMode)checked((int)a2));
			goto IL_07e4;
		}
		IL_048a:
		result = SysDup((int)a1);
		goto IL_07e4;
		IL_0560:
		result = 0L;
		goto IL_07e4;
		IL_0497:
		result = SysDup2((int)a1, (int)a2);
		goto IL_07e4;
		IL_03fc:
		result = SysWritev((int)a1, unchecked((IovecStruct*)checked((nuint)a2)), (int)a3);
		goto IL_07e4;
		IL_0797:
		result = 0L;
		goto IL_07e4;
		IL_039d:
		result = SysRead((int)a1, unchecked((void*)checked((nuint)a2)), a3);
		goto IL_07e4;
		IL_03ad:
		result = SysWrite((int)a1, unchecked((void*)checked((nuint)a2)), a3);
		goto IL_07e4;
		IL_03bd:
		unchecked
		{
			result = SysOpenPath((byte*)checked((nuint)a1), (PosixOpenFlags)checked((int)a2), checked((uint)a3));
			goto IL_07e4;
		}
		IL_03ce:
		unchecked
		{
			result = (long)SysClose(checked((int)a1));
			goto IL_07e4;
		}
		IL_04d2:
		unchecked
		{
			result = (long)SysStat((byte*)checked((nuint)a1), (StatStructX64*)checked((nuint)a2));
			goto IL_07e4;
		}
		IL_04e1:
		unchecked
		{
			result = (long)SysFstat(checked((int)a1), (StatStructX64*)checked((nuint)a2));
			goto IL_07e4;
		}
		IL_04f0:
		unchecked
		{
			result = (long)SysStat((byte*)checked((nuint)a1), (StatStructX64*)checked((nuint)a2));
			goto IL_07e4;
		}
		IL_079c:
		result = 0L;
		goto IL_07e4;
		IL_03db:
		result = SysLseek((int)a1, a2, unchecked((PosixSeekWhence)checked((int)a3)));
		goto IL_07e4;
		IL_052a:
		result = SysMmap((nuint)a1, (nuint)a2, unchecked((MmapProtection)checked((int)a3)), unchecked((MmapFlags)checked((int)a4)), (int)a5, a6);
		goto IL_07e4;
		IL_0543:
		result = 0L;
		goto IL_07e4;
		IL_054b:
		unchecked
		{
			result = (long)SysMunmap(checked((nint)a1));
			goto IL_07e4;
		}
		IL_0558:
		result = 0L;
		goto IL_07e4;
		IL_0788:
		result = 0L;
		goto IL_07e4;
	}

	[MangledName("__dotnet_clone")]
	public unsafe static long DotnetClone(long flags, void* newStack, int* parentTid, int* childTid, void* tls, delegate*<void*, void> fn, void* arg)
	{
		if (fn == unchecked((delegate*<void*, void>)null))
		{
			return -22L;
		}
		return StartManagedThread((nint)fn, (nint)arg, parentTid, childTid);
	}

	private unsafe static long SysClone(CloneFlags flags, ThreadStartArgs* startArgs, int* parentTid, int* childTid, void* tls)
	{
		if (startArgs == null)
		{
			return -22L;
		}
		return StartManagedThread(startArgs->FnPtr, startArgs->ArgPtr, parentTid, childTid);
	}

	private unsafe static long StartManagedThread(nint fnPtr, nint argPtr, int* parentTid, int* childTid)
	{
		unchecked
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				int managedThreadId = Thread.CurrentThread.ManagedThreadId;
				if (childTid != null)
				{
					Volatile.Write(ref *childTid, managedThreadId);
				}
				if (_tidAddress != null)
				{
					Volatile.Write(ref *_tidAddress, managedThreadId);
				}
				((delegate*<void*, void>)checked((nuint)fnPtr))((void*)checked((nuint)argPtr));
			})
			{
				IsBackground = true
			};
			if (parentTid != null)
			{
				Volatile.Write(ref *parentTid, thread.ManagedThreadId);
			}
			thread.Start();
			return thread.ManagedThreadId;
		}
	}

	private unsafe static long SysRead(int fd, void* buf, long count)
	{
		if (buf == null || count < 0)
		{
			return -22L;
		}
		if (count == 0)
		{
			return 0L;
		}
		Stream value;
		Stream stream = ((fd == 0) ? Console.OpenStandardInput() : (_fileDescriptors.TryGetValue(fd, out value) ? value : null));
		if (stream == null)
		{
			return -9L;
		}
		try
		{
			return stream.Read(new Span<byte>(buf, (int)count));
		}
		catch
		{
			return -5L;
		}
	}

	private unsafe static long SysWrite(int fd, void* buf, long count)
	{
		if (buf == null || count < 0)
		{
			return -22L;
		}
		if (count == 0)
		{
			return 0L;
		}
		Stream value;
		Stream stream = fd switch
		{
			2 => Console.OpenStandardError(), 
			1 => Console.OpenStandardOutput(), 
			_ => _fileDescriptors.TryGetValue(fd, out value) ? value : null, 
		};
		if (stream == null)
		{
			return -9L;
		}
		try
		{
			stream.Write(new ReadOnlySpan<byte>(buf, (int)count));
			return count;
		}
		catch
		{
			return -5L;
		}
	}

	private unsafe static long SysReadv(int fd, IovecStruct* iov, int iovcnt)
	{
		long num = 0L;
		for (int i = 0; i < iovcnt; i++)
		{
			long num2 = SysRead(fd, unchecked((void*)checked((nuint)unchecked((IovecStruct*)((byte*)iov + checked(unchecked((nint)i) * unchecked((nint)sizeof(IovecStruct)))))->IovBase)), (long)unchecked((IovecStruct*)((byte*)iov + checked(unchecked((nint)i) * unchecked((nint)sizeof(IovecStruct)))))->IovLen);
			if (num2 < 0)
			{
				return (num > 0) ? num : num2;
			}
			num += num2;
			if ((nuint)num2 < unchecked((IovecStruct*)((byte*)iov + checked(unchecked((nint)i) * unchecked((nint)sizeof(IovecStruct)))))->IovLen)
			{
				break;
			}
		}
		return num;
	}

	private unsafe static long SysWritev(int fd, IovecStruct* iov, int iovcnt)
	{
		long num = 0L;
		for (int i = 0; i < iovcnt; i++)
		{
			long num2 = SysWrite(fd, unchecked((void*)checked((nuint)unchecked((IovecStruct*)((byte*)iov + checked(unchecked((nint)i) * unchecked((nint)sizeof(IovecStruct)))))->IovBase)), (long)unchecked((IovecStruct*)((byte*)iov + checked(unchecked((nint)i) * unchecked((nint)sizeof(IovecStruct)))))->IovLen);
			if (num2 < 0)
			{
				return (num > 0) ? num : num2;
			}
			num += num2;
		}
		return num;
	}

	private unsafe static long SysOpenPath(byte* pathname, PosixOpenFlags flags, uint mode)
	{
		if (pathname == null)
		{
			return -14L;
		}
		return OpenPath(Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty, flags, mode);
	}

	private unsafe static long SysOpenat(int dirfd, byte* pathname, PosixOpenFlags flags, uint mode)
	{
		if (pathname == null)
		{
			return -14L;
		}
		string text = Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty;
		Stream value;
		return OpenPath((dirfd == -100 || Path.IsPathRooted(text)) ? text : ((_fileDescriptors.TryGetValue(dirfd, out value) && value is FileStream fileStream) ? Path.Combine(Path.GetDirectoryName(fileStream.Name) ?? ".", text) : text), flags, mode);
	}

	private static long OpenPath(string path, PosixOpenFlags flags, uint mode)
	{
		if (Directory.Exists(path))
		{
			int num = Interlocked.Increment(ref _nextFd);
			_directoryFds[num] = new DirectoryFd(path);
			return num;
		}
		PosixOpenFlags posixOpenFlags = flags & (PosixOpenFlags.O_WRONLY | PosixOpenFlags.O_RDWR);
		if (1 == 0)
		{
		}
		FileAccess fileAccess = posixOpenFlags switch
		{
			PosixOpenFlags.O_WRONLY => FileAccess.Write, 
			PosixOpenFlags.O_RDWR => FileAccess.ReadWrite, 
			_ => FileAccess.Read, 
		};
		if (1 == 0)
		{
		}
		FileAccess access = fileAccess;
		bool flag = (flags & PosixOpenFlags.O_CREAT) != 0;
		bool flag2 = (flags & PosixOpenFlags.O_EXCL) != 0;
		bool flag3 = (flags & PosixOpenFlags.O_TRUNC) != 0;
		bool flag4 = (flags & PosixOpenFlags.O_APPEND) != 0;
		if (1 == 0)
		{
		}
		FileMode fileMode = (flag ? (flag2 ? FileMode.CreateNew : ((!flag3) ? FileMode.OpenOrCreate : FileMode.Create)) : (flag3 ? FileMode.Truncate : ((!flag4) ? FileMode.Open : FileMode.Append)));
		if (1 == 0)
		{
		}
		FileMode mode2 = fileMode;
		try
		{
			FileStream value = new FileStream(path, mode2, access, FileShare.ReadWrite);
			int num2 = Interlocked.Increment(ref _nextFd);
			_fileDescriptors[num2] = value;
			return num2;
		}
		catch (FileNotFoundException)
		{
			return -2L;
		}
		catch (UnauthorizedAccessException)
		{
			return -13L;
		}
		catch (IOException ex3) when (ex3.HResult == -2147024816)
		{
			return -17L;
		}
		catch (IOException)
		{
			return -5L;
		}
		catch
		{
			return -5L;
		}
	}

	private static LinuxErrno SysClose(int fd)
	{
		if (fd < 3)
		{
			return LinuxErrno.Success;
		}
		if (_directoryFds.TryRemove(fd, out DirectoryFd _))
		{
			return LinuxErrno.Success;
		}
		if (!_fileDescriptors.TryRemove(fd, out Stream value2))
		{
			return LinuxErrno.EBADF;
		}
		value2.Dispose();
		return LinuxErrno.Success;
	}

	private static long SysLseek(int fd, long offset, PosixSeekWhence whence)
	{
		if (!_fileDescriptors.TryGetValue(fd, out Stream value))
		{
			return -9L;
		}
		if (1 == 0)
		{
		}
		SeekOrigin seekOrigin = whence switch
		{
			PosixSeekWhence.SEEK_SET => SeekOrigin.Begin, 
			PosixSeekWhence.SEEK_CUR => SeekOrigin.Current, 
			PosixSeekWhence.SEEK_END => SeekOrigin.End, 
			_ => SeekOrigin.Begin, 
		};
		if (1 == 0)
		{
		}
		SeekOrigin origin = seekOrigin;
		try
		{
			return value.Seek(offset, origin);
		}
		catch
		{
			return -29L;
		}
	}

	private unsafe static LinuxErrno SysStat(byte* pathname, StatStructX64* statbuf)
	{
		if (pathname == null || statbuf == null)
		{
			return LinuxErrno.EFAULT;
		}
		return FillStatFromPath(statbuf, Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty);
	}

	private unsafe static LinuxErrno SysFstat(int fd, StatStructX64* statbuf)
	{
		if (statbuf == null)
		{
			return LinuxErrno.EFAULT;
		}
		if (unchecked((uint)fd) <= 2u)
		{
			*statbuf = default(StatStructX64);
			statbuf->StMode = StatMode.ChrDev;
			statbuf->StUid = 1000u;
			statbuf->StGid = 1000u;
			return LinuxErrno.Success;
		}
		if (_directoryFds.TryGetValue(fd, out DirectoryFd value))
		{
			return FillStatFromPath(statbuf, value.Path);
		}
		if (!_fileDescriptors.TryGetValue(fd, out Stream value2) || !(value2 is FileStream fileStream))
		{
			return LinuxErrno.EBADF;
		}
		return FillStatFromPath(statbuf, fileStream.Name);
	}

	private unsafe static LinuxErrno SysNewfstatat(int dirfd, byte* pathname, StatStructX64* statbuf, int atFlags)
	{
		if (pathname == null || statbuf == null)
		{
			return LinuxErrno.EFAULT;
		}
		return FillStatFromPath(statbuf, Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty);
	}

	private unsafe static LinuxErrno FillStatFromPath(StatStructX64* buf, string path)
	{
		*buf = default(StatStructX64);
		unchecked
		{
			try
			{
				bool flag = Directory.Exists(path);
				bool flag2 = !flag && File.Exists(path);
				if (!flag && !flag2)
				{
					return LinuxErrno.ENOENT;
				}
				buf->StUid = 1000u;
				buf->StGid = 1000u;
				buf->StBlksize = 4096L;
				if (flag2)
				{
					FileInfo fileInfo = new FileInfo(path);
					buf->StMode = StatMode.RegFile644;
					buf->StNlink = 1uL;
					buf->StSize = fileInfo.Length;
					buf->StBlocks = checked(fileInfo.Length + 511) / 512;
					buf->StAtim = TimespecStruct.FromUtc(fileInfo.LastAccessTimeUtc);
					buf->StMtim = TimespecStruct.FromUtc(fileInfo.LastWriteTimeUtc);
					buf->StCtim = TimespecStruct.FromUtc(fileInfo.CreationTimeUtc);
				}
				else
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(path);
					buf->StMode = StatMode.Dir755;
					buf->StNlink = 2uL;
					buf->StAtim = TimespecStruct.FromUtc(directoryInfo.LastAccessTimeUtc);
					buf->StMtim = TimespecStruct.FromUtc(directoryInfo.LastWriteTimeUtc);
					buf->StCtim = TimespecStruct.FromUtc(directoryInfo.CreationTimeUtc);
				}
				return LinuxErrno.Success;
			}
			catch
			{
				return LinuxErrno.EIO;
			}
		}
	}

	private unsafe static long SysMmap(nuint hint, nuint length, MmapProtection prot, MmapFlags flags, int fd, long offset)
	{
		if (length == 0)
		{
			return -22L;
		}
		if ((flags & MmapFlags.Anonymous) != 0)
		{
			void* ptr = NativeMemoryHelper.Allocate((long)length);
			_mmapAllocations[(nint)ptr] = length;
			return (nint)ptr;
		}
		if (!_fileDescriptors.TryGetValue(fd, out Stream value))
		{
			return -9L;
		}
		try
		{
			void* ptr2 = NativeMemoryHelper.Allocate((long)length);
			_mmapAllocations[(nint)ptr2] = length;
			value.Seek(offset, SeekOrigin.Begin);
			value.ReadExactly(new Span<byte>(ptr2, (int)length));
			return (nint)ptr2;
		}
		catch
		{
			return -5L;
		}
	}

	private unsafe static LinuxErrno SysMunmap(nint addr)
	{
		unchecked
		{
			if (_mmapAllocations.TryRemove(addr, out var _))
			{
				NativeMemoryHelper.Free((void*)checked((nuint)addr));
			}
			return LinuxErrno.Success;
		}
	}

	private unsafe static long SysFutex(int* addr, FutexOperation op, int val, TimespecStruct* timeout, int* addr2, int val3)
	{
		FutexOperation futexOperation = op & ~(FutexOperation.PrivateFlag | FutexOperation.ClockFlag);
		if (1 == 0)
		{
		}
		long result;
		switch (futexOperation)
		{
		case FutexOperation.Wait:
		case FutexOperation.WaitBitset:
			result = unchecked((long)FutexWait(addr, val, timeout));
			break;
		case FutexOperation.Wake:
		case FutexOperation.WakeBitset:
			result = FutexWake(addr, val);
			break;
		case FutexOperation.Requeue:
			result = FutexWake(addr, val);
			break;
		default:
			result = 0L;
			break;
		}
		if (1 == 0)
		{
		}
		return result;
	}

	private unsafe static LinuxErrno FutexWait(int* addr, int expected, TimespecStruct* timeoutRelNs)
	{
		FutexWaiter orAdd = _futexWaiters.GetOrAdd((nint)addr, (nint _) => new FutexWaiter());
		lock (orAdd.Lock)
		{
			if (Volatile.Read(in *addr) != expected)
			{
				return LinuxErrno.EAGAIN;
			}
			int millisecondsTimeout = ((timeoutRelNs != null) ? ((int)Math.Max(0L, timeoutRelNs->ToMilliseconds())) : (-1));
			orAdd.WaiterCount++;
			bool flag = Monitor.Wait(orAdd.Lock, millisecondsTimeout);
			orAdd.WaiterCount--;
			return unchecked((LinuxErrno)(flag ? 0 : (-110)));
		}
	}

	private unsafe static long FutexWake(int* addr, int count)
	{
		if (!_futexWaiters.TryGetValue((nint)addr, out FutexWaiter value))
		{
			return 0L;
		}
		lock (value.Lock)
		{
			int num = Math.Min(count, value.WaiterCount);
			if (count == 1)
			{
				Monitor.Pulse(value.Lock);
			}
			else
			{
				Monitor.PulseAll(value.Lock);
			}
			return num;
		}
	}

	private unsafe static LinuxErrno SysClockGettime(ClockId clockId, TimespecStruct* tp)
	{
		if (tp == null)
		{
			return LinuxErrno.EINVAL;
		}
		*tp = ((clockId == ClockId.Realtime) ? TimespecStruct.FromUtc(DateTime.UtcNow) : TimespecStruct.FromStopwatch());
		return LinuxErrno.Success;
	}

	private unsafe static LinuxErrno SysClockGetres(ClockId clockId, TimespecStruct* res)
	{
		if (res != null)
		{
			*res = new TimespecStruct
			{
				TvSec = 0L,
				TvNsec = 1L
			};
		}
		return LinuxErrno.Success;
	}

	private unsafe static LinuxErrno SysClockNanosleep(ClockId clockId, TimerFlags flags, TimespecStruct* req, TimespecStruct* rem)
	{
		if (req == null)
		{
			return LinuxErrno.EINVAL;
		}
		long num = (((flags & TimerFlags.AbsoluteTime) != TimerFlags.Relative) ? Math.Max(0L, req->TvSec * 1000000000 + req->TvNsec - TimespecStruct.FromStopwatch().TvSec * 1000000000) : (req->TvSec * 1000000000 + req->TvNsec));
		if (num > 0)
		{
			Thread.Sleep((int)Math.Max(1L, unchecked(num / 1000000)));
		}
		if (rem != null)
		{
			*rem = default(TimespecStruct);
		}
		return LinuxErrno.Success;
	}

	private unsafe static LinuxErrno SysNanosleep(TimespecStruct* req, TimespecStruct* rem)
	{
		if (req == null)
		{
			return LinuxErrno.EINVAL;
		}
		long num = req->TvSec * 1000000000 + req->TvNsec;
		if (num > 0)
		{
			Thread.Sleep((int)Math.Max(1L, unchecked(num / 1000000)));
		}
		if (rem != null)
		{
			*rem = default(TimespecStruct);
		}
		return LinuxErrno.Success;
	}

	private unsafe static LinuxErrno SysGettimeofday(TimevalStruct* tv)
	{
		if (tv == null)
		{
			return LinuxErrno.EINVAL;
		}
		long num = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() * 1000;
		unchecked
		{
			tv->TvSec = num / 1000000;
			tv->TvUsec = num % 1000000;
			return LinuxErrno.Success;
		}
	}

	private unsafe static LinuxErrno SysMkdir(byte* pathname, uint mode)
	{
		if (pathname == null)
		{
			return LinuxErrno.EFAULT;
		}
		string path = Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty;
		try
		{
			Directory.CreateDirectory(path);
			return LinuxErrno.Success;
		}
		catch (IOException)
		{
			return LinuxErrno.EEXIST;
		}
		catch
		{
			return LinuxErrno.EIO;
		}
	}

	private unsafe static LinuxErrno SysRmdir(byte* pathname)
	{
		if (pathname == null)
		{
			return LinuxErrno.EFAULT;
		}
		string path = Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty;
		try
		{
			Directory.Delete(path);
			return LinuxErrno.Success;
		}
		catch (DirectoryNotFoundException)
		{
			return LinuxErrno.ENOENT;
		}
		catch
		{
			return LinuxErrno.EIO;
		}
	}

	private unsafe static LinuxErrno SysUnlink(byte* pathname)
	{
		if (pathname == null)
		{
			return LinuxErrno.EFAULT;
		}
		string path = Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty;
		try
		{
			File.Delete(path);
			return LinuxErrno.Success;
		}
		catch (FileNotFoundException)
		{
			return LinuxErrno.ENOENT;
		}
		catch
		{
			return LinuxErrno.EIO;
		}
	}

	private unsafe static LinuxErrno SysUnlinkat(int dirfd, byte* pathname, AtFlags atFlags)
	{
		return ((atFlags & AtFlags.RemoveDir) != 0) ? SysRmdir(pathname) : SysUnlink(pathname);
	}

	private unsafe static LinuxErrno SysRename(byte* oldp, byte* newp)
	{
		if (oldp == null || newp == null)
		{
			return LinuxErrno.EFAULT;
		}
		string sourceFileName = Marshal.PtrToStringUTF8((nint)oldp) ?? string.Empty;
		string destFileName = Marshal.PtrToStringUTF8((nint)newp) ?? string.Empty;
		try
		{
			File.Move(sourceFileName, destFileName, overwrite: true);
			return LinuxErrno.Success;
		}
		catch
		{
			return LinuxErrno.EIO;
		}
	}

	private unsafe static long SysGetcwd(byte* buf, nuint size)
	{
		if (buf == null || size == 0)
		{
			return -22L;
		}
		byte[] bytes = Encoding.UTF8.GetBytes(Directory.GetCurrentDirectory());
		if ((nuint)(bytes.Length + 1) > size)
		{
			return -34L;
		}
		bytes.AsSpan().CopyTo(new Span<byte>(buf, (int)size));
		buf[bytes.Length] = 0;
		return (nint)buf;
	}

	private unsafe static LinuxErrno SysChdir(byte* pathname)
	{
		if (pathname == null)
		{
			return LinuxErrno.EFAULT;
		}
		string currentDirectory = Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty;
		try
		{
			Directory.SetCurrentDirectory(currentDirectory);
			return LinuxErrno.Success;
		}
		catch
		{
			return LinuxErrno.ENOENT;
		}
	}

	private unsafe static LinuxErrno SysAccess(byte* pathname, PosixAccessMode mode)
	{
		if (pathname == null)
		{
			return LinuxErrno.EFAULT;
		}
		string text = Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty;
		try
		{
			if (!File.Exists(text) && !Directory.Exists(text))
			{
				return LinuxErrno.ENOENT;
			}
			if ((mode & PosixAccessMode.W_OK) != PosixAccessMode.F_OK && File.Exists(text) && new FileInfo(text).IsReadOnly)
			{
				return LinuxErrno.EACCES;
			}
			return LinuxErrno.Success;
		}
		catch
		{
			return LinuxErrno.EIO;
		}
	}

	private unsafe static long SysGetrandom(byte* buf, nuint count)
	{
		if (buf == null)
		{
			return -14L;
		}
		RandomNumberGenerator.Fill(new Span<byte>(buf, (int)count));
		return (long)count;
	}

	private unsafe static LinuxErrno SysUname(UnameStruct* buf)
	{
		if (buf == null)
		{
			return LinuxErrno.EFAULT;
		}
		*buf = default(UnameStruct);
		WriteFixedField(buf->Sysname, "Linux");
		WriteFixedField(buf->Nodename, "dotnet-host");
		WriteFixedField(buf->Release, "6.1.0");
		WriteFixedField(buf->Version, "#1 SMP");
		WriteFixedField(buf->Machine, "x86_64");
		WriteFixedField(buf->Domainname, "");
		return LinuxErrno.Success;
	}

	private unsafe static void WriteFixedField(byte* dest, string s)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(s);
		bytes.AsSpan().CopyTo(new Span<byte>(dest, bytes.Length + 1));
	}

	private unsafe static LinuxErrno SysIoctl(int fd, IoctlRequest request, void* arg)
	{
		if (request == IoctlRequest.TIOCGWINSZ && arg != null)
		{
			*unchecked((WinsizeStruct*)arg) = new WinsizeStruct
			{
				WsRow = 24,
				WsCol = 80
			};
		}
		return LinuxErrno.Success;
	}

	private static long SysFcntl(int fd, FcntlCommand cmd, long arg)
	{
		unchecked
		{
			if ((ulong)cmd <= 4uL)
			{
				switch ((int)cmd)
				{
				case 0:
					goto IL_0035;
				case 1:
					return 0L;
				case 2:
					return 0L;
				case 3:
					goto IL_0048;
				case 4:
					return 0L;
				}
			}
			if (cmd != FcntlCommand.F_DUPFD_CLOEXEC)
			{
				return -22L;
			}
			goto IL_0035;
		}
		IL_0048:
		if (!_fileDescriptors.TryGetValue(fd, out Stream value))
		{
			return 2L;
		}
		return (value.CanWrite && value.CanRead) ? 2 : (value.CanWrite ? 1 : 0);
		IL_0035:
		return SysDup(fd);
	}

	private unsafe static long SysSetTidAddress(int* tidPtr)
	{
		_tidAddress = tidPtr;
		return Thread.CurrentThread.ManagedThreadId;
	}

	private static long SysExit(int code)
	{
		Environment.Exit(code);
		return 0L;
	}

	private unsafe static long SysArchPrctl(ArchPrctlCode code, long addr)
	{
		if (1 == 0)
		{
		}
		unchecked
		{
			long result;
			switch (code)
			{
			case ArchPrctlCode.ARCH_SET_GS:
			case ArchPrctlCode.ARCH_SET_FS:
				result = 0L;
				break;
			case ArchPrctlCode.ARCH_GET_FS:
			case ArchPrctlCode.ARCH_GET_GS:
				result = ((addr != 0L) ? (*(long*)checked((nuint)addr) = 0L, 0L).Item2 : 0);
				break;
			default:
				result = -22L;
				break;
			}
			if (1 == 0)
			{
			}
			return result;
		}
	}

	private static long SysSchedYield()
	{
		Thread.Yield();
		return 0L;
	}

	private static long SysDup(int oldfd)
	{
		if (_directoryFds.TryGetValue(oldfd, out DirectoryFd value))
		{
			int num = Interlocked.Increment(ref _nextFd);
			_directoryFds[num] = new DirectoryFd(value.Path);
			return num;
		}
		if (1 == 0)
		{
		}
		Stream value2;
		Stream stream = oldfd switch
		{
			0 => Console.OpenStandardInput(), 
			1 => Console.OpenStandardOutput(), 
			2 => Console.OpenStandardError(), 
			_ => _fileDescriptors.TryGetValue(oldfd, out value2) ? value2 : null, 
		};
		if (1 == 0)
		{
		}
		Stream stream2 = stream;
		if (stream2 == null)
		{
			return -9L;
		}
		int num2 = Interlocked.Increment(ref _nextFd);
		_fileDescriptors[num2] = stream2;
		return num2;
	}

	private static long SysDup2(int oldfd, int newfd)
	{
		if (oldfd == newfd)
		{
			return newfd;
		}
		SysClose(newfd);
		if (_directoryFds.TryGetValue(oldfd, out DirectoryFd value))
		{
			_directoryFds[newfd] = new DirectoryFd(value.Path);
			return newfd;
		}
		if (1 == 0)
		{
		}
		Stream value2;
		Stream stream = oldfd switch
		{
			0 => Console.OpenStandardInput(), 
			1 => Console.OpenStandardOutput(), 
			2 => Console.OpenStandardError(), 
			_ => _fileDescriptors.TryGetValue(oldfd, out value2) ? value2 : null, 
		};
		if (1 == 0)
		{
		}
		Stream stream2 = stream;
		if (stream2 == null)
		{
			return -9L;
		}
		_fileDescriptors[newfd] = stream2;
		return newfd;
	}

	private unsafe static long SysPipe2(int* fds, PipeFlags flags)
	{
		if (fds == null)
		{
			return -14L;
		}
		AnonymousPipeServerStream anonymousPipeServerStream = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.None);
		AnonymousPipeClientStream value = new AnonymousPipeClientStream(PipeDirection.In, anonymousPipeServerStream.ClientSafePipeHandle);
		int num = Interlocked.Increment(ref _nextFd);
		int num2 = Interlocked.Increment(ref _nextFd);
		_fileDescriptors[num] = value;
		_fileDescriptors[num2] = anonymousPipeServerStream;
		*fds = num;
		fds[1] = num2;
		return 0L;
	}

	private unsafe static long SysPread64(int fd, void* buf, long count, long offset)
	{
		if (buf == null || count < 0)
		{
			return -22L;
		}
		if (!_fileDescriptors.TryGetValue(fd, out Stream value))
		{
			return -9L;
		}
		long num = (value.CanSeek ? value.Position : (-1));
		try
		{
			if (value.CanSeek)
			{
				value.Position = offset;
			}
			return value.Read(new Span<byte>(buf, (int)count));
		}
		catch
		{
			return -5L;
		}
		finally
		{
			if (num >= 0 && value.CanSeek)
			{
				value.Position = num;
			}
		}
	}

	private unsafe static long SysPwrite64(int fd, void* buf, long count, long offset)
	{
		if (buf == null || count < 0)
		{
			return -22L;
		}
		if (!_fileDescriptors.TryGetValue(fd, out Stream value))
		{
			return -9L;
		}
		long num = (value.CanSeek ? value.Position : (-1));
		try
		{
			if (value.CanSeek)
			{
				value.Position = offset;
			}
			value.Write(new ReadOnlySpan<byte>(buf, (int)count));
			return count;
		}
		catch
		{
			return -5L;
		}
		finally
		{
			if (num >= 0 && value.CanSeek)
			{
				value.Position = num;
			}
		}
	}

	private unsafe static long SysSendfile(int outFd, int inFd, long* offset, long count)
	{
		if (!_fileDescriptors.TryGetValue(inFd, out Stream value))
		{
			return -9L;
		}
		if (!_fileDescriptors.TryGetValue(outFd, out Stream value2))
		{
			return -9L;
		}
		try
		{
			if (offset != null && value.CanSeek)
			{
				value.Position = *offset;
			}
			byte[] array = new byte[(int)Math.Min(count, 65536L)];
			long num;
			int num2;
			for (num = 0L; num < count; num += num2)
			{
				int count2 = (int)Math.Min(array.Length, count - num);
				num2 = value.Read(array, 0, count2);
				if (num2 == 0)
				{
					break;
				}
				value2.Write(array, 0, num2);
			}
			if (offset != null)
			{
				*offset += num;
			}
			return num;
		}
		catch
		{
			return -5L;
		}
	}

	private unsafe static long SysCopyFileRange(int fdIn, long* offIn, int fdOut, long* offOut, long len)
	{
		return SysSendfile(fdOut, fdIn, offIn, len);
	}

	private static LinuxErrno SysFtruncate(int fd, long length)
	{
		if (!_fileDescriptors.TryGetValue(fd, out Stream value))
		{
			return LinuxErrno.EBADF;
		}
		try
		{
			value.SetLength(length);
			return LinuxErrno.Success;
		}
		catch
		{
			return LinuxErrno.EIO;
		}
	}

	private static LinuxErrno SysFsync(int fd)
	{
		if (_fileDescriptors.TryGetValue(fd, out Stream value))
		{
			try
			{
				value.Flush();
			}
			catch
			{
			}
		}
		return LinuxErrno.Success;
	}

	private unsafe static long SysGetdents64(int fd, byte* dirp, int count)
	{
		if (!_directoryFds.TryGetValue(fd, out DirectoryFd value))
		{
			return -20L;
		}
		if (dirp == null || count < 0)
		{
			return -22L;
		}
		if (value.Entries == null)
		{
			string[] fileSystemEntries = Directory.GetFileSystemEntries(value.Path);
			value.Entries = new string[fileSystemEntries.Length + 2];
			value.Entries[0] = value.Path;
			value.Entries[1] = Path.GetDirectoryName(value.Path) ?? value.Path;
			fileSystemEntries.CopyTo(value.Entries, 2);
		}
		string[] entries = value.Entries;
		int num = 0;
		int num2 = sizeof(LinuxDirent64Header);
		while (value.Position < entries.Length)
		{
			string text = entries[value.Position];
			string s = ((value.Position == 0) ? "." : ((value.Position == 1) ? ".." : Path.GetFileName(text)));
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			int num3 = (num2 + bytes.Length + 1 + 7) & -8;
			if (num + num3 > count)
			{
				break;
			}
			DirentType dType = (Directory.Exists(text) ? DirentType.Dir : (File.Exists(text) ? DirentType.Reg : DirentType.Unknown));
			LinuxDirent64Header* ptr;
			unchecked
			{
				ptr = (LinuxDirent64Header*)checked(unchecked((nuint)dirp) + unchecked((nuint)num));
			}
			ptr->DIno = (ulong)Math.Abs(text.GetHashCode(StringComparison.Ordinal));
			ptr->DOff = value.Position + 1;
			ptr->DReclen = (ushort)num3;
			ptr->DType = dType;
			unchecked
			{
				byte* ptr2 = (byte*)checked(unchecked((nuint)ptr) + unchecked((nuint)num2));
				bytes.AsSpan().CopyTo(new Span<byte>(ptr2, checked(bytes.Length + 1)));
				ptr2[bytes.Length] = 0;
				for (byte* ptr3 = (byte*)checked(unchecked((nuint)ptr2) + unchecked((nuint)bytes.Length) + 1); (nuint)ptr3 < checked(unchecked((nuint)ptr) + unchecked((nuint)num3)); ptr3 = (byte*)checked(unchecked((nuint)ptr3) + (nuint)1u))
				{
					*ptr3 = 0;
				}
			}
			num += num3;
			value.Position++;
		}
		return num;
	}

	private unsafe static long SysReadlinkat(int dirfd, byte* pathname, byte* buf, long bufsiz)
	{
		if (pathname == null || buf == null || bufsiz <= 0)
		{
			return -22L;
		}
		string text = Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty;
		if (1 == 0)
		{
		}
		string text2 = text switch
		{
			"/proc/self/exe" => Environment.ProcessPath, 
			"/proc/self/cwd" => Directory.GetCurrentDirectory(), 
			"/proc/self" => $"/proc/{Environment.ProcessId}", 
			_ => null, 
		};
		if (1 == 0)
		{
		}
		string text3 = text2;
		if (text3 == null)
		{
			try
			{
				text3 = File.ResolveLinkTarget(text, returnFinalTarget: false)?.FullName;
			}
			catch
			{
			}
		}
		if (text3 == null)
		{
			return -2L;
		}
		byte[] bytes = Encoding.UTF8.GetBytes(text3);
		int num = (int)Math.Min(bytes.Length, bufsiz);
		new Span<byte>(bytes, 0, num).CopyTo(new Span<byte>(buf, num));
		return num;
	}

	private unsafe static LinuxErrno SysSymlinkat(byte* target, int newdirfd, byte* linkpathname)
	{
		if (target == null || linkpathname == null)
		{
			return LinuxErrno.EFAULT;
		}
		string pathToTarget = Marshal.PtrToStringUTF8((nint)target) ?? string.Empty;
		string path = Marshal.PtrToStringUTF8((nint)linkpathname) ?? string.Empty;
		try
		{
			File.CreateSymbolicLink(path, pathToTarget);
			return LinuxErrno.Success;
		}
		catch (IOException)
		{
			return LinuxErrno.EEXIST;
		}
		catch
		{
			return LinuxErrno.EIO;
		}
	}

	private unsafe static LinuxErrno SysStatx(int dirfd, byte* pathname, int flags, StatxMask mask, StatxStruct* statxbuf)
	{
		if (pathname == null || statxbuf == null)
		{
			return LinuxErrno.EFAULT;
		}
		string text = Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty;
		if (string.IsNullOrEmpty(text) && dirfd >= 0)
		{
			StatStructX64 statStructX = default(StatStructX64);
			LinuxErrno linuxErrno = SysFstat(dirfd, &statStructX);
			if (linuxErrno != LinuxErrno.Success)
			{
				return linuxErrno;
			}
			FillStatxFromStat(statxbuf, &statStructX, mask);
			return LinuxErrno.Success;
		}
		if (!Path.IsPathRooted(text) && dirfd != -100 && _directoryFds.TryGetValue(dirfd, out DirectoryFd value))
		{
			text = Path.Combine(value.Path, text);
		}
		StatStructX64 statStructX2 = default(StatStructX64);
		LinuxErrno linuxErrno2 = FillStatFromPath(&statStructX2, text);
		if (linuxErrno2 != LinuxErrno.Success)
		{
			return linuxErrno2;
		}
		FillStatxFromStat(statxbuf, &statStructX2, mask);
		return LinuxErrno.Success;
	}

	private unsafe static void FillStatxFromStat(StatxStruct* sx, StatStructX64* s, StatxMask mask)
	{
		*sx = default(StatxStruct);
		sx->Mask = mask & StatxMask.BasicStats;
		sx->Blksize = 4096u;
		sx->Nlink = (uint)s->StNlink;
		sx->Uid = s->StUid;
		sx->Gid = s->StGid;
		sx->Mode = (ushort)s->StMode;
		sx->Ino = s->StIno;
		sx->Size = (ulong)s->StSize;
		sx->Blocks = (ulong)s->StBlocks;
		sx->Atime = new StatxTimestampStruct
		{
			TvSec = s->StAtim.TvSec,
			TvNsec = (uint)s->StAtim.TvNsec
		};
		sx->Mtime = new StatxTimestampStruct
		{
			TvSec = s->StMtim.TvSec,
			TvNsec = (uint)s->StMtim.TvNsec
		};
		sx->Ctime = new StatxTimestampStruct
		{
			TvSec = s->StCtim.TvSec,
			TvNsec = (uint)s->StCtim.TvNsec
		};
	}

	private unsafe static LinuxErrno SysMkdirat(int dirfd, byte* pathname, uint mode)
	{
		if (pathname == null)
		{
			return LinuxErrno.EFAULT;
		}
		string text = Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty;
		DirectoryFd value;
		return SysMkdir((dirfd == -100 || Path.IsPathRooted(text)) ? text : (_directoryFds.TryGetValue(dirfd, out value) ? Path.Combine(value.Path, text) : text), mode);
	}

	private static LinuxErrno SysMkdir(string path, uint mode)
	{
		try
		{
			Directory.CreateDirectory(path);
			return LinuxErrno.Success;
		}
		catch (IOException)
		{
			return LinuxErrno.EEXIST;
		}
		catch
		{
			return LinuxErrno.EIO;
		}
	}

	private unsafe static LinuxErrno SysPrlimit64(int pid, RlimitResource resource, Rlimit64Struct* newLimit, Rlimit64Struct* oldLimit)
	{
		if (oldLimit != null)
		{
			ref ulong rlimCur = ref oldLimit->RlimCur;
			ref ulong rlimMax = ref oldLimit->RlimMax;
			if (1 == 0)
			{
			}
			(ulong, ulong) tuple = resource switch
			{
				RlimitResource.RLIMIT_STACK => (8388608uL, ulong.MaxValue), 
				RlimitResource.RLIMIT_NOFILE => (1024uL, 4096uL), 
				RlimitResource.RLIMIT_AS => (ulong.MaxValue, ulong.MaxValue), 
				_ => (ulong.MaxValue, ulong.MaxValue), 
			};
			if (1 == 0)
			{
			}
			(rlimCur, rlimMax) = tuple;
		}
		return LinuxErrno.Success;
	}

	private unsafe static T GetOrCreateSyncObject<T>(nint* slot, Func<T> factory) where T : class
	{
		nint num = Volatile.Read(in *slot);
		if (num != IntPtr.Zero)
		{
			return GCHandle<T>.FromIntPtr(num).Target;
		}
		T val = factory();
		GCHandle<T> value = new GCHandle<T>(val);
		nint num2 = Interlocked.CompareExchange(ref *slot, GCHandle<T>.ToIntPtr(value), IntPtr.Zero);
		if (num2 != IntPtr.Zero)
		{
			value.Dispose();
			return GCHandle<T>.FromIntPtr(num2).Target;
		}
		return val;
	}

	private unsafe static void FreeSyncSlot(nint* slot)
	{
		nint num = Interlocked.Exchange(ref *slot, IntPtr.Zero);
		if (num != IntPtr.Zero)
		{
			GCHandle<object>.FromIntPtr(num).Dispose();
		}
	}

	private unsafe static T? TryGetSyncObject<T>(nint* slot) where T : class
	{
		nint num = Volatile.Read(in *slot);
		return (num == IntPtr.Zero) ? null : GCHandle<T>.FromIntPtr(num).Target;
	}

	private unsafe static PthreadMutexBase GetOrCreateMutex(nint* mutex)
	{
		return GetOrCreateSyncObject(mutex, (Func<PthreadMutexBase>)(() => new NormalPthreadMutex()));
	}

	private static PthreadMutexBase CreateMutexForType(PthreadMutexType type)
	{
		if (1 == 0)
		{
		}
		PthreadMutexBase result = type switch
		{
			PthreadMutexType.Recursive => new RecursivePthreadMutex(), 
			PthreadMutexType.Errorcheck => new ErrorCheckPthreadMutex(), 
			_ => new NormalPthreadMutex(), 
		};
		if (1 == 0)
		{
		}
		return result;
	}

	private unsafe static ReaderWriterLockSlim GetOrCreateRwLock(nint* rwlock)
	{
		return GetOrCreateSyncObject(rwlock, () => new ReaderWriterLockSlim(LockRecursionPolicy.NoRecursion));
	}

	private unsafe static PthreadCondVar GetOrCreateCondVar(nint* cond)
	{
		return GetOrCreateSyncObject(cond, () => new PthreadCondVar());
	}

	private unsafe static SemaphoreSlim GetOrCreateSemaphore(nint* sem)
	{
		return GetOrCreateSyncObject(sem, () => new SemaphoreSlim(0, int.MaxValue));
	}

	[MangledName("__stdio_common_vfprintf")]
	public unsafe static int __stdio_common_vfprintf(long options, void* stream, void* format, void* locale, void* argList)
	{
		string text = FormatPrintf(unchecked((byte*)format), new ReadOnlySpan<nint>(argList, 64));
		if (text == null)
		{
			return -1;
		}
		if (stream == StandardOutput)
		{
			Console.Write(text);
		}
		else
		{
			if (stream != StandardError)
			{
				return -1;
			}
			Console.Error.Write(text);
		}
		return text.Length;
	}

	[MangledName("__stdio_common_vsprintf_s")]
	public unsafe static int __stdio_common_vsprintf_s(long options, void* buffer, long bufferLength, void* format, void* locale, void* argList)
	{
		string text = FormatPrintf(unchecked((byte*)format), new ReadOnlySpan<nint>(argList, 64));
		if (text == null)
		{
			return -1;
		}
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		long num = Math.Min(bytes.Length, bufferLength - 1);
		bytes.AsSpan(0, (int)num).CopyTo(new Span<byte>(buffer, (int)bufferLength));
		unchecked((sbyte*)buffer)[num] = 0;
		return (int)num;
	}

	[MangledName("__stdio_common_vsscanf")]
	public unsafe static int __stdio_common_vsscanf(long options, void* input, long inputLength, void* format, void* locale, void* argList)
	{
		throw new NotSupportedException("scanf family is not supported.");
	}

	[MangledName("__acrt_iob_func")]
	public unsafe static void* GetSystemStream(int identifier)
	{
		if (1 == 0)
		{
		}
		void* result = identifier switch
		{
			0 => StandardInput, 
			1 => StandardOutput, 
			2 => StandardError, 
			_ => null, 
		};
		if (1 == 0)
		{
		}
		return result;
	}

	[MangledName("_wassert")]
	[MightThrow]
	public unsafe static void Assert(char* message, char* file, uint line)
	{
		ExceptionInfo.Current = new AssertExceptionInfo($"Assertion failed: {Marshal.PtrToStringUni((nint)message)} at {Marshal.PtrToStringUni((nint)file)}:{line}");
	}

	[DoesNotReturn]
	[MangledName("_invoke_watson")]
	public unsafe static void InvokeWatson(char* expression, char* function, char* file, int line, long reserved)
	{
		throw new FatalException($"Fatal assertion failed: {Marshal.PtrToStringUni((nint)expression)} in {Marshal.PtrToStringUni((nint)function)} at {Marshal.PtrToStringUni((nint)file)}:{line}");
	}

	[DoesNotReturn]
	[MangledName("__std_terminate")]
	public static void StdTerminate()
	{
		Terminate();
	}

	[MangledName("_CxxThrowException")]
	[MightThrow]
	public unsafe static void CxxThrowException(void* exceptionPointer, void* throwInfo)
	{
		ExceptionInfo.Current = new NativeExceptionInfo(exceptionPointer, unchecked((ThrowInfo*)throwInfo));
	}

	[MangledName("__CxxFrameHandler3")]
	public unsafe static int CxxFrameHandler3(ReadOnlySpan<nint> args)
	{
		if (args.Length != 3)
		{
			throw new ArgumentException("Expected 3 arguments", "args");
		}
		if (args[0] == 0 || args[1] == 0 || args[2] == 0)
		{
			throw new ArgumentNullException("args", "Arguments cannot be null");
		}
		unchecked
		{
			RttiTypeDescriptor* ptr = *(RttiTypeDescriptor**)checked((nuint)args[0]);
			_ = *(int*)checked((nuint)args[1]);
			void** ptr2 = (void**)checked((nuint)args[2]);
			if (ExceptionInfo.Current is NativeExceptionInfo nativeExceptionInfo)
			{
				if (ptr != null && !nativeExceptionInfo.Contains(ptr))
				{
					return 1;
				}
				if (ptr2 != null)
				{
					*ptr2 = nativeExceptionInfo.ExceptionPointer;
				}
				return 0;
			}
			if (ptr != null || ptr2 != null)
			{
				throw new NotSupportedException("Current exception is not a NativeExceptionInfo.");
			}
			return 0;
		}
	}

	[MangledName("??2@YAPEAX_K@Z")]
	public unsafe static void* MsvcNew(long size)
	{
		return NativeMemoryHelper.Allocate(size);
	}

	[MangledName("??3@YAXPEAX_K@Z")]
	public unsafe static void Delete(void* ptr, long size)
	{
		NativeMemoryHelper.Free(ptr);
	}

	[MangledName("_msize")]
	public unsafe static long Size(void* ptr)
	{
		return NativeMemoryHelper.Size(ptr);
	}

	[MangledName("expand")]
	public unsafe static void* Expand(void* ptr, long size)
	{
		return null;
	}
}
