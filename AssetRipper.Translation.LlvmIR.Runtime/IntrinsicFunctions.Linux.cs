using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace AssetRipper.Translation.LlvmIR.Runtime;

#pragma warning disable IDE0060 // Remove unused parameter
public static unsafe partial class IntrinsicFunctions
{
	// ── Linux / glibc intrinsics ──────────────────────────────────────────────

	// ── Formatted I/O ────────────────────────────────────────────────────────

	[MangledName("printf")]
	public static int printf(byte* format, ReadOnlySpan<nint> args)
	{
		string? result = FormatPrintf(format, args);
		if (result is null)
			return -1;
		Console.Write(result);
		return result.Length;
	}

	[MangledName("fprintf")]
	public static int fprintf(void* stream, byte* format, ReadOnlySpan<nint> args)
	{
		string? result = FormatPrintf(format, args);
		if (result is null)
			return -1;
		if (stream == StandardOutput)
			Console.Write(result);
		else if (stream == StandardError)
			Console.Error.Write(result);
		else
			return -1;
		return result.Length;
	}

	[MangledName("sprintf")]
	public static int sprintf(byte* buffer, byte* format, ReadOnlySpan<nint> args)
	{
		string? result = FormatPrintf(format, args);
		if (result is null || buffer is null)
			return -1;
		byte[] encoded = System.Text.Encoding.UTF8.GetBytes(result);
		new Span<byte>(encoded).CopyTo(new Span<byte>(buffer, encoded.Length));
		buffer[encoded.Length] = 0;
		return encoded.Length;
	}

	[MangledName("snprintf")]
	public static int snprintf(byte* buffer, long size, byte* format, ReadOnlySpan<nint> args)
	{
		string? result = FormatPrintf(format, args);
		if (result is null)
			return -1;
		if (buffer is null || size <= 0)
			return result.Length; // snprintf with null buffer returns needed length
		byte[] encoded = System.Text.Encoding.UTF8.GetBytes(result);
		long copyLen = Math.Min(encoded.Length, size - 1);
		encoded.AsSpan(0, (int)copyLen).CopyTo(new Span<byte>(buffer, (int)size));
		buffer[copyLen] = 0;
		return encoded.Length; // snprintf returns the number of chars that would have been written
	}

	[MangledName("vprintf")]
	public static int vprintf(byte* format, void* ap)
	{
		// ap is a va_list (pointer to args array)
		ReadOnlySpan<nint> args = new((nint*)ap, 64);
		string? result = FormatPrintf(format, args);
		if (result is null)
			return -1;
		Console.Write(result);
		return result.Length;
	}

	[MangledName("vfprintf")]
	public static int vfprintf(void* stream, byte* format, void* ap)
	{
		ReadOnlySpan<nint> args = new((nint*)ap, 64);
		string? result = FormatPrintf(format, args);
		if (result is null)
			return -1;
		if (stream == StandardOutput)
			Console.Write(result);
		else if (stream == StandardError)
			Console.Error.Write(result);
		else
			return -1;
		return result.Length;
	}

	[MangledName("vsprintf")]
	public static int vsprintf(byte* buffer, byte* format, void* ap)
	{
		ReadOnlySpan<nint> args = new((nint*)ap, 64);
		string? result = FormatPrintf(format, args);
		if (result is null || buffer is null)
			return -1;
		byte[] encoded = System.Text.Encoding.UTF8.GetBytes(result);
		new Span<byte>(encoded).CopyTo(new Span<byte>(buffer, encoded.Length));
		buffer[encoded.Length] = 0;
		return encoded.Length;
	}

	[MangledName("vsnprintf")]
	public static int vsnprintf(byte* buffer, long size, byte* format, void* ap)
	{
		ReadOnlySpan<nint> args = new((nint*)ap, 64);
		string? result = FormatPrintf(format, args);
		if (result is null)
			return -1;
		if (buffer is null || size <= 0)
			return result.Length;
		byte[] encoded = System.Text.Encoding.UTF8.GetBytes(result);
		long copyLen = Math.Min(encoded.Length, size - 1);
		encoded.AsSpan(0, (int)copyLen).CopyTo(new Span<byte>(buffer, (int)size));
		buffer[copyLen] = 0;
		return encoded.Length;
	}

	// ── POSIX stdio unlocked variants ────────────────────────────────────────
	// The "unlocked" variants skip per-stream mutex acquisition.  In our managed
	// environment there is no native FILE* mutex to skip, so these simply delegate
	// to the same logic as their locked counterparts.

	/// <summary>
	/// Returns non-zero if the error indicator for <paramref name="file"/> is set.
	/// Our stream model does not track error flags, so this always returns 0.
	/// </summary>
	[MangledName("ferror_unlocked")]
	public static int ferror_unlocked(void* file) => 0;

	/// <summary>
	/// Acquires the internal lock of the given <paramref name="file"/> stream.
	/// No-op in managed code; .NET stream types are already thread-safe.
	/// </summary>
	[MangledName("flockfile")]
	public static void flockfile(
		void* file
	) { /* no-op */
	}

	/// <summary>
	/// Releases the internal lock of the given <paramref name="file"/> stream.
	/// No-op in managed code; counterpart to <see cref="flockfile"/>.
	/// </summary>
	[MangledName("funlockfile")]
	public static void funlockfile(
		void* file
	) { /* no-op */
	}

	/// <summary>
	/// Writes <paramref name="count"/> elements of <paramref name="size"/> bytes
	/// each from <paramref name="buf"/> to <paramref name="file"/>, without
	/// acquiring the per-stream lock.  Returns the number of elements written.
	/// </summary>
	[MangledName("fwrite_unlocked")]
	public static long fwrite_unlocked(void* buf, long size, long count, void* file)
	{
		if (buf == null || size <= 0 || count <= 0)
			return 0;
		long totalBytes = size * count;
		var bytes = new ReadOnlySpan<byte>((byte*)buf, (int)totalBytes);
		if (file == StandardOutput)
			Console.Write(System.Text.Encoding.UTF8.GetString(bytes));
		else if (file == StandardError)
			Console.Error.Write(System.Text.Encoding.UTF8.GetString(bytes));
		else
			return 0;
		return count;
	}

	// ── Linux real-time signal range ─────────────────────────────────────────
	// On Linux with NPTL, glibc/musl reserve RT signals 32 and 33 for internal
	// use, so the first signal available to applications is 34 and the last is 64.

	/// <summary>
	/// Returns the lowest available real-time signal number (POSIX SIGRTMIN).
	/// On Linux with NPTL this is 34 (glibc/libc reserve 32–33 for pthreads).
	/// </summary>
	[MangledName("__libc_current_sigrtmin")]
	public static int LibcCurrentSigRtMin() => 34;

	/// <summary>
	/// Returns the highest available real-time signal number (POSIX SIGRTMAX).
	/// On Linux this is 64 (_NSIG - 1).
	/// </summary>
	[MangledName("__libc_current_sigrtmax")]
	public static int LibcCurrentSigRtMax() => 64;

	// ── Termination ──────────────────────────────────────────────────────────

	[DoesNotReturn]
	[MangledName("abort")]
	public static void Abort() => throw new FatalException(nameof(Abort));

	[DoesNotReturn]
	[MangledName("_exit")]
	[MangledName("_Exit")]
	[MangledName("quick_exit")]
	public static void ExitNoCleanup(int exitCode) => Environment.Exit(exitCode);

	// ── Assertions ───────────────────────────────────────────────────────────

	[MangledName("__assert_fail")]
	[MightThrow]
	public static void AssertFail(byte* assertion, byte* file, uint line, byte* function)
	{
		// https://man7.org/linux/man-pages/man3/assert.3.html
		string msg =
			$"Assertion `{Marshal.PtrToStringUTF8((IntPtr)assertion)}' failed: "
			+ $"{Marshal.PtrToStringUTF8((IntPtr)file)}:{line}: "
			+ $"{Marshal.PtrToStringUTF8((IntPtr)function)}";
		ExceptionInfo.Current = new AssertExceptionInfo(msg);
	}

	[MangledName("__assert_perror_fail")]
	[MightThrow]
	public static void AssertPerrorFail(int errnum, byte* file, uint line, byte* function)
	{
		string msg =
			$"Assertion failed (errno={errnum}): {Marshal.PtrToStringUTF8((IntPtr)file)}:{line}: {Marshal.PtrToStringUTF8((IntPtr)function)}";
		ExceptionInfo.Current = new AssertExceptionInfo(msg);
	}

	// ── errno ─────────────────────────────────────────────────────────────────

	[ThreadStatic]
	private static int* _errnoPtr;

	[MangledName("__errno_location")]
	public static int* ErrnoLocation()
	{
		// Returns a pointer to the thread-local errno variable.
		if (_errnoPtr == null)
			_errnoPtr = (int*)NativeMemoryHelper.Allocate(sizeof(int));
		return _errnoPtr;
	}

	// ── strerror ──────────────────────────────────────────────────────────────

	// Small static buffer for strerror; not thread-safe (matches legacy C behavior).
	private static byte* _strerrorBuf;

	[MangledName("strerror")]
	public static byte* Strerror(int errnum)
	{
		string msg = errnum == 0 ? "Success" : $"Error {errnum}";
		byte[] bytes = System.Text.Encoding.UTF8.GetBytes(msg + "\0");
		if (_strerrorBuf == null)
			_strerrorBuf = (byte*)NativeMemoryHelper.Allocate(256);
		int len = Math.Min(bytes.Length, 255);
		new Span<byte>(bytes, 0, len).CopyTo(new Span<byte>(_strerrorBuf, 256));
		_strerrorBuf[len] = 0;
		return _strerrorBuf;
	}

	[MangledName("strerror_r")]
	public static int StrerrorR(int errnum, byte* buf, long buflen)
	{
		if (buf == null || buflen <= 0)
			return -1;
		string msg = errnum == 0 ? "Success" : $"Error {errnum}";
		byte[] bytes = System.Text.Encoding.UTF8.GetBytes(msg + "\0");
		int len = (int)Math.Min(bytes.Length, buflen - 1);
		new Span<byte>(bytes, 0, len).CopyTo(new Span<byte>(buf, (int)buflen));
		buf[len] = 0;
		return 0;
	}

	// ── Environment ──────────────────────────────────────────────────────────

	// Cache of environment variable byte strings to keep them alive.
	private static readonly ConcurrentDictionary<string, nint> _envCache = new();

	[MangledName("getenv")]
	public static byte* Getenv(byte* name)
	{
		if (name == null)
			return null;
		string? key = Marshal.PtrToStringUTF8((IntPtr)name);
		if (key == null)
			return null;
		string? value = Environment.GetEnvironmentVariable(key);
		if (value == null)
			return null;
		nint ptr = _envCache.GetOrAdd(
			value,
			static v =>
			{
				byte[] bytes = System.Text.Encoding.UTF8.GetBytes(v + "\0");
				byte* buf = (byte*)NativeMemoryHelper.Allocate(bytes.Length);
				new Span<byte>(bytes).CopyTo(new Span<byte>(buf, bytes.Length));
				return (nint)buf;
			}
		);
		return (byte*)ptr;
	}

	// ── Stack protection ─────────────────────────────────────────────────────

	[DoesNotReturn]
	[MangledName("__stack_chk_fail")]
	public static void StackChkFail() =>
		throw new FatalException("Stack smashing detected (__stack_chk_fail)");

	// ── Memory ───────────────────────────────────────────────────────────────

	[MangledName("malloc_usable_size")]
	public static long MallocUsableSize(void* ptr) =>
		ptr == null ? 0 : NativeMemoryHelper.Size(ptr);

	[MangledName("posix_memalign")]
	public static int PosixMemalign(void** memptr, long alignment, long size)
	{
		if (memptr == null)
			return 22; // EINVAL
		*memptr = NativeMemoryHelper.Allocate(size);
		return 0;
	}

	// ── Itanium C++ ABI – operator new / delete ───────────────────────────────

	[MangledName("_Znwm")] // operator new(size_t)
	[MangledName("_ZnwmRKSt9nothrow_t")] // operator new(size_t, nothrow_t const&)
	public static void* CxxNew(long size) => NativeMemoryHelper.Allocate(size);

	[MangledName("_Znam")] // operator new[](size_t)
	[MangledName("_ZnamRKSt9nothrow_t")] // operator new[](size_t, nothrow_t const&)
	public static void* CxxNewArray(long size) => NativeMemoryHelper.Allocate(size);

	[MangledName("_ZnwmSt11align_val_t")]
	public static void* CxxNewAligned(long size, long alignment) =>
		NativeMemoryHelper.Allocate(size);

	[MangledName("_ZnamSt11align_val_t")]
	public static void* CxxNewArrayAligned(long size, long alignment) =>
		NativeMemoryHelper.Allocate(size);

	[MangledName("_ZdlPv")] // operator delete(void*)
	[MangledName("_ZdlPvRKSt9nothrow_t")] // operator delete(void*, nothrow_t const&)
	public static void CxxDelete(void* ptr) => NativeMemoryHelper.Free(ptr);

	[MangledName("_ZdaPv")] // operator delete[](void*)
	[MangledName("_ZdaPvRKSt9nothrow_t")] // operator delete[](void*, nothrow_t const&)
	public static void CxxDeleteArray(void* ptr) => NativeMemoryHelper.Free(ptr);

	[MangledName("_ZdlPvm")] // operator delete(void*, size_t)
	[MangledName("_ZdlPvSt11align_val_t")] // operator delete(void*, align_val_t)
	public static void CxxDeleteSized(void* ptr, long sizeOrAlignment) =>
		NativeMemoryHelper.Free(ptr);

	[MangledName("_ZdaPvm")] // operator delete[](void*, size_t)
	[MangledName("_ZdaPvSt11align_val_t")] // operator delete[](void*, align_val_t)
	public static void CxxDeleteArraySized(void* ptr, long sizeOrAlignment) =>
		NativeMemoryHelper.Free(ptr);

	// ── Itanium C++ ABI – exception handling ─────────────────────────────────

	[MangledName("__cxa_allocate_exception")]
	public static void* CxaAllocateException(long thrownSize) =>
		NativeMemoryHelper.Allocate(thrownSize);

	[MangledName("__cxa_free_exception")]
	public static void CxaFreeException(void* thrownException) =>
		NativeMemoryHelper.Free(thrownException);

	[MangledName("__cxa_throw")]
	[MightThrow]
	public static void CxaThrow(
		void* thrownException,
		void* typeInfo,
		delegate* <void*, void> destructor
	)
	{
		// https://itanium-cxx-abi.github.io/cxx-abi/abi-eh.html#cxx-throw
		ExceptionInfo.Current = new ItaniumExceptionInfo(thrownException, typeInfo, destructor);
	}

	[MangledName("__cxa_rethrow")]
	[MightThrow]
	public static void CxaRethrow()
	{
		// Current ExceptionInfo.Current is already set; re-propagation is handled by the caller.
	}

	[MangledName("__cxa_begin_catch")]
	public static void* CxaBeginCatch(void* exceptionObject)
	{
		// Returns a pointer to the caught exception object.
		if (ExceptionInfo.Current is ItaniumExceptionInfo itanium)
			return itanium.ExceptionPointer;
		return exceptionObject;
	}

	[MangledName("__cxa_end_catch")]
	public static void CxaEndCatch()
	{
		// Exception handling is finished; resources will be freed when ExceptionInfo is disposed.
	}

	[MangledName("__cxa_pure_virtual")]
	[DoesNotReturn]
	public static void CxaPureVirtual() => throw new FatalException("Pure virtual function called");

	[MangledName("__cxa_bad_cast")]
	[DoesNotReturn]
	public static void CxaBadCast() => throw new FatalException("Bad dynamic_cast");

	[MangledName("__cxa_bad_typeid")]
	[DoesNotReturn]
	public static void CxaBadTypeid() => throw new FatalException("Null pointer in typeid");

	[MangledName("__gxx_personality_v0")]
	public static int GxxPersonalityV0(ReadOnlySpan<nint> args)
	{
		// The personality function is called by the unwinder; in our model exceptions are
		// tracked via ExceptionInfo.Current so this is a no-op stub.
		return 0;
	}

	// ── Itanium C++ ABI – static initialization guards ───────────────────────

	[MangledName("__cxa_guard_acquire")]
	public static int CxaGuardAcquire(long* guardObject)
	{
		// https://itanium-cxx-abi.github.io/cxx-abi/abi.html#object-ctor-dtor
		// Byte 0 of the guard: 1 = initialized, 0 = not yet.
		// Returns 1 if the caller should perform initialization, 0 if already done.
		byte* g = (byte*)guardObject;
		if (*g != 0)
			return 0; // already initialized
		// Use Interlocked on the full 64-bit word to achieve atomicity.
		long old = Interlocked.CompareExchange(ref *guardObject, 0x0100, 0);
		return old == 0 ? 1 : 0; // 1 => we won the race, caller must initialize
	}

	[MangledName("__cxa_guard_release")]
	public static void CxaGuardRelease(long* guardObject)
	{
		// Mark the guarded object as initialized (set byte 0 to 1).
		byte* g = (byte*)guardObject;
		*g = 1;
		// Full memory barrier so the initialized value is visible to other threads.
		Thread.MemoryBarrier();
	}

	[MangledName("__cxa_guard_abort")]
	public static void CxaGuardAbort(long* guardObject)
	{
		// Reset the guard so another thread can attempt initialization.
		Interlocked.Exchange(ref *guardObject, 0);
	}

	// ── __cxa_atexit (C++ module-level destructors) ───────────────────────────

	// Two parallel stacks for func/arg (avoid ValueTuple in generic parameter)
	private static readonly ConcurrentStack<nint> _cxaAtexitFuncs = new();
	private static readonly ConcurrentStack<nint> _cxaAtexitArgs = new();

	[MangledName("__cxa_atexit")]
	public static int CxaAtexit(delegate* <void*, void> func, void* arg, void* dsoHandle)
	{
		// https://itanium-cxx-abi.github.io/cxx-abi/abi.html#dso-dtor-runtime-api
		if (_cxaAtexitFuncs.IsEmpty)
		{
			lock (_cxaAtexitFuncs)
			{
				if (_cxaAtexitFuncs.IsEmpty)
				{
					AppDomain.CurrentDomain.ProcessExit += static (_, _) =>
					{
						while (
							_cxaAtexitFuncs.TryPop(out nint f) && _cxaAtexitArgs.TryPop(out nint a)
						)
							((delegate* <void*, void>)f)((void*)a);
					};
				}
			}
		}
		_cxaAtexitFuncs.Push((nint)func);
		_cxaAtexitArgs.Push((nint)arg);
		return 0;
	}

	[MangledName("__cxa_finalize")]
	public static void CxaFinalize(void* dsoHandle)
	{
		// Run all __cxa_atexit destructors (simplified: run all, ignore dso filtering).
		while (_cxaAtexitFuncs.TryPop(out nint f) && _cxaAtexitArgs.TryPop(out nint a))
			((delegate* <void*, void>)f)((void*)a);
	}

	// ── __libc_start_main ─────────────────────────────────────────────────────

	[MangledName("__libc_start_main")]
	public static int LibcStartMain(
		delegate* <int, byte**, byte**, int> main,
		int argc,
		byte** argv,
		delegate* <void> init,
		delegate* <void> fini,
		delegate* <void> rtldFini,
		void* stackEnd
	)
	{
		// Called by the CRT to start the program. We invoke main() directly.
		return main(argc, argv, null);
	}

	// ── Wide-character strings ────────────────────────────────────────────────

	[MangledName("wcscmp")]
	public static int wcscmp(char* s1, char* s2)
	{
		while (*s1 == *s2 && *s1 != '\0')
		{
			++s1;
			++s2;
		}
		return *s1 - *s2;
	}

	[MangledName("wcsncmp")]
	public static int wcsncmp(char* s1, char* s2, long count)
	{
		for (long i = 0; i < count; i++)
		{
			if (s1[i] != s2[i])
				return s1[i] - s2[i];
			if (s1[i] == 0)
				return 0;
		}
		return 0;
	}

	[MangledName("wcscpy")]
	public static char* wcscpy(char* dst, char* src)
	{
		if (dst == null || src == null)
			return dst;
		long len = wcslen(src);
		Buffer.MemoryCopy(src, dst, (len + 1) * sizeof(char), (len + 1) * sizeof(char));
		return dst;
	}

	[MangledName("wcsncpy")]
	public static char* wcsncpy(char* dst, char* src, long count)
	{
		if (dst == null || src == null)
			return dst;
		long i = 0;
		for (; i < count && src[i] != '\0'; i++)
			dst[i] = src[i];
		for (; i < count; i++)
			dst[i] = '\0';
		return dst;
	}

	[MangledName("wcscat")]
	public static char* wcscat(char* dst, char* src)
	{
		if (dst == null || src == null)
			return dst;
		long end = wcslen(dst);
		long srcLen = wcslen(src);
		Buffer.MemoryCopy(src, dst + end, (srcLen + 1) * sizeof(char), (srcLen + 1) * sizeof(char));
		return dst;
	}

	[MangledName("wcsncat")]
	public static char* wcsncat(char* dst, char* src, long count)
	{
		if (dst == null || src == null)
			return dst;
		long end = wcslen(dst);
		long i = 0;
		for (; i < count && src[i] != '\0'; i++)
			dst[end + i] = src[i];
		dst[end + i] = '\0';
		return dst;
	}

	[MangledName("wcschr")]
	public static char* wcschr(char* str, int c)
	{
		if (str == null)
			return null;
		char ch = (char)c;
		while (*str != '\0')
		{
			if (*str == ch)
				return str;
			str++;
		}
		return ch == '\0' ? str : null;
	}

	[MangledName("wcsrchr")]
	public static char* wcsrchr(char* str, int c)
	{
		if (str == null)
			return null;
		long len = wcslen(str);
		char ch = (char)c;
		for (long i = len - 1; i >= 0; i--)
			if (str[i] == ch)
				return str + i;
		return null;
	}

	[MangledName("wcsstr")]
	public static char* wcsstr(char* haystack, char* needle)
	{
		if (haystack == null || needle == null)
			return null;
		long hl = wcslen(haystack),
			nl = wcslen(needle);
		var hs = new ReadOnlySpan<char>(haystack, (int)hl);
		var nd = new ReadOnlySpan<char>(needle, (int)nl);
		int idx = hs.IndexOf(nd);
		return idx >= 0 ? haystack + idx : null;
	}

	[MangledName("wmemcpy")]
	public static char* wmemcpy(char* dst, char* src, long count)
	{
		Buffer.MemoryCopy(src, dst, count * sizeof(char), count * sizeof(char));
		return dst;
	}

	[MangledName("wmemmove")]
	public static char* wmemmove(char* dst, char* src, long count)
	{
		long bytes = count * sizeof(char);
		byte[] buf = new byte[bytes];
		new ReadOnlySpan<byte>(src, (int)bytes).CopyTo(buf);
		new Span<byte>(buf).CopyTo(new Span<byte>(dst, (int)bytes));
		return dst;
	}

	[MangledName("wmemset")]
	public static char* wmemset(char* dst, int c, long count)
	{
		char ch = (char)c;
		for (long i = 0; i < count; i++)
			dst[i] = ch;
		return dst;
	}

	[MangledName("wmemcmp")]
	public static int wmemcmp(char* s1, char* s2, long count)
	{
		for (long i = 0; i < count; i++)
			if (s1[i] != s2[i])
				return s1[i] - s2[i];
		return 0;
	}

	[MangledName("wmemchr")]
	public static char* wmemchr(char* s, int c, long count)
	{
		char ch = (char)c;
		for (long i = 0; i < count; i++)
			if (s[i] == ch)
				return s + i;
		return null;
	}

	// ── Wide character classification ─────────────────────────────────────────

	[MangledName("towlower")]
	public static int Towlower(int c) => char.ToLowerInvariant((char)c);

	[MangledName("towupper")]
	public static int Towupper(int c) => char.ToUpperInvariant((char)c);

	[MangledName("iswspace")]
	public static int Iswspace(int c) => IsWClass(c, char.IsWhiteSpace);

	[MangledName("iswalpha")]
	public static int Iswalpha(int c) => IsWClass(c, char.IsLetter);

	[MangledName("iswdigit")]
	public static int Iswdigit(int c) => IsWClass(c, char.IsAsciiDigit);

	[MangledName("iswalnum")]
	public static int Iswalnum(int c) => IsWClass(c, char.IsLetterOrDigit);

	[MangledName("iswupper")]
	public static int Iswupper(int c) => IsWClass(c, char.IsUpper);

	[MangledName("iswlower")]
	public static int Iswlower(int c) => IsWClass(c, char.IsLower);

	[MangledName("iswprint")]
	public static int Iswprint(int c) => IsWClass(c, static ch => !char.IsControl(ch));

	[MangledName("iswpunct")]
	public static int Iswpunct(int c) => IsWClass(c, char.IsPunctuation);

	[MangledName("iswcntrl")]
	public static int Iswcntrl(int c) => IsWClass(c, char.IsControl);

	[MangledName("iswblank")]
	public static int Iswblank(int c) => c == ' ' || c == '\t' ? 1 : 0;

	[MangledName("iswxdigit")]
	public static int Iswxdigit(int c) => IsWClass(c, char.IsAsciiHexDigit);

	[MangledName("iswgraph")]
	public static int Iswgraph(int c) => IsWClass(c, static ch => !char.IsControl(ch) && ch != ' ');

	private static int IsWClass(int c, Func<char, bool> pred)
	{
		unchecked
		{
			uint u = (uint)c;
			return u <= 0xFFFF && pred((char)u) ? 1 : 0;
		}
	}

	// ── Locale (stub) ─────────────────────────────────────────────────────────

	// Returned as a non-null sentinel so callers don't crash on null checks.
	private static byte* _cLocale;

	[MangledName("setlocale")]
	public static byte* Setlocale(int category, byte* locale)
	{
		// We always return "C" locale regardless of request.
		if (_cLocale == null)
		{
			_cLocale = (byte*)NativeMemoryHelper.Allocate(2);
			_cLocale[0] = (byte)'C';
			_cLocale[1] = 0;
		}
		return _cLocale;
	}

	// ── Itanium exception info ────────────────────────────────────────────────

	private sealed class ItaniumExceptionInfo : ExceptionInfo
	{
		public void* ExceptionPointer { get; private set; }
		public void* TypeInfo { get; private set; }
		private delegate* <void*, void> _destructor;

		public ItaniumExceptionInfo(
			void* exceptionPointer,
			void* typeInfo,
			delegate* <void*, void> destructor
		)
		{
			ExceptionPointer = exceptionPointer;
			TypeInfo = typeInfo;
			_destructor = destructor;
		}

		protected override void Dispose(bool disposing)
		{
			if (ExceptionPointer != null && _destructor != null)
				_destructor(ExceptionPointer);
			ExceptionPointer = null;
			TypeInfo = null;
			_destructor = null;
		}
	}
}
#pragma warning restore IDE0060 // Remove unused parameter
