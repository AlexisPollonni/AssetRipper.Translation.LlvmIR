using System.Collections.Concurrent;

namespace AssetRipper.Translation.LlvmIR.Runtime;

#pragma warning disable IDE0060 // Remove unused parameter
public static unsafe partial class IntrinsicFunctions
{
	// ── File-descriptor table ─────────────────────────────────────────────────
	// Shared between IntrinsicFunctions.Linux.Syscalls (syscall dispatcher) and
	// anything else that needs direct fd access.
	//
	// With the llvm-libc approach, POSIX functions like open/read/write/close are
	// implemented in llvm-libc's LLVM IR (compiled to CIL by the transpiler) and
	// ultimately call __dotnet_syscall.  These C# fields are the backing store for
	// the kernel-side implementations in IntrinsicFunctions.Linux.Syscalls.cs.

	private static readonly ConcurrentDictionary<int, Stream> _fileDescriptors = new();
	private static int _nextFd = 3; // 0/1/2 reserved for stdin/stdout/stderr

	// ── POSIX open flags (Linux x86-64 values) ────────────────────────────────

	[Flags]
	public enum PosixOpenFlags
	{
		O_RDONLY = 0x00,
		O_WRONLY = 0x01,
		O_RDWR = 0x02,
		O_CREAT = 0x40,
		O_EXCL = 0x80,
		O_TRUNC = 0x200,
		O_APPEND = 0x400,
	}

	public enum PosixSeekWhence
	{
		SEEK_SET = 0,
		SEEK_CUR = 1,
		SEEK_END = 2,
	}

	[Flags]
	public enum PosixAccessMode
	{
		F_OK = 0,
		X_OK = 1,
		W_OK = 2,
		R_OK = 4,
	}
}
#pragma warning restore IDE0060 // Remove unused parameter
