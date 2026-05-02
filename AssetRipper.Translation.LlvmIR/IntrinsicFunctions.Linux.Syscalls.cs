using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using AssetRipper.Translation.LlvmIR.Attributes;

namespace AssetRipper.Translation.LlvmIR;

#pragma warning disable IDE0060 // Remove unused parameter
internal static unsafe partial class IntrinsicFunctions
{
	// ── Syscall numbers (Linux x86-64) ────────────────────────────────────────

	private enum SyscallNumber : long
	{
		Read = 0,
		Write = 1,
		Open = 2,
		Close = 3,
		Stat = 4,
		Fstat = 5,
		Lstat = 6,
		Poll = 7,
		Lseek = 8,
		Mmap = 9,
		Mprotect = 10,
		Munmap = 11,
		Brk = 12,
		RtSigaction = 13,
		RtSigprocmask = 14,
		Pread64 = 17,
		Pwrite64 = 18,
		Readv = 19,
		Writev = 20,
		Access = 21,
		Pipe = 22,
		Select = 23,
		SchedYield = 24,
		Madvise = 28,
		Dup = 32,
		Dup2 = 33,
		Nanosleep = 35,
		Getpid = 39,
		Sendfile = 40,
		Socket = 41,
		Connect = 42,
		Accept = 43,
		SendTo = 44,
		RecvFrom = 45,
		SendMsg = 46,
		RecvMsg = 47,
		Shutdown = 48,
		Bind = 49,
		Listen = 50,
		Getsockname = 51,
		Getpeername = 52,
		Setsockopt = 54,
		Getsockopt = 55,
		Clone = 56,
		Exit = 60,
		Wait4 = 61,
		Kill = 62,
		Uname = 63,
		Fcntl = 72,
		Fsync = 74,
		Fdatasync = 75,
		Ftruncate = 77,
		Getcwd = 79,
		Chdir = 80,
		Rename = 82,
		Mkdir = 83,
		Rmdir = 84,
		Unlink = 87,
		Readlink = 89,
		Fchmod = 91,
		Gettimeofday = 96,
		Getuid = 102,
		Getgid = 104,
		Getppid = 110,
		Ioctl = 16,
		Prctl = 157,
		ArchPrctl = 158,
		Gettid = 186,
		Futex = 202,
		Getdents64 = 217,
		SetTidAddress = 218,
		ClockGettime = 228,
		ClockGetres = 229,
		ClockNanosleep = 230,
		ExitGroup = 231,
		Tgkill = 234,
		Waitid = 247,
		Openat = 257,
		Mkdirat = 258,
		Newfstatat = 262,
		Unlinkat = 263,
		Renameat = 264,
		Symlinkat = 266,
		Readlinkat = 267,
		Pselect6 = 270,
		SetRobustList = 273,
		Accept4 = 288,
		Dup3 = 292,
		Pipe2 = 293,
		Prlimit64 = 302,
		Getrandom = 318,
		CopyFileRange = 326,
		Statx = 332,
		Rseq = 334,
	}

	// ── POSIX errno values (returned as negated longs) ────────────────────────

	private enum LinuxErrno : long
	{
		Success = 0,
		EPERM = -1,
		ENOENT = -2,
		EIO = -5,
		EBADF = -9,
		ECHILD = -10,
		EAGAIN = -11,
		ENOMEM = -12,
		EACCES = -13,
		EFAULT = -14,
		EBUSY = -16,
		EEXIST = -17,
		ENOTDIR = -20,
		EINVAL = -22,
		ESPIPE = -29,
		ERANGE = -34,
		ENOSYS = -38,
		ENOTEMPTY = -39,
		ELOOP = -40,
		ENOTSUP = -95,
		EAFNOSUPPORT = -97,
		ETIMEDOUT = -110,
		ECONNREFUSED = -111,
	}

	// ── stat(2) mode bits ────────────────────────────────────────────────────

	[Flags]
	private enum StatMode : uint
	{
		S_IFMT = 0xF000u,
		S_IFREG = 0x8000u,
		S_IFDIR = 0x4000u,
		S_IFCHR = 0x2000u,
		S_IRUSR = 0x0100u,
		S_IWUSR = 0x0080u,
		S_IXUSR = 0x0040u,
		S_IRGRP = 0x0020u,
		S_IWGRP = 0x0010u,
		S_IXGRP = 0x0008u,
		S_IROTH = 0x0004u,
		S_IWOTH = 0x0002u,
		S_IXOTH = 0x0001u,

		// Common composites
		RegFile644 = S_IFREG | S_IRUSR | S_IWUSR | S_IRGRP | S_IROTH, // 0x81A4
		Dir755 = S_IFDIR | S_IRUSR | S_IWUSR | S_IXUSR | S_IRGRP | S_IXGRP | S_IROTH | S_IXOTH, // 0x41ED
		ChrDev = S_IFCHR | S_IRUSR | S_IWUSR | S_IRGRP | S_IWGRP | S_IROTH | S_IWOTH, // 0x21B6
	}

	// ── Futex operation codes ────────────────────────────────────────────────

	[Flags]
	private enum FutexOperation
	{
		Wait = 0,
		Wake = 1,
		Requeue = 3,
		WaitBitset = 9,
		WakeBitset = 10,
		PrivateFlag = 128,
		ClockFlag = 256,
	}

	// ── mmap prot / flags ────────────────────────────────────────────────────

	[Flags]
	private enum MmapProtection
	{
		None = 0,
		Read = 1,
		Write = 2,
		Exec = 4,
	}

	[Flags]
	private enum MmapFlags
	{
		Shared = 1,
		Private = 2,
		Fixed = 16,
		Anonymous = 32,
	}

	// ── clone(2) flags ───────────────────────────────────────────────────────

	[Flags]
	private enum CloneFlags : long
	{
		Thread = 0x00010000L,
		Vm = 0x00000100L,
		Fs = 0x00000200L,
		Files = 0x00000400L,
		Sighand = 0x00000800L,
		Sysvsem = 0x00040000L,
		Settls = 0x00080000L,
		ParentSetTid = 0x00100000L,
		ChildClearTid = 0x00200000L,
	}

	// ── fcntl(2) commands ────────────────────────────────────────────────────

	private enum FcntlCommand : long
	{
		F_DUPFD = 0,
		F_GETFD = 1,
		F_SETFD = 2,
		F_GETFL = 3,
		F_SETFL = 4,
		F_DUPFD_CLOEXEC = 1030,
	}

	private const int FD_CLOEXEC = 1;

	// ── ioctl(2) request codes ───────────────────────────────────────────────

	private enum IoctlRequest : long
	{
		TIOCGWINSZ = 0x5413,
		TIOCSWINSZ = 0x5414,
		FIONREAD = 0x541B,
	}

	// ── POSIX clock IDs ───────────────────────────────────────────────────────

	private enum ClockId
	{
		Realtime = 0,
		Monotonic = 1,
		ProcessCpu = 2,
		ThreadCpu = 3,
	}

	// ── clock_nanosleep flags ──────────────────────────────────────────────────

	[Flags]
	private enum TimerFlags
	{
		Relative = 0,
		AbsoluteTime = 1, // TIMER_ABSTIME
	}

	// ── openat / unlinkat dirfd / at-flags ────────────────────────────────────

	private enum AtDirfd : int
	{
		FDCWD = -100, // AT_FDCWD: use the process CWD
	}

	[Flags]
	private enum AtFlags : int
	{
		RemoveDir = 0x200, // AT_REMOVEDIR
		SymlinkNoFollow = 0x100, // AT_SYMLINK_NOFOLLOW
	}

	// ── arch_prctl codes ──────────────────────────────────────────────────────

	private enum ArchPrctlCode : long
	{
		ARCH_SET_GS = 0x1001,
		ARCH_SET_FS = 0x1002,
		ARCH_GET_FS = 0x1003,
		ARCH_GET_GS = 0x1004,
		ARCH_GET_CPUID = 0x1011,
		ARCH_SET_CPUID = 0x1012,
	}

	// ── pipe2 flags ───────────────────────────────────────────────────────────

	[Flags]
	private enum PipeFlags : int
	{
		None = 0,
		O_CLOEXEC = 0x80000,
		O_NONBLOCK = 0x800,
		O_DIRECT = 0x4000,
	}

	// ── rlimit resource IDs ───────────────────────────────────────────────────

	private enum RlimitResource : int
	{
		RLIMIT_CPU = 0,
		RLIMIT_FSIZE = 1,
		RLIMIT_DATA = 2,
		RLIMIT_STACK = 3,
		RLIMIT_CORE = 4,
		RLIMIT_NOFILE = 7,
		RLIMIT_NPROC = 6,
		RLIMIT_AS = 9,
	}

	// ── statx mask / dirent type ──────────────────────────────────────────────

	[Flags]
	private enum StatxMask : uint
	{
		Type = 0x0001,
		Mode = 0x0002,
		Nlink = 0x0004,
		Uid = 0x0008,
		Gid = 0x0010,
		Atime = 0x0020,
		Mtime = 0x0040,
		Ctime = 0x0080,
		Ino = 0x0100,
		Size = 0x0200,
		Blocks = 0x0400,
		BasicStats = 0x07FF,
		Btime = 0x0800,
		MntId = 0x1000,
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
		Sock = 12,
	}

	// ── Syscall-related structs ───────────────────────────────────────────────

	// struct timespec { time_t tv_sec; long tv_nsec; } — 16 bytes on x86-64
	[StructLayout(LayoutKind.Sequential)]
	private struct TimespecStruct
	{
		public long TvSec;
		public long TvNsec;

		public static TimespecStruct FromUtc(DateTime utc)
		{
			long ms = new DateTimeOffset(utc).ToUnixTimeMilliseconds();
			return new TimespecStruct { TvSec = ms / 1_000L, TvNsec = (ms % 1_000L) * 1_000_000L };
		}

		public static TimespecStruct FromStopwatch() =>
			FromNanos((long)(Stopwatch.GetTimestamp() * (1_000_000_000.0 / Stopwatch.Frequency)));

		public static TimespecStruct FromNanos(long ns) =>
			new() { TvSec = ns / 1_000_000_000L, TvNsec = ns % 1_000_000_000L };

		public long ToMilliseconds() => TvSec * 1_000L + TvNsec / 1_000_000L;
	}

	// struct stat (Linux x86-64, 144 bytes)
	[StructLayout(LayoutKind.Explicit, Size = 144)]
	private struct StatStructX64
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

		// [36] __pad0 (4 bytes) — implicit via Explicit layout
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
		// [120..143] __unused[3] — implicit
	}

	// struct iovec { void* iov_base; size_t iov_len; } — 16 bytes on x86-64
	[StructLayout(LayoutKind.Sequential)]
	private struct IovecStruct
	{
		public nint IovBase;
		public nuint IovLen;
	}

	// struct winsize (TIOCGWINSZ) — 8 bytes
	[StructLayout(LayoutKind.Sequential)]
	private struct WinsizeStruct
	{
		public ushort WsRow;
		public ushort WsCol;
		public ushort WsXpixel;
		public ushort WsYpixel;
	}

	// struct utsname — 6 × 65-byte fixed char fields = 390 bytes
	[StructLayout(LayoutKind.Sequential)]
	private unsafe struct UnameStruct
	{
		public fixed byte Sysname[65];
		public fixed byte Nodename[65];
		public fixed byte Release[65];
		public fixed byte Version[65];
		public fixed byte Machine[65];
		public fixed byte Domainname[65];
	}

	// llvm-libc StartArgs written to the new thread stack before SYS_clone.
	// Layout used by libc/src/__support/threads/linux/thread.cpp.
	[StructLayout(LayoutKind.Sequential)]
	private struct ThreadStartArgs
	{
		public nint FnPtr; // void (*thread_runner)(void*)
		public nint ArgPtr; // void *runner_arg
	}

	// struct timeval { long tv_sec; long tv_usec; } — 16 bytes on x86-64
	[StructLayout(LayoutKind.Sequential)]
	private struct TimevalStruct
	{
		public long TvSec;
		public long TvUsec; // microseconds
	}

	// struct statx_timestamp — 16 bytes
	[StructLayout(LayoutKind.Sequential)]
	private struct StatxTimestampStruct
	{
		public long TvSec;
		public uint TvNsec;
		public int Reserved;
	}

	// struct statx — 256 bytes (linux/stat.h)
	[StructLayout(LayoutKind.Explicit, Size = 256)]
	private struct StatxStruct
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

		// [30] __spare0[2]
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
		// [152..255] spare
	}

	// Fixed-size header of struct linux_dirent64 (d_name flexible array follows)
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct LinuxDirent64Header
	{
		public ulong DIno; // 8 bytes
		public long DOff; // 8 bytes
		public ushort DReclen; // 2 bytes
		public DirentType DType; // 1 byte  → total 19 bytes, d_name starts at +19
	}

	// struct rlimit64 — 16 bytes
	[StructLayout(LayoutKind.Sequential)]
	private struct Rlimit64Struct
	{
		public ulong RlimCur; // soft limit
		public ulong RlimMax; // hard limit
	}

	// ── Helper types ──────────────────────────────────────────────────────────

	private sealed class FutexWaiter
	{
		public readonly object Lock = new();
		public int WaiterCount;
	}

	// Represents an open directory file descriptor (can't use FileStream for dirs).
	private sealed class DirectoryFd
	{
		public readonly string Path;
		public string[]? Entries; // lazily populated on first getdents64
		public int Position; // index into Entries

		public DirectoryFd(string path) => Path = path;
	}

	// ── Constants ─────────────────────────────────────────────────────────────

	private const uint DefaultUid = 1000;
	private const uint DefaultGid = 1000;

	// ── State ─────────────────────────────────────────────────────────────────

	private static readonly ConcurrentDictionary<nint, FutexWaiter> _futexWaiters = new();
	private static readonly ConcurrentDictionary<nint, nuint> _mmapAllocations = new();
	private static readonly ConcurrentDictionary<int, DirectoryFd> _directoryFds = new();

	[ThreadStatic]
	private static int* _tidAddress;

	// ── Entry point 1: syscall dispatcher ────────────────────────────────────

	[MangledName("__dotnet_syscall")]
	public static long DotnetSyscall(
		long n,
		long a1,
		long a2,
		long a3,
		long a4,
		long a5,
		long a6
	) =>
		(SyscallNumber)n switch
		{
			// ── I/O ──────────────────────────────────────────────────────────
			SyscallNumber.Read => SysRead((int)a1, (void*)a2, a3),
			SyscallNumber.Write => SysWrite((int)a1, (void*)a2, a3),
			SyscallNumber.Open => SysOpenPath((byte*)a1, (PosixOpenFlags)a2, (uint)a3),
			SyscallNumber.Close => (long)SysClose((int)a1),
			SyscallNumber.Lseek => SysLseek((int)a1, a2, (PosixSeekWhence)a3),
			SyscallNumber.Readv => SysReadv((int)a1, (IovecStruct*)a2, (int)a3),
			SyscallNumber.Writev => SysWritev((int)a1, (IovecStruct*)a2, (int)a3),
			SyscallNumber.Pread64 => SysPread64((int)a1, (void*)a2, a3, a4),
			SyscallNumber.Pwrite64 => SysPwrite64((int)a1, (void*)a2, a3, a4),
			SyscallNumber.Sendfile => SysSendfile((int)a1, (int)a2, (long*)a3, a4),
			SyscallNumber.CopyFileRange => SysCopyFileRange(
				(int)a1,
				(long*)a2,
				(int)a3,
				(long*)a4,
				a5
			),
			SyscallNumber.Fcntl => SysFcntl((int)a1, (FcntlCommand)a2, a3),
			SyscallNumber.Ioctl => (long)SysIoctl((int)a1, (IoctlRequest)a2, (void*)a3),
			SyscallNumber.Getdents64 => SysGetdents64((int)a1, (byte*)a2, (int)a3),

			// ── fd management ────────────────────────────────────────────────
			SyscallNumber.Dup => SysDup((int)a1),
			SyscallNumber.Dup2 => SysDup2((int)a1, (int)a2),
			SyscallNumber.Dup3 => SysDup2((int)a1, (int)a2), // flags ignored
			SyscallNumber.Pipe => SysPipe2((int*)a1, PipeFlags.None),
			SyscallNumber.Pipe2 => SysPipe2((int*)a1, (PipeFlags)a2),

			// ── stat ─────────────────────────────────────────────────────────
			SyscallNumber.Stat => (long)SysStat((byte*)a1, (StatStructX64*)a2),
			SyscallNumber.Fstat => (long)SysFstat((int)a1, (StatStructX64*)a2),
			SyscallNumber.Lstat => (long)SysStat((byte*)a1, (StatStructX64*)a2),
			SyscallNumber.Newfstatat => (long)SysNewfstatat(
				(int)a1,
				(byte*)a2,
				(StatStructX64*)a3,
				(int)a4
			),
			SyscallNumber.Statx => (long)SysStatx(
				(int)a1,
				(byte*)a2,
				(int)a3,
				(StatxMask)a4,
				(StatxStruct*)a5
			),

			// ── memory ───────────────────────────────────────────────────────
			SyscallNumber.Mmap => SysMmap(
				(nuint)a1,
				(nuint)a2,
				(MmapProtection)a3,
				(MmapFlags)a4,
				(int)a5,
				a6
			),
			SyscallNumber.Mprotect => 0,
			SyscallNumber.Munmap => (long)SysMunmap((nint)a1),
			SyscallNumber.Brk => 0,
			SyscallNumber.Madvise => 0,

			// ── filesystem ───────────────────────────────────────────────────
			SyscallNumber.Access => (long)SysAccess((byte*)a1, (PosixAccessMode)a2),
			SyscallNumber.Openat => SysOpenat((int)a1, (byte*)a2, (PosixOpenFlags)a3, (uint)a4),
			SyscallNumber.Mkdirat => (long)SysMkdirat((int)a1, (byte*)a2, (uint)a3),
			SyscallNumber.Mkdir => (long)SysMkdir((byte*)a1, (uint)a2),
			SyscallNumber.Rmdir => (long)SysRmdir((byte*)a1),
			SyscallNumber.Unlink => (long)SysUnlink((byte*)a1),
			SyscallNumber.Unlinkat => (long)SysUnlinkat((int)a1, (byte*)a2, (AtFlags)a3),
			SyscallNumber.Rename => (long)SysRename((byte*)a1, (byte*)a2),
			SyscallNumber.Renameat => (long)SysRename((byte*)a2, (byte*)a4),
			SyscallNumber.Getcwd => SysGetcwd((byte*)a1, (nuint)a2),
			SyscallNumber.Chdir => (long)SysChdir((byte*)a1),
			SyscallNumber.Readlink => SysReadlinkat((int)AtDirfd.FDCWD, (byte*)a1, (byte*)a2, a3),
			SyscallNumber.Readlinkat => SysReadlinkat((int)a1, (byte*)a2, (byte*)a3, a4),
			SyscallNumber.Symlinkat => (long)SysSymlinkat((byte*)a1, (int)a2, (byte*)a3),
			SyscallNumber.Ftruncate => (long)SysFtruncate((int)a1, a2),
			SyscallNumber.Fsync => (long)SysFsync((int)a1),
			SyscallNumber.Fdatasync => (long)SysFsync((int)a1),
			SyscallNumber.Fchmod => (long)LinuxErrno.Success, // permissions are not meaningful here

			// ── time ─────────────────────────────────────────────────────────
			SyscallNumber.Nanosleep => (long)SysNanosleep((TimespecStruct*)a1, (TimespecStruct*)a2),
			SyscallNumber.Gettimeofday => (long)SysGettimeofday((TimevalStruct*)a1),
			SyscallNumber.ClockGettime => (long)SysClockGettime((ClockId)a1, (TimespecStruct*)a2),
			SyscallNumber.ClockGetres => (long)SysClockGetres((ClockId)a1, (TimespecStruct*)a2),
			SyscallNumber.ClockNanosleep => (long)SysClockNanosleep(
				(ClockId)a1,
				(TimerFlags)a2,
				(TimespecStruct*)a3,
				(TimespecStruct*)a4
			),

			// ── process / thread ─────────────────────────────────────────────
			SyscallNumber.Getpid => Environment.ProcessId,
			SyscallNumber.Getppid => Environment.ProcessId, // no parent concept, return self
			SyscallNumber.Getuid => DefaultUid,
			SyscallNumber.Getgid => DefaultGid,
			SyscallNumber.Gettid => Environment.CurrentManagedThreadId,
			SyscallNumber.SchedYield => SysSchedYield(),
			SyscallNumber.Clone => SysClone(
				(CloneFlags)a1,
				(ThreadStartArgs*)a2,
				(int*)a3,
				(int*)a4,
				(void*)a5
			),
			SyscallNumber.Exit => SysExit((int)a1),
			SyscallNumber.ExitGroup => SysExit((int)a1),
			SyscallNumber.Kill => 0, // signal delivery: no-op
			SyscallNumber.Tgkill => 0, // signal delivery: no-op
			SyscallNumber.Wait4 => (long)LinuxErrno.ECHILD,
			SyscallNumber.Waitid => (long)LinuxErrno.ECHILD,
			SyscallNumber.SetTidAddress => SysSetTidAddress((int*)a1),
			SyscallNumber.SetRobustList => 0,
			SyscallNumber.ArchPrctl => SysArchPrctl((ArchPrctlCode)a1, a2),
			SyscallNumber.Prlimit64 => (long)SysPrlimit64(
				(int)a1,
				(RlimitResource)a2,
				(Rlimit64Struct*)a3,
				(Rlimit64Struct*)a4
			),

			// ── signals / process control ─────────────────────────────────────────
			SyscallNumber.RtSigaction => 0, // stub
			SyscallNumber.RtSigprocmask => 0, // stub
			SyscallNumber.Prctl => 0, // thread names etc. — cosmetic
			SyscallNumber.Select => 0,
			SyscallNumber.Poll => 0,
			SyscallNumber.Pselect6 => 0,

			// ── misc ─────────────────────────────────────────────────────────
			SyscallNumber.Futex => SysFutex(
				(int*)a1,
				(FutexOperation)a2,
				(int)a3,
				(TimespecStruct*)a4,
				(int*)a5,
				(int)a6
			),
			SyscallNumber.Uname => (long)SysUname((UnameStruct*)a1),
			SyscallNumber.Getrandom => SysGetrandom((byte*)a1, (nuint)a2),
			SyscallNumber.Rseq => 0,

			// ── networking (stub: return EAFNOSUPPORT) ────────────────────────
			SyscallNumber.Socket
			or SyscallNumber.Connect
			or SyscallNumber.Accept
			or SyscallNumber.Accept4
			or SyscallNumber.SendTo
			or SyscallNumber.RecvFrom
			or SyscallNumber.SendMsg
			or SyscallNumber.RecvMsg
			or SyscallNumber.Shutdown
			or SyscallNumber.Bind
			or SyscallNumber.Listen
			or SyscallNumber.Getsockname
			or SyscallNumber.Getpeername
			or SyscallNumber.Setsockopt
			or SyscallNumber.Getsockopt => (long)LinuxErrno.EAFNOSUPPORT,

			_ => (long)LinuxErrno.ENOSYS,
		};

	// ── Entry point 2: thread creation (patch path in thread.cpp) ────────────

	[MangledName("__dotnet_clone")]
	public static long DotnetClone(
		long flags,
		void* newStack,
		int* parentTid,
		int* childTid,
		void* tls,
		delegate* <void*, void> fn, // start_thread_with_args(void*)
		void* arg // StartArgs*
	)
	{
		if (fn == null)
			return (long)LinuxErrno.EINVAL;
		return StartManagedThread((nint)fn, (nint)arg, parentTid, childTid);
	}

	// ── SYS_clone: reads StartArgs from the stack pointer ────────────────────

	private static long SysClone(
		CloneFlags flags,
		ThreadStartArgs* startArgs,
		int* parentTid,
		int* childTid,
		void* tls
	)
	{
		if (startArgs == null)
			return (long)LinuxErrno.EINVAL;
		return StartManagedThread(startArgs->FnPtr, startArgs->ArgPtr, parentTid, childTid);
	}

	private static long StartManagedThread(nint fnPtr, nint argPtr, int* parentTid, int* childTid)
	{
		Thread t = new Thread(() =>
		{
			int myTid = Thread.CurrentThread.ManagedThreadId;
			if (childTid != null)
				Volatile.Write(ref *childTid, myTid);
			if (_tidAddress != null)
				Volatile.Write(ref *_tidAddress, myTid);
			((delegate* <void*, void>)fnPtr)((void*)argPtr);
		})
		{
			IsBackground = true,
		};

		if (parentTid != null)
			Volatile.Write(ref *parentTid, t.ManagedThreadId);

		t.Start();
		return t.ManagedThreadId;
	}

	// ── I/O ───────────────────────────────────────────────────────────────────

	private static long SysRead(int fd, void* buf, long count)
	{
		if (buf == null || count < 0)
			return (long)LinuxErrno.EINVAL;
		if (count == 0)
			return 0;
		Stream? stream =
			fd == 0 ? Console.OpenStandardInput()
			: _fileDescriptors.TryGetValue(fd, out Stream? s) ? s
			: null;
		if (stream == null)
			return (long)LinuxErrno.EBADF;
		try
		{
			return stream.Read(new Span<byte>(buf, (int)count));
		}
		catch
		{
			return (long)LinuxErrno.EIO;
		}
	}

	private static long SysWrite(int fd, void* buf, long count)
	{
		if (buf == null || count < 0)
			return (long)LinuxErrno.EINVAL;
		if (count == 0)
			return 0;
		Stream? stream =
			fd == 1 ? Console.OpenStandardOutput()
			: fd == 2 ? Console.OpenStandardError()
			: _fileDescriptors.TryGetValue(fd, out Stream? s) ? s
			: null;
		if (stream == null)
			return (long)LinuxErrno.EBADF;
		try
		{
			stream.Write(new ReadOnlySpan<byte>(buf, (int)count));
			return count;
		}
		catch
		{
			return (long)LinuxErrno.EIO;
		}
	}

	private static long SysReadv(int fd, IovecStruct* iov, int iovcnt)
	{
		long total = 0;
		for (int i = 0; i < iovcnt; i++)
		{
			long r = SysRead(fd, (void*)iov[i].IovBase, (long)iov[i].IovLen);
			if (r < 0)
				return total > 0 ? total : r;
			total += r;
			if ((nuint)r < iov[i].IovLen)
				break;
		}
		return total;
	}

	private static long SysWritev(int fd, IovecStruct* iov, int iovcnt)
	{
		long total = 0;
		for (int i = 0; i < iovcnt; i++)
		{
			long w = SysWrite(fd, (void*)iov[i].IovBase, (long)iov[i].IovLen);
			if (w < 0)
				return total > 0 ? total : w;
			total += w;
		}
		return total;
	}

	// ── open / close / lseek ──────────────────────────────────────────────────

	private static long SysOpenPath(byte* pathname, PosixOpenFlags flags, uint mode)
	{
		if (pathname == null)
			return (long)LinuxErrno.EFAULT;
		return OpenPath(Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty, flags, mode);
	}

	private static long SysOpenat(int dirfd, byte* pathname, PosixOpenFlags flags, uint mode)
	{
		if (pathname == null)
			return (long)LinuxErrno.EFAULT;
		string rel = Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty;
		string path =
			dirfd == (int)AtDirfd.FDCWD || Path.IsPathRooted(rel) ? rel
			: _fileDescriptors.TryGetValue(dirfd, out Stream? ds) && ds is FileStream fs
				? Path.Combine(Path.GetDirectoryName(fs.Name) ?? ".", rel)
			: rel;
		return OpenPath(path, flags, mode);
	}

	private static long OpenPath(string path, PosixOpenFlags flags, uint mode)
	{
		// Opening a directory returns a special directory fd.
		if (Directory.Exists(path))
		{
			int dfd = Interlocked.Increment(ref _nextFd);
			_directoryFds[dfd] = new DirectoryFd(path);
			return dfd;
		}

		PosixOpenFlags accessBits = flags & (PosixOpenFlags)3;
		FileAccess fileAccess = accessBits switch
		{
			PosixOpenFlags.O_WRONLY => FileAccess.Write,
			PosixOpenFlags.O_RDWR => FileAccess.ReadWrite,
			_ => FileAccess.Read,
		};

		bool creat = (flags & PosixOpenFlags.O_CREAT) != 0;
		bool excl = (flags & PosixOpenFlags.O_EXCL) != 0;
		bool trunc = (flags & PosixOpenFlags.O_TRUNC) != 0;
		bool append = (flags & PosixOpenFlags.O_APPEND) != 0;

		FileMode fileMode = (creat, excl, trunc, append) switch
		{
			(true, true, _, _) => FileMode.CreateNew,
			(true, _, true, _) => FileMode.Create,
			(true, _, _, _) => FileMode.OpenOrCreate,
			(_, _, true, _) => FileMode.Truncate,
			(_, _, _, true) => FileMode.Append,
			_ => FileMode.Open,
		};

		try
		{
			FileStream stream = new FileStream(path, fileMode, fileAccess, FileShare.ReadWrite);
			int fd = Interlocked.Increment(ref _nextFd);
			_fileDescriptors[fd] = stream;
			return fd;
		}
		catch (FileNotFoundException)
		{
			return (long)LinuxErrno.ENOENT;
		}
		catch (UnauthorizedAccessException)
		{
			return (long)LinuxErrno.EACCES;
		}
		catch (IOException e) when (e.HResult == unchecked((int)0x80070050))
		{
			return (long)LinuxErrno.EEXIST;
		}
		catch (IOException)
		{
			return (long)LinuxErrno.EIO;
		}
		catch
		{
			return (long)LinuxErrno.EIO;
		}
	}

	private static LinuxErrno SysClose(int fd)
	{
		if (fd < 3)
			return LinuxErrno.Success;
		if (_directoryFds.TryRemove(fd, out _))
			return LinuxErrno.Success;
		if (!_fileDescriptors.TryRemove(fd, out Stream? s))
			return LinuxErrno.EBADF;
		s.Dispose();
		return LinuxErrno.Success;
	}

	private static long SysLseek(int fd, long offset, PosixSeekWhence whence)
	{
		if (!_fileDescriptors.TryGetValue(fd, out Stream? s))
			return (long)LinuxErrno.EBADF;
		SeekOrigin origin = whence switch
		{
			PosixSeekWhence.SEEK_SET => SeekOrigin.Begin,
			PosixSeekWhence.SEEK_CUR => SeekOrigin.Current,
			PosixSeekWhence.SEEK_END => SeekOrigin.End,
			_ => SeekOrigin.Begin,
		};
		try
		{
			return s.Seek(offset, origin);
		}
		catch
		{
			return (long)LinuxErrno.ESPIPE;
		}
	}

	// ── stat ──────────────────────────────────────────────────────────────────

	private static LinuxErrno SysStat(byte* pathname, StatStructX64* statbuf)
	{
		if (pathname == null || statbuf == null)
			return LinuxErrno.EFAULT;
		return FillStatFromPath(statbuf, Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty);
	}

	private static LinuxErrno SysFstat(int fd, StatStructX64* statbuf)
	{
		if (statbuf == null)
			return LinuxErrno.EFAULT;
		if (fd is 0 or 1 or 2)
		{
			*statbuf = default;
			statbuf->StMode = StatMode.ChrDev;
			statbuf->StUid = DefaultUid;
			statbuf->StGid = DefaultGid;
			return LinuxErrno.Success;
		}
		if (_directoryFds.TryGetValue(fd, out DirectoryFd? dfd))
			return FillStatFromPath(statbuf, dfd.Path);
		if (!_fileDescriptors.TryGetValue(fd, out Stream? s) || s is not FileStream fs)
			return LinuxErrno.EBADF;
		return FillStatFromPath(statbuf, fs.Name);
	}

	private static LinuxErrno SysNewfstatat(
		int dirfd,
		byte* pathname,
		StatStructX64* statbuf,
		int atFlags
	)
	{
		if (pathname == null || statbuf == null)
			return LinuxErrno.EFAULT;
		return FillStatFromPath(statbuf, Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty);
	}

	private static LinuxErrno FillStatFromPath(StatStructX64* buf, string path)
	{
		*buf = default;
		try
		{
			bool isDir = Directory.Exists(path);
			bool isFile = !isDir && File.Exists(path);
			if (!isDir && !isFile)
				return LinuxErrno.ENOENT;

			buf->StUid = DefaultUid;
			buf->StGid = DefaultGid;
			buf->StBlksize = 4096;

			if (isFile)
			{
				FileInfo fi = new FileInfo(path);
				buf->StMode = StatMode.RegFile644;
				buf->StNlink = 1;
				buf->StSize = fi.Length;
				buf->StBlocks = (fi.Length + 511) / 512;
				buf->StAtim = TimespecStruct.FromUtc(fi.LastAccessTimeUtc);
				buf->StMtim = TimespecStruct.FromUtc(fi.LastWriteTimeUtc);
				buf->StCtim = TimespecStruct.FromUtc(fi.CreationTimeUtc);
			}
			else
			{
				DirectoryInfo di = new DirectoryInfo(path);
				buf->StMode = StatMode.Dir755;
				buf->StNlink = 2;
				buf->StAtim = TimespecStruct.FromUtc(di.LastAccessTimeUtc);
				buf->StMtim = TimespecStruct.FromUtc(di.LastWriteTimeUtc);
				buf->StCtim = TimespecStruct.FromUtc(di.CreationTimeUtc);
			}
			return LinuxErrno.Success;
		}
		catch
		{
			return LinuxErrno.EIO;
		}
	}

	// ── mmap / munmap ─────────────────────────────────────────────────────────

	private static long SysMmap(
		nuint hint,
		nuint length,
		MmapProtection prot,
		MmapFlags flags,
		int fd,
		long offset
	)
	{
		if (length == 0)
			return (long)LinuxErrno.EINVAL;

		if ((flags & MmapFlags.Anonymous) != 0)
		{
			void* ptr = NativeMemoryHelper.Allocate((long)length);
			_mmapAllocations[(nint)ptr] = length;
			return (long)(nint)ptr;
		}

		if (!_fileDescriptors.TryGetValue(fd, out Stream? s))
			return (long)LinuxErrno.EBADF;
		try
		{
			void* ptr = NativeMemoryHelper.Allocate((long)length);
			_mmapAllocations[(nint)ptr] = length;
			s.Seek(offset, SeekOrigin.Begin);
			s.ReadExactly(new Span<byte>(ptr, (int)length));
			return (long)(nint)ptr;
		}
		catch
		{
			return (long)LinuxErrno.EIO;
		}
	}

	private static LinuxErrno SysMunmap(nint addr)
	{
		if (_mmapAllocations.TryRemove(addr, out _))
			NativeMemoryHelper.Free((void*)addr);
		return LinuxErrno.Success;
	}

	// ── futex ─────────────────────────────────────────────────────────────────

	private static long SysFutex(
		int* addr,
		FutexOperation op,
		int val,
		TimespecStruct* timeout,
		int* addr2,
		int val3
	)
	{
		FutexOperation baseOp = op & ~(FutexOperation.PrivateFlag | FutexOperation.ClockFlag);
		return baseOp switch
		{
			FutexOperation.Wait or FutexOperation.WaitBitset => (long)FutexWait(addr, val, timeout),
			FutexOperation.Wake or FutexOperation.WakeBitset => FutexWake(addr, val),
			FutexOperation.Requeue => FutexWake(addr, val),
			_ => 0,
		};
	}

	private static LinuxErrno FutexWait(int* addr, int expected, TimespecStruct* timeoutRelNs)
	{
		FutexWaiter waiter = _futexWaiters.GetOrAdd((nint)addr, static _ => new FutexWaiter());
		lock (waiter.Lock)
		{
			if (Volatile.Read(ref *addr) != expected)
				return LinuxErrno.EAGAIN;

			int ms =
				timeoutRelNs != null
					? (int)Math.Max(0L, timeoutRelNs->ToMilliseconds())
					: Timeout.Infinite;

			waiter.WaiterCount++;
			bool signaled = Monitor.Wait(waiter.Lock, ms);
			waiter.WaiterCount--;
			return signaled ? LinuxErrno.Success : LinuxErrno.ETIMEDOUT;
		}
	}

	private static long FutexWake(int* addr, int count)
	{
		if (!_futexWaiters.TryGetValue((nint)addr, out FutexWaiter? waiter))
			return 0;
		lock (waiter.Lock)
		{
			int woken = Math.Min(count, waiter.WaiterCount);
			if (count == 1)
				Monitor.Pulse(waiter.Lock);
			else
				Monitor.PulseAll(waiter.Lock);
			return woken;
		}
	}

	// ── clock / time ──────────────────────────────────────────��───────────────

	private static LinuxErrno SysClockGettime(ClockId clockId, TimespecStruct* tp)
	{
		if (tp == null)
			return LinuxErrno.EINVAL;
		*tp =
			clockId == ClockId.Realtime
				? TimespecStruct.FromUtc(DateTime.UtcNow)
				: TimespecStruct.FromStopwatch();
		return LinuxErrno.Success;
	}

	private static LinuxErrno SysClockGetres(ClockId clockId, TimespecStruct* res)
	{
		if (res != null)
			*res = new TimespecStruct { TvSec = 0, TvNsec = 1 };
		return LinuxErrno.Success;
	}

	private static LinuxErrno SysClockNanosleep(
		ClockId clockId,
		TimerFlags flags,
		TimespecStruct* req,
		TimespecStruct* rem
	)
	{
		if (req == null)
			return LinuxErrno.EINVAL;
		long nsRelative =
			(flags & TimerFlags.AbsoluteTime) != 0
				? Math.Max(
					0L,
					req->TvSec * 1_000_000_000L
						+ req->TvNsec
						- TimespecStruct.FromStopwatch().TvSec * 1_000_000_000L
				)
				: req->TvSec * 1_000_000_000L + req->TvNsec;
		if (nsRelative > 0)
			Thread.Sleep((int)Math.Max(1L, nsRelative / 1_000_000L));
		if (rem != null)
			*rem = default;
		return LinuxErrno.Success;
	}

	private static LinuxErrno SysNanosleep(TimespecStruct* req, TimespecStruct* rem)
	{
		if (req == null)
			return LinuxErrno.EINVAL;
		long ns = req->TvSec * 1_000_000_000L + req->TvNsec;
		if (ns > 0)
			Thread.Sleep((int)Math.Max(1L, ns / 1_000_000L));
		if (rem != null)
			*rem = default;
		return LinuxErrno.Success;
	}

	// gettimeofday fills struct timeval { long tv_sec; long tv_usec; }
	private static LinuxErrno SysGettimeofday(TimevalStruct* tv)
	{
		if (tv == null)
			return LinuxErrno.EINVAL;
		long us = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() * 1000L;
		tv->TvSec = us / 1_000_000L;
		tv->TvUsec = us % 1_000_000L;
		return LinuxErrno.Success;
	}

	// ── filesystem helpers ────────────────────────────────────────────────────

	private static LinuxErrno SysMkdir(byte* pathname, uint mode)
	{
		if (pathname == null)
			return LinuxErrno.EFAULT;
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

	private static LinuxErrno SysRmdir(byte* pathname)
	{
		if (pathname == null)
			return LinuxErrno.EFAULT;
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

	private static LinuxErrno SysUnlink(byte* pathname)
	{
		if (pathname == null)
			return LinuxErrno.EFAULT;
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

	private static LinuxErrno SysUnlinkat(int dirfd, byte* pathname, AtFlags atFlags) =>
		(atFlags & AtFlags.RemoveDir) != 0 ? SysRmdir(pathname) : SysUnlink(pathname);

	private static LinuxErrno SysRename(byte* oldp, byte* newp)
	{
		if (oldp == null || newp == null)
			return LinuxErrno.EFAULT;
		string o = Marshal.PtrToStringUTF8((nint)oldp) ?? string.Empty;
		string n = Marshal.PtrToStringUTF8((nint)newp) ?? string.Empty;
		try
		{
			File.Move(o, n, overwrite: true);
			return LinuxErrno.Success;
		}
		catch
		{
			return LinuxErrno.EIO;
		}
	}

	private static long SysGetcwd(byte* buf, nuint size)
	{
		if (buf == null || size == 0)
			return (long)LinuxErrno.EINVAL;
		byte[] bytes = Encoding.UTF8.GetBytes(Directory.GetCurrentDirectory());
		if ((nuint)(bytes.Length + 1) > size)
			return (long)LinuxErrno.ERANGE;
		bytes.AsSpan().CopyTo(new Span<byte>(buf, (int)size));
		buf[bytes.Length] = 0;
		return (long)(nint)buf;
	}

	private static LinuxErrno SysChdir(byte* pathname)
	{
		if (pathname == null)
			return LinuxErrno.EFAULT;
		string path = Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty;
		try
		{
			Directory.SetCurrentDirectory(path);
			return LinuxErrno.Success;
		}
		catch
		{
			return LinuxErrno.ENOENT;
		}
	}

	private static LinuxErrno SysAccess(byte* pathname, PosixAccessMode mode)
	{
		if (pathname == null)
			return LinuxErrno.EFAULT;
		string path = Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty;
		try
		{
			if (!File.Exists(path) && !Directory.Exists(path))
				return LinuxErrno.ENOENT;
			if (
				(mode & PosixAccessMode.W_OK) != 0
				&& File.Exists(path)
				&& new FileInfo(path).IsReadOnly
			)
				return LinuxErrno.EACCES;
			return LinuxErrno.Success;
		}
		catch
		{
			return LinuxErrno.EIO;
		}
	}

	// ── misc ──────────────────────────────────────────────────────────────────

	private static long SysGetrandom(byte* buf, nuint count)
	{
		if (buf == null)
			return (long)LinuxErrno.EFAULT;
		RandomNumberGenerator.Fill(new Span<byte>(buf, (int)count));
		return (long)count;
	}

	private static LinuxErrno SysUname(UnameStruct* buf)
	{
		if (buf == null)
			return LinuxErrno.EFAULT;
		*buf = default;
		WriteFixedField(buf->Sysname, "Linux");
		WriteFixedField(buf->Nodename, "dotnet-host");
		WriteFixedField(buf->Release, "6.1.0");
		WriteFixedField(buf->Version, "#1 SMP");
		WriteFixedField(buf->Machine, "x86_64");
		WriteFixedField(buf->Domainname, "");
		return LinuxErrno.Success;
	}

	private static unsafe void WriteFixedField(byte* dest, string s)
	{
		byte[] b = Encoding.UTF8.GetBytes(s);
		b.AsSpan().CopyTo(new Span<byte>(dest, b.Length + 1));
	}

	private static LinuxErrno SysIoctl(int fd, IoctlRequest request, void* arg)
	{
		if (request == IoctlRequest.TIOCGWINSZ && arg != null)
			*(WinsizeStruct*)arg = new WinsizeStruct { WsRow = 24, WsCol = 80 };
		return LinuxErrno.Success;
	}

	private static long SysFcntl(int fd, FcntlCommand cmd, long arg)
	{
		switch (cmd)
		{
			case FcntlCommand.F_DUPFD:
			case FcntlCommand.F_DUPFD_CLOEXEC:
				return SysDup(fd); // minimal: ignore min-fd hint and CLOEXEC
			case FcntlCommand.F_GETFD:
				return 0; // no close-on-exec flag tracked
			case FcntlCommand.F_SETFD:
				return 0; // CLOEXEC flag ignored in managed environment
			case FcntlCommand.F_GETFL:
				// Return sensible flags based on what kind of fd it is
				if (!_fileDescriptors.TryGetValue(fd, out Stream? s))
					return (long)PosixOpenFlags.O_RDWR;
				return s.CanWrite && s.CanRead ? (long)PosixOpenFlags.O_RDWR
					: s.CanWrite ? (long)PosixOpenFlags.O_WRONLY
					: (long)PosixOpenFlags.O_RDONLY;
			case FcntlCommand.F_SETFL:
				return 0; // O_NONBLOCK etc. not meaningful for managed streams
			default:
				return (long)LinuxErrno.EINVAL;
		}
	}

	private static long SysSetTidAddress(int* tidPtr)
	{
		_tidAddress = tidPtr;
		return Thread.CurrentThread.ManagedThreadId;
	}

	private static long SysExit(int code)
	{
		Environment.Exit(code);
		return 0;
	}

	// ── arch_prctl ────────────────────────────────────────────────────────────
	// TLS is managed by the .NET runtime via [ThreadStatic]; we can no-op all
	// FS/GS segment manipulation since we never execute raw x86-64 assembly.

	private static long SysArchPrctl(ArchPrctlCode code, long addr) =>
		code switch
		{
			ArchPrctlCode.ARCH_SET_FS or ArchPrctlCode.ARCH_SET_GS => 0, // no-op
			ArchPrctlCode.ARCH_GET_FS or ArchPrctlCode.ARCH_GET_GS => addr != 0
				? (*(long*)addr = 0, 0L).Item2
				: 0,
			_ => (long)LinuxErrno.EINVAL,
		};

	// ── sched_yield ───────────────────────────────────────────────────────────

	private static long SysSchedYield()
	{
		Thread.Yield();
		return 0;
	}

	// ── dup / dup2 / pipe2 ────────────────────────────────────────────────────

	private static long SysDup(int oldfd)
	{
		if (_directoryFds.TryGetValue(oldfd, out DirectoryFd? dfd))
		{
			int newDirFd = Interlocked.Increment(ref _nextFd);
			_directoryFds[newDirFd] = new DirectoryFd(dfd.Path);
			return newDirFd;
		}

		Stream? s = oldfd switch
		{
			0 => Console.OpenStandardInput(),
			1 => Console.OpenStandardOutput(),
			2 => Console.OpenStandardError(),
			_ => _fileDescriptors.TryGetValue(oldfd, out Stream? v) ? v : null,
		};
		if (s == null)
			return (long)LinuxErrno.EBADF;
		int newFd = Interlocked.Increment(ref _nextFd);
		_fileDescriptors[newFd] = s; // share the same stream object
		return newFd;
	}

	private static long SysDup2(int oldfd, int newfd)
	{
		if (oldfd == newfd)
			return newfd;
		// Close newfd if already open
		SysClose(newfd);

		if (_directoryFds.TryGetValue(oldfd, out DirectoryFd? dfd))
		{
			_directoryFds[newfd] = new DirectoryFd(dfd.Path);
			return newfd;
		}

		Stream? s = oldfd switch
		{
			0 => Console.OpenStandardInput(),
			1 => Console.OpenStandardOutput(),
			2 => Console.OpenStandardError(),
			_ => _fileDescriptors.TryGetValue(oldfd, out Stream? v) ? v : null,
		};
		if (s == null)
			return (long)LinuxErrno.EBADF;
		_fileDescriptors[newfd] = s;
		return newfd;
	}

	private static long SysPipe2(int* fds, PipeFlags flags)
	{
		if (fds == null)
			return (long)LinuxErrno.EFAULT;
		var server = new System.IO.Pipes.AnonymousPipeServerStream(
			System.IO.Pipes.PipeDirection.Out,
			System.IO.HandleInheritability.None
		);
		var client = new System.IO.Pipes.AnonymousPipeClientStream(
			System.IO.Pipes.PipeDirection.In,
			server.ClientSafePipeHandle
		);
		int readFd = Interlocked.Increment(ref _nextFd);
		int writeFd = Interlocked.Increment(ref _nextFd);
		_fileDescriptors[readFd] = client;
		_fileDescriptors[writeFd] = server;
		fds[0] = readFd;
		fds[1] = writeFd;
		return 0;
	}

	// ── pread64 / pwrite64 ────────────────────────────────────────────────────

	private static long SysPread64(int fd, void* buf, long count, long offset)
	{
		if (buf == null || count < 0)
			return (long)LinuxErrno.EINVAL;
		if (!_fileDescriptors.TryGetValue(fd, out Stream? s))
			return (long)LinuxErrno.EBADF;
		long saved = s.CanSeek ? s.Position : -1;
		try
		{
			if (s.CanSeek)
				s.Position = offset;
			return s.Read(new Span<byte>(buf, (int)count));
		}
		catch
		{
			return (long)LinuxErrno.EIO;
		}
		finally
		{
			if (saved >= 0 && s.CanSeek)
				s.Position = saved;
		}
	}

	private static long SysPwrite64(int fd, void* buf, long count, long offset)
	{
		if (buf == null || count < 0)
			return (long)LinuxErrno.EINVAL;
		if (!_fileDescriptors.TryGetValue(fd, out Stream? s))
			return (long)LinuxErrno.EBADF;
		long saved = s.CanSeek ? s.Position : -1;
		try
		{
			if (s.CanSeek)
				s.Position = offset;
			s.Write(new ReadOnlySpan<byte>(buf, (int)count));
			return count;
		}
		catch
		{
			return (long)LinuxErrno.EIO;
		}
		finally
		{
			if (saved >= 0 && s.CanSeek)
				s.Position = saved;
		}
	}

	// ── sendfile / copy_file_range ────────────────────────────────────────────

	private static long SysSendfile(int outFd, int inFd, long* offset, long count)
	{
		if (!_fileDescriptors.TryGetValue(inFd, out Stream? src))
			return (long)LinuxErrno.EBADF;
		if (!_fileDescriptors.TryGetValue(outFd, out Stream? dst))
			return (long)LinuxErrno.EBADF;
		try
		{
			if (offset != null && src.CanSeek)
				src.Position = *offset;
			byte[] buf = new byte[(int)Math.Min(count, 65536)];
			long total = 0;
			while (total < count)
			{
				int toRead = (int)Math.Min(buf.Length, count - total);
				int read = src.Read(buf, 0, toRead);
				if (read == 0)
					break;
				dst.Write(buf, 0, read);
				total += read;
			}
			if (offset != null)
				*offset += total;
			return total;
		}
		catch
		{
			return (long)LinuxErrno.EIO;
		}
	}

	private static long SysCopyFileRange(
		int fdIn,
		long* offIn,
		int fdOut,
		long* offOut,
		long len
	) => SysSendfile(fdOut, fdIn, offIn, len);

	// ── ftruncate / fsync ─────────────────────────────────────────────────────

	private static LinuxErrno SysFtruncate(int fd, long length)
	{
		if (!_fileDescriptors.TryGetValue(fd, out Stream? s))
			return LinuxErrno.EBADF;
		try
		{
			s.SetLength(length);
			return LinuxErrno.Success;
		}
		catch
		{
			return LinuxErrno.EIO;
		}
	}

	private static LinuxErrno SysFsync(int fd)
	{
		if (_fileDescriptors.TryGetValue(fd, out Stream? s))
		{
			try
			{
				s.Flush();
			}
			catch
			{ /* best effort */
			}
		}
		return LinuxErrno.Success;
	}

	// ── getdents64 ───────────────────────────────────────────────────────────

	private static long SysGetdents64(int fd, byte* dirp, int count)
	{
		if (!_directoryFds.TryGetValue(fd, out DirectoryFd? dfd))
			return (long)LinuxErrno.ENOTDIR;
		if (dirp == null || count < 0)
			return (long)LinuxErrno.EINVAL;

		// Lazy-populate entries (include "." and ".." as per POSIX)
		if (dfd.Entries == null)
		{
			string[] children = Directory.GetFileSystemEntries(dfd.Path);
			dfd.Entries = new string[children.Length + 2];
			dfd.Entries[0] = dfd.Path; // "."
			dfd.Entries[1] = Path.GetDirectoryName(dfd.Path) ?? dfd.Path; // ".."
			children.CopyTo(dfd.Entries, 2);
		}

		string[] entries = dfd.Entries;
		int written = 0;
		int headerSize = sizeof(LinuxDirent64Header); // 19 bytes (Pack=1)

		while (dfd.Position < entries.Length)
		{
			string entryPath = entries[dfd.Position];
			string name =
				dfd.Position == 0 ? "."
				: dfd.Position == 1 ? ".."
				: Path.GetFileName(entryPath);
			byte[] nameBytes = Encoding.UTF8.GetBytes(name);
			int reclen = (headerSize + nameBytes.Length + 1 + 7) & ~7; // align 8

			if (written + reclen > count)
				break;

			DirentType dtype =
				Directory.Exists(entryPath) ? DirentType.Dir
				: File.Exists(entryPath) ? DirentType.Reg
				: DirentType.Unknown;

			LinuxDirent64Header* hdr = (LinuxDirent64Header*)(dirp + written);
			hdr->DIno = (ulong)Math.Abs(entryPath.GetHashCode(StringComparison.Ordinal));
			hdr->DOff = dfd.Position + 1;
			hdr->DReclen = (ushort)reclen;
			hdr->DType = dtype;

			byte* nameDst = (byte*)hdr + headerSize;
			nameBytes.AsSpan().CopyTo(new Span<byte>(nameDst, nameBytes.Length + 1));
			nameDst[nameBytes.Length] = 0;

			// Zero tail padding
			for (byte* p = nameDst + nameBytes.Length + 1; p < (byte*)hdr + reclen; p++)
				*p = 0;

			written += reclen;
			dfd.Position++;
		}

		return written; // 0 == end of directory
	}

	// ── readlinkat / symlinkat ────────────────────────────────────────────────

	private static long SysReadlinkat(int dirfd, byte* pathname, byte* buf, long bufsiz)
	{
		if (pathname == null || buf == null || bufsiz <= 0)
			return (long)LinuxErrno.EINVAL;
		string path = Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty;

		// Special /proc/self paths
		string? resolved = path switch
		{
			"/proc/self/exe" => Environment.ProcessPath,
			"/proc/self/cwd" => Directory.GetCurrentDirectory(),
			"/proc/self" => $"/proc/{Environment.ProcessId}",
			_ => null,
		};

		if (resolved == null)
		{
			// Try to resolve as a real symlink on the host
			try
			{
				FileSystemInfo? info = File.ResolveLinkTarget(path, returnFinalTarget: false);
				resolved = info?.FullName;
			}
			catch
			{ /* not a symlink or doesn't exist */
			}
		}

		if (resolved == null)
			return (long)LinuxErrno.ENOENT;

		byte[] bytes = Encoding.UTF8.GetBytes(resolved);
		int len = (int)Math.Min(bytes.Length, bufsiz);
		new Span<byte>(bytes, 0, len).CopyTo(new Span<byte>(buf, len));
		return len; // readlink does NOT add a null terminator
	}

	private static LinuxErrno SysSymlinkat(byte* target, int newdirfd, byte* linkpathname)
	{
		if (target == null || linkpathname == null)
			return LinuxErrno.EFAULT;
		string tgt = Marshal.PtrToStringUTF8((nint)target) ?? string.Empty;
		string link = Marshal.PtrToStringUTF8((nint)linkpathname) ?? string.Empty;
		try
		{
			File.CreateSymbolicLink(link, tgt);
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

	// ── statx ─────────────────────────────────────────────────────────────────

	private static LinuxErrno SysStatx(
		int dirfd,
		byte* pathname,
		int flags,
		StatxMask mask,
		StatxStruct* statxbuf
	)
	{
		if (pathname == null || statxbuf == null)
			return LinuxErrno.EFAULT;
		string path = Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty;
		if (string.IsNullOrEmpty(path) && dirfd >= 0)
		{
			// AT_EMPTY_PATH — stat the fd itself
			StatStructX64 tmp = default;
			LinuxErrno err = SysFstat(dirfd, &tmp);
			if (err != LinuxErrno.Success)
				return err;
			FillStatxFromStat(statxbuf, &tmp, mask);
			return LinuxErrno.Success;
		}

		// Resolve relative paths against dirfd (simplified)
		if (!Path.IsPathRooted(path) && dirfd != (int)AtDirfd.FDCWD)
		{
			if (_directoryFds.TryGetValue(dirfd, out DirectoryFd? dfd))
				path = Path.Combine(dfd.Path, path);
		}

		StatStructX64 stat = default;
		LinuxErrno result = FillStatFromPath(&stat, path);
		if (result != LinuxErrno.Success)
			return result;
		FillStatxFromStat(statxbuf, &stat, mask);
		return LinuxErrno.Success;
	}

	private static void FillStatxFromStat(StatxStruct* sx, StatStructX64* s, StatxMask mask)
	{
		*sx = default;
		sx->Mask = mask & StatxMask.BasicStats;
		sx->Blksize = 4096;
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
			TvNsec = (uint)s->StAtim.TvNsec,
		};
		sx->Mtime = new StatxTimestampStruct
		{
			TvSec = s->StMtim.TvSec,
			TvNsec = (uint)s->StMtim.TvNsec,
		};
		sx->Ctime = new StatxTimestampStruct
		{
			TvSec = s->StCtim.TvSec,
			TvNsec = (uint)s->StCtim.TvNsec,
		};
	}

	// ── mkdirat (proper dirfd resolution) ────────────────────────────────────

	private static LinuxErrno SysMkdirat(int dirfd, byte* pathname, uint mode)
	{
		if (pathname == null)
			return LinuxErrno.EFAULT;
		string rel = Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty;
		string path =
			dirfd == (int)AtDirfd.FDCWD || Path.IsPathRooted(rel) ? rel
			: _directoryFds.TryGetValue(dirfd, out DirectoryFd? dfd) ? Path.Combine(dfd.Path, rel)
			: rel;
		return SysMkdir(path, mode);
	}

	// overload accepting a managed string for SysMkdirat
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

	// ── prlimit64 ─────────────────────────────────────────────────────────────

	private static LinuxErrno SysPrlimit64(
		int pid,
		RlimitResource resource,
		Rlimit64Struct* newLimit,
		Rlimit64Struct* oldLimit
	)
	{
		if (oldLimit != null)
		{
			(oldLimit->RlimCur, oldLimit->RlimMax) = resource switch
			{
				RlimitResource.RLIMIT_STACK => (8 * 1024 * 1024UL, ulong.MaxValue),
				RlimitResource.RLIMIT_NOFILE => (1024UL, 4096UL),
				RlimitResource.RLIMIT_AS => (ulong.MaxValue, ulong.MaxValue),
				_ => (ulong.MaxValue, ulong.MaxValue),
			};
		}
		return LinuxErrno.Success; // new limits silently accepted
	}
}
#pragma warning restore IDE0060 // Remove unused parameter
