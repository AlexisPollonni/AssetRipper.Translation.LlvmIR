using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Attributes;

namespace AssetRipper.Translation.LlvmIR;

#pragma warning disable IDE0060 // Remove unused parameter
internal static unsafe partial class IntrinsicFunctions
{
	// ── POSIX File System API ───────────────────────────────────────────────
	//
	// Maps standard POSIX file descriptors to .NET Stream objects.
	// 0, 1, and 2 are conventionally reserved for stdin, stdout, and stderr.
	// We start dynamically assigned descriptors at 3.

	private static readonly ConcurrentDictionary<int, Stream> _fileDescriptors = new();
	private static int _nextFd = 3;

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

	[MangledName("open")]
	public static int Open(byte* pathname, PosixOpenFlags flags, int mode)
	{
		if (pathname == null)
			return -1; // EFAULT

		string path = Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty;

		FileMode fileMode = FileMode.Open;
		FileAccess fileAccess = FileAccess.Read;

		PosixOpenFlags accessMode = flags & (PosixOpenFlags)3;

		if (accessMode == PosixOpenFlags.O_RDONLY)
			fileAccess = FileAccess.Read;
		else if (accessMode == PosixOpenFlags.O_WRONLY)
			fileAccess = FileAccess.Write;
		else if (accessMode == PosixOpenFlags.O_RDWR)
			fileAccess = FileAccess.ReadWrite;

		bool creat = (flags & PosixOpenFlags.O_CREAT) != 0;
		bool trunc = (flags & PosixOpenFlags.O_TRUNC) != 0;
		bool excl = (flags & PosixOpenFlags.O_EXCL) != 0;
		bool append = (flags & PosixOpenFlags.O_APPEND) != 0;

		if (creat)
		{
			if (excl)
				fileMode = FileMode.CreateNew;
			else if (trunc)
				fileMode = FileMode.Create;
			else
				fileMode = FileMode.OpenOrCreate;
		}
		else if (trunc)
		{
			fileMode = FileMode.Truncate;
		}
		else if (append)
		{
			fileMode = FileMode.Append;
		}

		try
		{
			FileStream stream = new FileStream(path, fileMode, fileAccess, FileShare.ReadWrite);
			int fd = Interlocked.Increment(ref _nextFd);
			_fileDescriptors[fd] = stream;
			return fd;
		}
		catch (Exception)
		{
			return -1;
		}
	}

	[MangledName("close")]
	public static int Close(int fd)
	{
		if (fd < 3)
			return 0; // Ignore standard streams

		if (_fileDescriptors.TryRemove(fd, out Stream? stream))
		{
			stream.Dispose();
			return 0;
		}
		return -1; // EBADF
	}

	[MangledName("read")]
	public static long Read(int fd, void* buf, long count)
	{
		if (buf == null || count < 0)
			return -1;
		if (count == 0)
			return 0;

		Stream? stream;
		if (fd == 0)
			stream = Console.OpenStandardInput();
		else if (!_fileDescriptors.TryGetValue(fd, out stream))
			return -1;

		try
		{
			Span<byte> span = new Span<byte>(buf, (int)count);
			return stream.Read(span);
		}
		catch (Exception)
		{
			return -1;
		}
	}

	[MangledName("write")]
	public static long Write(int fd, void* buf, long count)
	{
		if (buf == null || count < 0)
			return -1;
		if (count == 0)
			return 0;

		Stream? stream;
		if (fd == 1)
			stream = Console.OpenStandardOutput();
		else if (fd == 2)
			stream = Console.OpenStandardError();
		else if (!_fileDescriptors.TryGetValue(fd, out stream))
			return -1;

		try
		{
			ReadOnlySpan<byte> span = new ReadOnlySpan<byte>(buf, (int)count);
			stream.Write(span);
			return count;
		}
		catch (Exception)
		{
			return -1;
		}
	}

	[MangledName("lseek")]
	public static long Lseek(int fd, long offset, PosixSeekWhence whence)
	{
		if (!_fileDescriptors.TryGetValue(fd, out Stream? stream))
			return -1;

		SeekOrigin origin = whence switch
		{
			PosixSeekWhence.SEEK_SET => SeekOrigin.Begin,
			PosixSeekWhence.SEEK_CUR => SeekOrigin.Current,
			PosixSeekWhence.SEEK_END => SeekOrigin.End,
			_ => SeekOrigin.Begin,
		};

		try
		{
			return stream.Seek(offset, origin);
		}
		catch (Exception)
		{
			return -1;
		}
	}

	[Flags]
	public enum PosixAccessMode
	{
		F_OK = 0,
		X_OK = 1,
		W_OK = 2,
		R_OK = 4,
	}

	[MangledName("access")]
	public static int Access(byte* pathname, PosixAccessMode mode)
	{
		if (pathname == null)
			return -1;
		string path = Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty;

		try
		{
			bool isFile = File.Exists(path);
			bool isDir = Directory.Exists(path);

			if (!isFile && !isDir)
				return -1;

			if (mode == PosixAccessMode.F_OK)
				return 0;

			// We have limited actual permission checking in standard .NET APIs.
			// Simple fallback check mostly handles R_OK and W_OK for read-only files.
			if ((mode & PosixAccessMode.W_OK) != 0)
			{
				if (isFile && new FileInfo(path).IsReadOnly)
					return -1; // EACCES
			}

			return 0;
		}
		catch
		{
			return -1;
		}
	}

	[MangledName("unlink")]
	public static int Unlink(byte* pathname)
	{
		if (pathname == null)
			return -1;
		string path = Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty;

		try
		{
			File.Delete(path);
			return 0;
		}
		catch
		{
			return -1;
		}
	}

	[MangledName("mkdir")]
	public static int Mkdir(byte* pathname, uint mode)
	{
		if (pathname == null)
			return -1;
		string path = Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty;

		try
		{
			Directory.CreateDirectory(path);
			return 0;
		}
		catch
		{
			return -1;
		}
	}

	[MangledName("rmdir")]
	public static int Rmdir(byte* pathname)
	{
		if (pathname == null)
			return -1;
		string path = Marshal.PtrToStringUTF8((nint)pathname) ?? string.Empty;

		try
		{
			Directory.Delete(path);
			return 0;
		}
		catch
		{
			return -1;
		}
	}

	[MangledName("rename")]
	public static int Rename(byte* oldpath, byte* newpath)
	{
		if (oldpath == null || newpath == null)
			return -1;
		string oldP = Marshal.PtrToStringUTF8((nint)oldpath) ?? string.Empty;
		string newP = Marshal.PtrToStringUTF8((nint)newpath) ?? string.Empty;

		try
		{
			File.Move(oldP, newP);
			return 0;
		}
		catch
		{
			return -1;
		}
	}
}
#pragma warning restore IDE0060 // Remove unused parameter
