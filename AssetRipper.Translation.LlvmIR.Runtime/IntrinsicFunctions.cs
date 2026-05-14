using System.Buffers;
using System.Collections.Concurrent;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace AssetRipper.Translation.LlvmIR.Runtime;

#pragma warning disable IDE0060 // Remove unused parameter
public static unsafe partial class IntrinsicFunctions
{
	// ── LLVM meta-intrinsics ─────────────────────────────────────────────────

	[MangledName("llvm.experimental.noalias.scope.decl")]
	[MangledName("llvm.lifetime.start.p0")]
	[MangledName("llvm.lifetime.end.p0")]
	[MangledName("llvm.assume")]
	public static void DoNothing(object parameter) { }

	[MangledName("llvm.dbg.value")]
	[MangledName("llvm.dbg.declare")]
	[MangledName("llvm.dbg.label")]
	public static void DoNothingDebug(object p1, object p2, object p3) { }

	// ── x86-specific LLVM intrinsics ─────────────────────────────────────────
	// These have 3-part names (llvm.x86.xxx.yyy) so the regex-based
	// TryImplementNumericOperation path doesn't reach them; they need explicit
	// [MangledName] entries here.

	// llvm.x86.sse2.pause — emitted by __builtin_ia32_pause() in sleep.h
	[MangledName("llvm.x86.sse2.pause")]
	public static void Sse2Pause() => System.Threading.Thread.SpinWait(1);

	// llvm.x86.sse.stmxcsr — emitted by _mm_getcsr() in fenv_mxcsr_utils.h
	// Stores the MXCSR register value to memory. .NET's managed intrinsics API
	// covers only SIMD data operations — there is no API to read or write MXCSR
	// from managed code. We return the SSE2 power-on default (0x1F80: all FP
	// exceptions masked, round-to-nearest, no FTZ/DAZ), which matches the state
	// the .NET JIT sets at startup and is correct for virtually all libc callers.
	[MangledName("llvm.x86.sse.stmxcsr")]
	public static void SseStoreMxcsr(uint* mem)
	{
		if (mem != null)
			*mem = 0x1F80u;
	}

	// llvm.x86.sse.ldmxcsr — emitted by _mm_setcsr() in fenv_mxcsr_utils.h
	// Loads a value into MXCSR. Same limitation as above — no managed API to
	// set MXCSR, so this is a no-op. Changes to rounding mode / exception masks
	// requested by the libc fp-env functions will be silently ignored.
	[MangledName("llvm.x86.sse.ldmxcsr")]
	public static void SseLoadMxcsr(uint* mem) { }

	// ── Standard-stream sentinels (shared by both platform files) ────────────

	internal static void* StandardInput => (void*)1;
	internal static void* StandardOutput => (void*)2;
	internal static void* StandardError => (void*)3;

	// ── Termination ──────────────────────────────────────────────────────────
	// __std_terminate is Windows-only and lives in IntrinsicFunctions.Windows.cs

	[DoesNotReturn]
	[MangledName("terminate")]
	[MangledName("llvm.trap")]
	[MangledName("llvm.debugtrap")]
	public static void Terminate()
	{
		throw new FatalException(nameof(Terminate));
	}

	[DoesNotReturn]
	[MangledName("exit")]
	public static void Exit(int exitCode) => Environment.Exit(exitCode);

	// ── atexit ───────────────────────────────────────────────────────────────

	// Stack to hold atexit functions because they need to be called in LIFO order.
	private static readonly ConcurrentStack<nint> atexitFunctions = new();

	[MangledName("atexit")]
	public static int AtExit(delegate* <void> func)
	{
		// https://cplusplus.com/reference/cstdlib/atexit/
		if (atexitFunctions.IsEmpty)
		{
			lock (atexitFunctions)
			{
				if (atexitFunctions.IsEmpty)
				{
					AppDomain.CurrentDomain.ProcessExit += static (_, _) =>
					{
						while (atexitFunctions.TryPop(out nint function))
							((delegate* <void>)function)();
					};
				}
			}
		}
		atexitFunctions.Push((nint)func);
		return 0; // Success
	}

	// ── va_list helpers ───────────────────────────────────────────────────────

	[MangledName("llvm.va_start.p0")]
	public static void llvm_va_start(void** va_list)
	{
		// Handled elsewhere in the instruction lifter.
		throw new NotSupportedException();
	}

	[MangledName("llvm.va_copy.p0")]
	public static void llvm_va_copy(void** destination, void** source) => *destination = *source;

	[MangledName("llvm.va_end.p0")]
	public static void llvm_va_end(
		void** va_list
	) { /* freed automatically */
	}

	// ── Console I/O ──────────────────────────────────────────────────────────

	[MangledName("puts")]
	public static int PutString(sbyte* str)
	{
		// https://cplusplus.com/reference/cstdio/puts/
		try
		{
			string? s = Marshal.PtrToStringAnsi((IntPtr)str);
			Console.WriteLine(s);
			return s?.Length ?? 0;
		}
		catch
		{
			return -1;
		}
	}

	[MangledName("fputs")]
	public static int PutString(sbyte* str, void* file)
	{
		// https://cplusplus.com/reference/cstdio/fputs/
		try
		{
			string? s = Marshal.PtrToStringAnsi((IntPtr)str);
			if (file == StandardOutput)
				Console.Write(s);
			else if (file == StandardError)
				Console.Error.Write(s);
			else
				return -1;
			return s?.Length ?? 0;
		}
		catch
		{
			return -1;
		}
	}

	[MangledName("fflush")]
	public static int FFlush(void* file)
	{
		if (file == StandardOutput || file == null)
			Console.Out.Flush();
		if (file == StandardError || file == null)
			Console.Error.Flush();
		return 0;
	}

	[MangledName("putchar")]
	[MangledName("putchar_unlocked")]
	public static int Putchar(int c)
	{
		Console.Write((char)(byte)c);
		return c;
	}

	[MangledName("getchar")]
	[MangledName("getchar_unlocked")]
	public static int Getchar() => Console.Read();

	[MangledName("fputc")]
	[MangledName("putc")]
	public static int FPutc(int c, void* file)
	{
		char ch = (char)(byte)c;
		if (file == StandardOutput)
			Console.Write(ch);
		else if (file == StandardError)
			Console.Error.Write(ch);
		else
			return -1;
		return c;
	}

	[MangledName("fgetc")]
	[MangledName("getc")]
	public static int FGetc(void* file)
	{
		if (file != StandardInput)
			return -1;
		// Check thread-local one-char push-back buffer first.
		int pushed = _ungetcBuffer;
		if (pushed >= 0)
		{
			_ungetcBuffer = -1;
			return pushed;
		}
		return Console.Read();
	}

	// Thread-local one-character push-back buffer; -1 = empty (matches EOF sentinel).
	[ThreadStatic]
	private static int _ungetcBuffer;

	[MangledName("ungetc")]
	public static int ungetc(int c, void* file)
	{
		// https://en.cppreference.com/w/c/io/ungetc
		// Pushes one character back to the stream. Returns the pushed character on
		// success, EOF (-1) if c is EOF or the stream doesn't support push-back.
		if (c == -1)
			return -1; // cannot push EOF
		if (file == StandardInput)
		{
			// Only one push-back character is guaranteed by the standard.
			// Store in thread-local buffer; next FGetc call will drain it.
			_ungetcBuffer = c & 0xFF;
			return _ungetcBuffer;
		}
		// For stdout/stderr or unknown streams: report success but don't buffer.
		return c & 0xFF;
	}

	[MangledName("perror")]
	public static void Perror(byte* s)
	{
		string? prefix = s != null ? Marshal.PtrToStringUTF8((IntPtr)s) : null;
		Console.Error.WriteLine(prefix is { Length: > 0 } ? $"{prefix}: error" : "error");
	}

	// ── Printf shared helper ──────────────────────────────────────────────────
	// Used by both Windows (__stdio_common_vfprintf) and Linux (printf / fprintf / etc.)

	internal static string? FormatPrintf(byte* format, ReadOnlySpan<nint> args)
	{
		if (format is null)
			return null;
		string fmt = Marshal.PtrToStringUTF8((IntPtr)format) ?? "";
		var sb = new System.Text.StringBuilder();
		int argIndex = 0;
		int i = 0;

		while (i < fmt.Length)
		{
			if (fmt[i] != '%')
			{
				sb.Append(fmt[i++]);
				continue;
			}
			i++;
			if (i >= fmt.Length)
				break;
			if (fmt[i] == '%')
			{
				sb.Append('%');
				i++;
				continue;
			}

			// flags
			bool minus = false,
				plus = false,
				space = false,
				zero = false,
				hash = false;
			while (i < fmt.Length)
			{
				char fi = fmt[i];
				if (fi == '-')
				{
					minus = true;
					i++;
				}
				else if (fi == '+')
				{
					plus = true;
					i++;
				}
				else if (fi == ' ')
				{
					space = true;
					i++;
				}
				else if (fi == '0')
				{
					zero = true;
					i++;
				}
				else if (fi == '#')
				{
					hash = true;
					i++;
				}
				else
					break;
			}

			// width
			int width = 0;
			if (i < fmt.Length && fmt[i] == '*')
			{
				width = (int)(argIndex < args.Length ? args[argIndex++] : 0);
				if (width < 0)
				{
					minus = true;
					width = -width;
				}
				i++;
			}
			else
				while (i < fmt.Length && char.IsAsciiDigit(fmt[i]))
					width = width * 10 + (fmt[i++] - '0');

			// precision
			int prec = -1;
			if (i < fmt.Length && fmt[i] == '.')
			{
				i++;
				if (i < fmt.Length && fmt[i] == '*')
				{
					prec = (int)(argIndex < args.Length ? args[argIndex++] : 0);
					if (prec < 0)
						prec = -1;
					i++;
				}
				else
				{
					prec = 0;
					while (i < fmt.Length && char.IsAsciiDigit(fmt[i]))
						prec = prec * 10 + (fmt[i++] - '0');
				}
			}

			// length modifier: 0=int, -1=hh(char), 1=h(short), 2=l(long), 3=ll/j, 4=z, 5=t, 6=L
			int len = 0;
			if (i < fmt.Length)
				switch (fmt[i])
				{
					case 'h':
						i++;
						if (i < fmt.Length && fmt[i] == 'h')
						{
							i++;
							len = -1;
						}
						else
							len = 1;
						break;
					case 'l':
						i++;
						if (i < fmt.Length && fmt[i] == 'l')
						{
							i++;
							len = 3;
						}
						else
							len = 2;
						break;
					case 'j':
						i++;
						len = 3;
						break;
					case 'z':
						i++;
						len = 4;
						break;
					case 't':
						i++;
						len = 5;
						break;
					case 'L':
						i++;
						len = 6;
						break;
					case 'I': // MSVC I64/I32
						if (i + 2 < fmt.Length && fmt[i + 1] == '6' && fmt[i + 2] == '4')
						{
							i += 3;
							len = 3;
						}
						else if (i + 2 < fmt.Length && fmt[i + 1] == '3' && fmt[i + 2] == '2')
						{
							i += 3;
							len = 2;
						}
						else
							i++;
						break;
				}
			if (i >= fmt.Length)
				break;
			char spec = fmt[i++];

			string value;
			switch (spec)
			{
				case 'd':
				case 'i':
				{
					long v =
						len >= 2
							? (argIndex < args.Length ? args[argIndex++] : 0)
							: (int)(argIndex < args.Length ? args[argIndex++] : 0);
					value = FmtSignedInt(v, width, prec, minus, plus, space, zero);
					break;
				}
				case 'u':
				{
					ulong v =
						len >= 2
							? (ulong)(argIndex < args.Length ? args[argIndex++] : 0)
							: (uint)(argIndex < args.Length ? args[argIndex++] : 0);
					string d = v.ToString();
					if (prec >= 0 && d.Length < prec)
						d = d.PadLeft(prec, '0');
					value = minus
						? d.PadRight(width)
						: (zero && prec < 0 ? d.PadLeft(width, '0') : d.PadLeft(width));
					break;
				}
				case 'x':
				case 'X':
				{
					ulong v =
						len >= 2
							? (ulong)(argIndex < args.Length ? args[argIndex++] : 0)
							: (uint)(argIndex < args.Length ? args[argIndex++] : 0);
					string d = spec == 'x' ? v.ToString("x") : v.ToString("X");
					if (prec >= 0 && d.Length < prec)
						d = d.PadLeft(prec, '0');
					if (hash && v != 0)
						d = (spec == 'x' ? "0x" : "0X") + d;
					value = minus
						? d.PadRight(width)
						: (zero && prec < 0 ? d.PadLeft(width, '0') : d.PadLeft(width));
					break;
				}
				case 'o':
				{
					ulong v =
						len >= 2
							? (ulong)(argIndex < args.Length ? args[argIndex++] : 0)
							: (uint)(argIndex < args.Length ? args[argIndex++] : 0);
					string d = Convert.ToString((long)v, 8);
					if (hash && !d.StartsWith('0'))
						d = "0" + d;
					if (prec >= 0 && d.Length < prec)
						d = d.PadLeft(prec, '0');
					value = minus ? d.PadRight(width) : d.PadLeft(width);
					break;
				}
				case 'f':
				case 'F':
				{
					nint raw = (argIndex < args.Length ? args[argIndex++] : 0);
					double dv = *(double*)&raw;
					int p2 = prec >= 0 ? prec : 6;
					string sign =
						dv < 0 ? "-"
						: plus ? "+"
						: space ? " "
						: "";
					string d = Math.Abs(dv)
						.ToString("F" + p2, System.Globalization.CultureInfo.InvariantCulture);
					string comb = sign + d;
					value = minus ? comb.PadRight(width) : comb.PadLeft(width);
					break;
				}
				case 'e':
				case 'E':
				{
					nint raw = (argIndex < args.Length ? args[argIndex++] : 0);
					double dv = *(double*)&raw;
					int p2 = prec >= 0 ? prec : 6;
					string d = dv.ToString(
						(spec == 'e' ? "e" : "E") + p2,
						System.Globalization.CultureInfo.InvariantCulture
					);
					value = minus ? NormSciExp(d).PadRight(width) : NormSciExp(d).PadLeft(width);
					break;
				}
				case 'g':
				case 'G':
				{
					nint raw = (argIndex < args.Length ? args[argIndex++] : 0);
					double dv = *(double*)&raw;
					int p2 = prec >= 0 ? (prec == 0 ? 1 : prec) : 6;
					string d = dv.ToString(
						"G" + p2,
						System.Globalization.CultureInfo.InvariantCulture
					);
					if (spec == 'g')
						d = d.Replace("E+", "e+").Replace("E-", "e-");
					d = NormSciExp(d);
					if (!hash && d.Contains('.') && !d.Contains('e') && !d.Contains('E'))
						d = d.TrimEnd('0').TrimEnd('.');
					value = minus ? d.PadRight(width) : d.PadLeft(width);
					break;
				}
				case 'c':
				{
					nint cv = (argIndex < args.Length ? args[argIndex++] : 0);
					string ch =
						len >= 2 ? ((char)(int)cv).ToString() : ((char)(byte)(int)cv).ToString();
					value = minus ? ch.PadRight(width) : ch.PadLeft(width);
					break;
				}
				case 's':
				{
					nint ptr = (argIndex < args.Length ? args[argIndex++] : 0);
					string sv =
						ptr == 0 ? "(null)"
						: len >= 2 ? (Marshal.PtrToStringUni(ptr) ?? "")
						: (Marshal.PtrToStringUTF8(ptr) ?? "");
					if (prec >= 0 && sv.Length > prec)
						sv = sv[..prec];
					value = minus ? sv.PadRight(width) : sv.PadLeft(width);
					break;
				}
				case 'p':
				{
					nint ptr = (argIndex < args.Length ? args[argIndex++] : 0);
					string d = "0x" + ((ulong)(nuint)ptr).ToString("x");
					value = minus ? d.PadRight(width) : d.PadLeft(width);
					break;
				}
				case 'n':
					value = "";
					break; // write-back skipped for safety
				default:
					value = "%" + spec;
					break;
			}
			sb.Append(value);
		}
		return sb.ToString();
	}

	private static string FmtSignedInt(
		long v,
		int width,
		int prec,
		bool minus,
		bool plus,
		bool space,
		bool zero
	)
	{
		string sign =
			v < 0 ? "-"
			: plus ? "+"
			: space ? " "
			: "";
		ulong abs = v < 0 ? unchecked((ulong)(-v)) : (ulong)v;
		string d = abs.ToString();
		if (prec >= 0 && d.Length < prec)
			d = d.PadLeft(prec, '0');
		string comb = sign + d;
		if (minus)
			return comb.PadRight(width);
		if (zero && prec < 0)
			return sign + d.PadLeft(width - sign.Length, '0');
		return comb.PadLeft(width);
	}

	private static string NormSciExp(string s)
	{
		// Normalize exponent to at least 2 digits (C standard).
		int ei = s.IndexOfAny(['e', 'E']);
		if (ei < 0)
			return s;
		string mantissa = s[..ei];
		char ec = s[ei];
		string ep = s[(ei + 1)..];
		char esign = ep[0];
		string edigits = ep[1..].TrimStart('0');
		if (edigits.Length == 0)
			edigits = "0";
		if (edigits.Length < 2)
			edigits = edigits.PadLeft(2, '0');
		return mantissa + ec + esign + edigits;
	}

	// ── String functions ──────────────────────────────────────────────────────

	[MangledName("strcmp")]
	public static int strcmp(byte* p1, byte* p2)
	{
		// https://cplusplus.com/reference/cstring/strcmp/
		while (*p1 == *p2 && *p1 != '\0')
		{
			++p1;
			++p2;
		}
		return *p1 - *p2;
	}

	[MangledName("strncmp")]
	public static int strncmp(byte* p1, byte* p2, long count)
	{
		for (long i = 0; i < count; i++)
		{
			if (p1[i] != p2[i])
				return p1[i] - p2[i];
			if (p1[i] == 0)
				return 0;
		}
		return 0;
	}

	[MangledName("memchr")]
	public static byte* memchr(byte* data, int c, long length)
	{
		// https://cplusplus.com/reference/cstring/memchr/
		if (data == null)
			return null;
		byte b = unchecked((byte)c);
		for (long i = 0; i < length; i++)
			if (data[i] == b)
				return data + i;
		return null;
	}

	[MangledName("strchr")]
	public static byte* strchr(byte* str, int c)
	{
		// https://cplusplus.com/reference/cstring/strchr/
		if (str == null)
			return null;
		byte b = unchecked((byte)c);
		while (*str != '\0')
		{
			if (*str == b)
				return str;
			str++;
		}
		return b == 0 ? str : null;
	}

	[MangledName("strstr")]
	public static byte* strstr(byte* haystack, byte* needle)
	{
		// https://cplusplus.com/reference/cstring/strstr/
		if (haystack == null || needle == null)
			return null;
		long hl = strlen(haystack),
			nl = strlen(needle);
		int idx = new ReadOnlySpan<byte>(haystack, (int)hl).IndexOf(
			new ReadOnlySpan<byte>(needle, (int)nl)
		);
		return idx >= 0 ? haystack + idx : null;
	}

	[MangledName("strrchr")]
	public static byte* strrchr(byte* str, int c)
	{
		// https://cplusplus.com/reference/cstring/strrchr/
		if (str == null)
			return null;
		long length = strlen(str);
		int last = new ReadOnlySpan<byte>(str, (int)length).LastIndexOf((byte)c);
		return last >= 0 ? str + last : null;
	}

	[MangledName("strrstr")]
	public static byte* strrstr(byte* haystack, byte* needle)
	{
		if (haystack == null || needle == null)
			return null;
		long hl = strlen(haystack),
			nl = strlen(needle);
		int idx = new ReadOnlySpan<byte>(haystack, (int)hl).LastIndexOf(
			new ReadOnlySpan<byte>(needle, (int)nl)
		);
		return idx >= 0 ? haystack + idx : null;
	}

	[MangledName("strlen")]
	public static long strlen(byte* str)
	{
		// https://cplusplus.com/reference/cstring/strlen/
		if (str == null)
			return 0;
		long length = 0;
		while (*str != '\0')
		{
			length++;
			str++;
		}
		return length;
	}

	[MangledName("strnlen")]
	public static long strnlen(byte* str, long maxLen)
	{
		if (str == null)
			return 0;
		long n = 0;
		while (n < maxLen && *str != '\0')
		{
			n++;
			str++;
		}
		return n;
	}

	[MangledName("wcslen")]
	public static long wcslen(char* str)
	{
		// https://cplusplus.com/reference/cwchar/wcslen/
		if (str == null)
			return 0;
		long length = 0;
		while (*str != '\0')
		{
			length++;
			str++;
		}
		return length;
	}

	[MangledName("strcpy")]
	public static byte* strcpy(byte* dst, byte* src)
	{
		if (dst == null || src == null)
			return dst;
		long len = strlen(src);
		Buffer.MemoryCopy(src, dst, len + 1, len + 1);
		return dst;
	}

	[MangledName("strncpy")]
	public static byte* strncpy(byte* destination, byte* source, long count)
	{
		// https://cplusplus.com/reference/cstring/strncpy/
		if (destination == null || source == null)
			return null;
		long sourceLength = StringLengthWithMaximum(source, count);
		if (sourceLength > 0)
			Buffer.MemoryCopy(source, destination, count, sourceLength);
		if (sourceLength < count)
			new Span<byte>(destination + sourceLength, (int)(count - sourceLength)).Clear();
		return destination;
	}

	[MangledName("strncat")]
	public static byte* strncat(byte* destination, byte* source, long count)
	{
		// https://cplusplus.com/reference/cstring/strncat/
		if (destination == null || source == null)
			return null;
		long insertionPoint = strlen(destination);
		long sourceLength = StringLengthWithMaximum(source, (int)count);
		if (sourceLength > 0)
			Buffer.MemoryCopy(source, destination + insertionPoint, count, sourceLength);
		destination[insertionPoint + sourceLength] = 0;
		return destination;
	}

	[MangledName("strcat")]
	public static byte* strcat(byte* destination, byte* source)
	{
		// https://cplusplus.com/reference/cstring/strcat/
		return strncat(destination, source, int.MaxValue);
	}

	[MangledName("strdup")]
	public static byte* strdup(byte* str)
	{
		if (str == null)
			return null;
		long len = strlen(str);
		byte* copy = (byte*)NativeMemoryHelper.Allocate(len + 1);
		Buffer.MemoryCopy(str, copy, len + 1, len + 1);
		return copy;
	}

	[MangledName("strndup")]
	public static byte* strndup(byte* str, long n)
	{
		if (str == null)
			return null;
		long len = strnlen(str, n);
		byte* copy = (byte*)NativeMemoryHelper.Allocate(len + 1);
		if (len > 0)
			Buffer.MemoryCopy(str, copy, len, len);
		copy[len] = 0;
		return copy;
	}

	private static long StringLengthWithMaximum(byte* str, long maxLength)
	{
		if (str == null)
			return 0;
		long length = 0;
		while (length < maxLength && *str != '\0')
		{
			length++;
			str++;
		}
		return length;
	}

	// ── Character classification ──────────────────────────────────────────────

	[MangledName("tolower")]
	public static int ToLower(int character)
	{
		unchecked
		{
			uint u = (uint)character;
			if (u >= ushort.MaxValue)
				return character;
			return (int)(uint)char.ToLowerInvariant((char)u);
		}
	}

	[MangledName("toupper")]
	public static int ToUpper(int character)
	{
		unchecked
		{
			uint u = (uint)character;
			if (u >= ushort.MaxValue)
				return character;
			return (int)(uint)char.ToUpperInvariant((char)u);
		}
	}

	[MangledName("isalpha")]
	public static int IsAlpha(int c) => IsCClass(c, char.IsLetter);

	[MangledName("isdigit")]
	public static int IsDigit(int c) => IsCClass(c, char.IsAsciiDigit);

	[MangledName("isalnum")]
	public static int IsAlNum(int c) => IsCClass(c, char.IsLetterOrDigit);

	[MangledName("isspace")]
	public static int IsSpace(int c) => IsCClass(c, char.IsWhiteSpace);

	[MangledName("isupper")]
	public static int IsUpper(int c) => IsCClass(c, char.IsUpper);

	[MangledName("islower")]
	public static int IsLower(int c) => IsCClass(c, char.IsLower);

	[MangledName("isprint")]
	public static int IsPrint(int c) => IsCClass(c, static ch => !char.IsControl(ch));

	[MangledName("isgraph")]
	public static int IsGraph(int c) => IsCClass(c, static ch => !char.IsControl(ch) && ch != ' ');

	[MangledName("ispunct")]
	public static int IsPunct(int c) => IsCClass(c, char.IsPunctuation);

	[MangledName("iscntrl")]
	public static int IsCntrl(int c) => IsCClass(c, char.IsControl);

	[MangledName("isblank")]
	public static int IsBlank(int c) => c == ' ' || c == '\t' ? 1 : 0;

	[MangledName("isxdigit")]
	public static int IsXDigit(int c) => IsCClass(c, char.IsAsciiHexDigit);

	private static int IsCClass(int character, Func<char, bool> predicate)
	{
		unchecked
		{
			uint u = (uint)character;
			return u <= ushort.MaxValue && predicate((char)u) ? 1 : 0;
		}
	}

	// ── Number parsing ────────────────────────────────────────────────────────

	[MangledName("atoi")]
	public static int AsciiToInteger(byte* str) => (int)strtol(str, null, 10);

	[MangledName("atol")]
	public static long atol(byte* str) => strtol(str, null, 10);

	[MangledName("atoll")]
	public static long atoll(byte* str) => strtol(str, null, 10);

	[MangledName("atof")]
	public static double atof(byte* str) => strtod(str, null);

	[MangledName("strtol")]
	[MangledName("strtoll")]
	public static long strtol(byte* str, byte** endptr, int numBase)
	{
		if (str == null)
		{
			if (endptr != null)
				*endptr = str;
			return 0;
		}
		string s = Marshal.PtrToStringUTF8((IntPtr)str) ?? "";
		int i = 0;
		while (i < s.Length && char.IsWhiteSpace(s[i]))
			i++;
		long sign = 1;
		if (i < s.Length && s[i] == '-')
		{
			sign = -1;
			i++;
		}
		else if (i < s.Length && s[i] == '+')
			i++;
		if (numBase == 0)
		{
			if (i + 1 < s.Length && s[i] == '0' && s[i + 1] is 'x' or 'X')
				numBase = 16;
			else if (i < s.Length && s[i] == '0')
				numBase = 8;
			else
				numBase = 10;
		}
		if (numBase == 16 && i + 1 < s.Length && s[i] == '0' && s[i + 1] is 'x' or 'X')
			i += 2;
		int start = i;
		long result = 0;
		while (i < s.Length)
		{
			int d = ParseDigit(s[i], numBase);
			if (d < 0)
				break;
			result = result * numBase + d;
			i++;
		}
		if (endptr != null)
			*endptr = str + i;
		return i == start ? 0 : sign * result;

		static int ParseDigit(char c, int b)
		{
			int d =
				c is >= '0' and <= '9' ? c - '0'
				: c is >= 'a' and <= 'z' ? c - 'a' + 10
				: c is >= 'A' and <= 'Z' ? c - 'A' + 10
				: -1;
			return d >= 0 && d < b ? d : -1;
		}
	}

	[MangledName("strtoul")]
	[MangledName("strtoull")]
	public static ulong strtoul(byte* str, byte** endptr, int numBase) =>
		(ulong)strtol(str, endptr, numBase);

	[MangledName("strtod")]
	public static double strtod(byte* str, byte** endptr)
	{
		if (str == null)
		{
			if (endptr != null)
				*endptr = str;
			return 0.0;
		}
		string s = Marshal.PtrToStringUTF8((IntPtr)str) ?? "";
		int i = 0;
		while (i < s.Length && char.IsWhiteSpace(s[i]))
			i++;
		int start = i;
		if (i < s.Length && s[i] is '+' or '-')
			i++;
		while (
			i < s.Length
			&& (
				char.IsAsciiDigit(s[i])
				|| s[i] == '.'
				|| s[i] == 'e'
				|| s[i] == 'E'
				|| s[i] == '+'
				|| s[i] == '-'
			)
		)
			i++;
		if (endptr != null)
			*endptr = str + i;
		return double.TryParse(
			s[start..i],
			System.Globalization.NumberStyles.Float,
			System.Globalization.CultureInfo.InvariantCulture,
			out double d
		)
			? d
			: 0.0;
	}

	[MangledName("strtof")]
	public static float strtof(byte* str, byte** endptr) => (float)strtod(str, endptr);

	[MangledName("strtold")]
	public static double strtold(byte* str, byte** endptr) => strtod(str, endptr);

	// ── Math ──────────────────────────────────────────────────────────────────

	[MangledName("sqrt")]
	public static double Sqrt(double d) => double.Sqrt(d);

	[MangledName("sqrtf")]
	public static float Sqrtf(float f) => float.Sqrt(f);

	[MangledName("fabs")]
	public static double Fabs(double x) => Math.Abs(x);

	[MangledName("fabsf")]
	public static float Fabsf(float x) => Math.Abs(x);

	[MangledName("abs")]
	[MangledName("labs")]
	[MangledName("llabs")]
	public static long AbsL(long x) => Math.Abs(x);

	[MangledName("ceil")]
	public static double Ceil(double x) => Math.Ceiling(x);

	[MangledName("ceilf")]
	public static float Ceilf(float x) => MathF.Ceiling(x);

	[MangledName("floor")]
	public static double Floor(double x) => Math.Floor(x);

	[MangledName("floorf")]
	public static float Floorf(float x) => MathF.Floor(x);

	[MangledName("round")]
	public static double Round(double x) => Math.Round(x, MidpointRounding.AwayFromZero);

	[MangledName("roundf")]
	public static float Roundf(float x) => MathF.Round(x, MidpointRounding.AwayFromZero);

	[MangledName("trunc")]
	public static double Trunc(double x) => Math.Truncate(x);

	[MangledName("truncf")]
	public static float Truncf(float x) => MathF.Truncate(x);

	[MangledName("fmod")]
	public static double Fmod(double x, double y) => x % y;

	[MangledName("fmodf")]
	public static float Fmodf(float x, float y) => x % y;

	[MangledName("pow")]
	public static double Pow(double x, double y) => Math.Pow(x, y);

	[MangledName("powf")]
	public static float Powf(float x, float y) => MathF.Pow(x, y);

	[MangledName("exp")]
	public static double Exp(double x) => Math.Exp(x);

	[MangledName("expf")]
	public static float Expf(float x) => MathF.Exp(x);

	[MangledName("exp2")]
	public static double Exp2(double x) => Math.Pow(2.0, x);

	[MangledName("exp2f")]
	public static float Exp2f(float x) => MathF.Pow(2.0f, x);

	[MangledName("log")]
	public static double Log(double x) => Math.Log(x);

	[MangledName("logf")]
	public static float Logf(float x) => MathF.Log(x);

	[MangledName("log2")]
	public static double Log2(double x) => Math.Log2(x);

	[MangledName("log2f")]
	public static float Log2f(float x) => MathF.Log2(x);

	[MangledName("log10")]
	public static double Log10(double x) => Math.Log10(x);

	[MangledName("log10f")]
	public static float Log10f(float x) => MathF.Log10(x);

	[MangledName("sin")]
	public static double Sin(double x) => Math.Sin(x);

	[MangledName("sinf")]
	public static float Sinf(float x) => MathF.Sin(x);

	[MangledName("cos")]
	public static double Cos(double x) => Math.Cos(x);

	[MangledName("cosf")]
	public static float Cosf(float x) => MathF.Cos(x);

	[MangledName("tan")]
	public static double Tan(double x) => Math.Tan(x);

	[MangledName("tanf")]
	public static float Tanf(float x) => MathF.Tan(x);

	[MangledName("asin")]
	public static double Asin(double x) => Math.Asin(x);

	[MangledName("asinf")]
	public static float Asinf(float x) => MathF.Asin(x);

	[MangledName("acos")]
	public static double Acos(double x) => Math.Acos(x);

	[MangledName("acosf")]
	public static float Acosf(float x) => MathF.Acos(x);

	[MangledName("atan")]
	public static double Atan(double x) => Math.Atan(x);

	[MangledName("atanf")]
	public static float Atanf(float x) => MathF.Atan(x);

	[MangledName("atan2")]
	public static double Atan2(double y, double x) => Math.Atan2(y, x);

	[MangledName("atan2f")]
	public static float Atan2f(float y, float x) => MathF.Atan2(y, x);

	[MangledName("hypot")]
	public static double Hypot(double x, double y) => Math.Sqrt(x * x + y * y);

	[MangledName("hypotf")]
	public static float Hypotf(float x, float y) => MathF.Sqrt(x * x + y * y);

	[MangledName("cbrt")]
	public static double Cbrt(double x) => Math.Cbrt(x);

	[MangledName("cbrtf")]
	public static float Cbrtf(float x) => MathF.Cbrt(x);

	[MangledName("fmin")]
	public static double Fmin(double x, double y) => Math.Min(x, y);

	[MangledName("fminf")]
	public static float Fminf(float x, float y) => Math.Min(x, y);

	[MangledName("fmax")]
	public static double Fmax(double x, double y) => Math.Max(x, y);

	[MangledName("fmaxf")]
	public static float Fmaxf(float x, float y) => Math.Max(x, y);

	[MangledName("sinh")]
	public static double Sinh(double x) => Math.Sinh(x);

	[MangledName("cosh")]
	public static double Cosh(double x) => Math.Cosh(x);

	[MangledName("tanh")]
	public static double Tanh(double x) => Math.Tanh(x);

	[MangledName("sinhf")]
	public static float Sinhf(float x) => MathF.Sinh(x);

	[MangledName("coshf")]
	public static float Coshf(float x) => MathF.Cosh(x);

	[MangledName("tanhf")]
	public static float Tanhf(float x) => MathF.Tanh(x);

	[MangledName("ldexp")]
	public static double Ldexp(double x, int exp) => x * Math.Pow(2.0, exp);

	[MangledName("ldexpf")]
	public static float Ldexpf(float x, int exp) => x * MathF.Pow(2.0f, exp);

	[MangledName("frexp")]
	public static double Frexp(double x, int* exp)
	{
		if (x == 0.0)
		{
			if (exp != null)
				*exp = 0;
			return 0.0;
		}
		long bits = BitConverter.DoubleToInt64Bits(x);
		int exponent = (int)((bits >> 52) & 0x7FF) - 1022;
		double mantissa = BitConverter.Int64BitsToDouble(
			(bits & unchecked((long)0x800FFFFFFFFFFFFF)) | 0x3FE0000000000000
		);
		if (exp != null)
			*exp = exponent;
		return mantissa;
	}

	[MangledName("modf")]
	public static double Modf(double x, double* intpart)
	{
		double t = Math.Truncate(x);
		if (intpart != null)
			*intpart = t;
		return x - t;
	}

	// ── Random ────────────────────────────────────────────────────────────────

	private static System.Random? _randomField;
	private static System.Random _random => _randomField ??= new System.Random();

	[MangledName("rand")]
	public static int Rand() => _random.Next(0, 32768);

	[MangledName("srand")]
	public static void Srand(uint s) => _randomField = new System.Random((int)s);

	// ── Clock ─────────────────────────────────────────────────────────────────

	private static readonly long StartTicks = Environment.TickCount64;

	[MangledName("clock")]
	public static long Clock()
	{
		// https://cplusplus.com/reference/ctime/clock/
		// Linux: CLOCKS_PER_SEC = 1000000 (microseconds).
		// Note: this assumes that CLOCKS_PER_SEC is 1000000, which is true on Linux.
		// If C++ code is compiled on Windows where CLOCKS_PER_SEC is 1000, this will be off.
		return (Environment.TickCount64 - StartTicks) * 1000;
	}

	// ── Memory operations ─────────────────────────────────────────────────────

	[MangledName("memcmp")]
	public static int memcmp(byte* p1, byte* p2, long count)
	{
		for (long i = 0; i < count; i++)
			if (p1[i] != p2[i])
				return p1[i] - p2[i];
		return 0;
	}

	[MangledName("memcpy")]
	public static void* memcpy(void* dst, void* src, long n)
	{
		Unsafe.CopyBlock(dst, src, (uint)n);
		return dst;
	}

	[MangledName("memmove")]
	public static void* memmove(void* dst, void* src, long n)
	{
		byte[] buf = ArrayPool<byte>.Shared.Rent((int)n);
		new ReadOnlySpan<byte>(src, (int)n).CopyTo(new Span<byte>(buf, 0, (int)n));
		new Span<byte>(buf, 0, (int)n).CopyTo(new Span<byte>(dst, (int)n));
		ArrayPool<byte>.Shared.Return(buf);
		return dst;
	}

	[MangledName("memset")]
	public static void* memset(void* dst, int val, long n)
	{
		new Span<byte>(dst, (int)n).Fill(unchecked((byte)val));
		return dst;
	}

	[MangledName("llvm.memcpy.p0.p0.i32")]
	public static void llvm_memcpy_p0_p0_i32(
		void* destination,
		void* source,
		int length,
		bool isVolatile
	)
	{
		Unsafe.CopyBlock(destination, source, (uint)length);
	}

	[MangledName("llvm.memcpy.p0.p0.i64")]
	[MangledName("llvm.memcpy.inline.p0.p0.i64")]
	public static void llvm_memcpy_p0_p0_i64(
		void* destination,
		void* source,
		long length,
		bool isVolatile
	)
	{
		Unsafe.CopyBlock(destination, source, (uint)length);
	}

	[MangledName("llvm.memmove.p0.p0.i32")]
	public static void llvm_memmove_p0_p0_i32(
		void* destination,
		void* source,
		int length,
		bool isVolatile
	)
	{
		// Same as memcpy, except that the source and destination are allowed to overlap.
		byte[] buffer = ArrayPool<byte>.Shared.Rent(length);
		Span<byte> span = new(buffer, 0, length);
		new ReadOnlySpan<byte>(source, length).CopyTo(span);
		span.CopyTo(new Span<byte>(destination, length));
		ArrayPool<byte>.Shared.Return(buffer);
	}

	[MangledName("llvm.memmove.p0.p0.i64")]
	public static void llvm_memmove_p0_p0_i64(
		void* destination,
		void* source,
		long length,
		bool isVolatile
	)
	{
		llvm_memmove_p0_p0_i32(destination, source, (int)length, isVolatile);
	}

	[MangledName("llvm.memset.p0.i32")]
	public static void llvm_memset_p0_i32(
		void* destination,
		sbyte value,
		int length,
		bool isVolatile
	)
	{
		new Span<byte>(destination, length).Fill(unchecked((byte)value));
	}

	[MangledName("llvm.memset.p0.i64")]
	public static void llvm_memset_p0_i64(
		void* destination,
		sbyte value,
		long length,
		bool isVolatile
	)
	{
		llvm_memset_p0_i32(destination, value, (int)length, isVolatile);
	}

	// ── Heap allocation ───────────────────────────────────────────────────────

	[MangledName("calloc")]
	public static void* CAlloc(long elementCount, long elementSize)
	{
		// https://en.cppreference.com/w/c/memory/calloc
		if (elementCount <= 0 || elementSize <= 0)
			return null;
		if (elementCount > int.MaxValue || elementSize > int.MaxValue)
			return null;
		long totalSize = elementCount * elementSize;
		if (totalSize > int.MaxValue)
			return null;
		void* result = Alloc(totalSize);
		new Span<byte>(result, (int)totalSize).Clear();
		return result;
	}

	[MangledName("malloc")]
	public static void* Alloc(long size) => NativeMemoryHelper.Allocate(size);

	[MangledName("realloc")]
	public static void* ReAlloc(void* ptr, long size) => NativeMemoryHelper.Reallocate(ptr, size);

	[MangledName("free")]
	public static void Free(void* ptr) => NativeMemoryHelper.Free(ptr);

	// ── Shared AssertExceptionInfo (used by _wassert on Windows and __assert_fail on Linux) ──

	private sealed class AssertExceptionInfo : ExceptionInfo
	{
		public string Message { get; }

		public AssertExceptionInfo(string message)
		{
			Message = message;
		}

		public override string? GetMessage() => Message;
	}

	// ── Pointer masking ───────────────────────────────────────────────────────
	// llvm.ptrmask.p0.i64 — mask out low bits of a pointer (e.g. for alignment)

	[MangledName("llvm.ptrmask.p0.i64")]
	public static void* llvm_ptrmask_p0_i64(void* ptr, long mask) =>
		(void*)((ulong)(nuint)ptr & unchecked((ulong)mask));

	// ── FP class testing ─────────────────────────────────────────────────────
	// llvm.is.fpclass.f32/f64/f80 — test floating-point value against a bitmask
	// Bitmask layout (LLVM LangRef):
	//   Bit 0: SNaN  Bit 1: QNaN  Bit 2: -Inf   Bit 3: -Normal
	//   Bit 4: -Sub  Bit 5: -Zero Bit 6: +Zero  Bit 7: +Sub
	//   Bit 8: +Normal  Bit 9: +Inf
	// Note: .NET does not distinguish SNaN/QNaN; both bits 0 and 1 check IsNaN.

	[MangledName("llvm.is.fpclass.f32")]
	public static bool llvm_is_fpclass_f32(float x, int mask)
	{
		if ((mask & 0x003) != 0 && float.IsNaN(x))
			return true;
		if ((mask & 0x004) != 0 && float.IsNegativeInfinity(x))
			return true;
		if ((mask & 0x008) != 0 && float.IsNormal(x) && float.IsNegative(x))
			return true;
		if ((mask & 0x010) != 0 && float.IsSubnormal(x) && float.IsNegative(x))
			return true;
		if ((mask & 0x020) != 0 && x == 0f && float.IsNegative(x))
			return true;
		if ((mask & 0x040) != 0 && x == 0f && !float.IsNegative(x))
			return true;
		if ((mask & 0x080) != 0 && float.IsSubnormal(x) && !float.IsNegative(x))
			return true;
		if ((mask & 0x100) != 0 && float.IsNormal(x) && !float.IsNegative(x))
			return true;
		if ((mask & 0x200) != 0 && float.IsPositiveInfinity(x))
			return true;
		return false;
	}

	[MangledName("llvm.is.fpclass.f64")]
	public static bool llvm_is_fpclass_f64(double x, int mask)
	{
		if ((mask & 0x003) != 0 && double.IsNaN(x))
			return true;
		if ((mask & 0x004) != 0 && double.IsNegativeInfinity(x))
			return true;
		if ((mask & 0x008) != 0 && double.IsNormal(x) && double.IsNegative(x))
			return true;
		if ((mask & 0x010) != 0 && double.IsSubnormal(x) && double.IsNegative(x))
			return true;
		if ((mask & 0x020) != 0 && x == 0d && double.IsNegative(x))
			return true;
		if ((mask & 0x040) != 0 && x == 0d && !double.IsNegative(x))
			return true;
		if ((mask & 0x080) != 0 && double.IsSubnormal(x) && !double.IsNegative(x))
			return true;
		if ((mask & 0x100) != 0 && double.IsNormal(x) && !double.IsNegative(x))
			return true;
		if ((mask & 0x200) != 0 && double.IsPositiveInfinity(x))
			return true;
		return false;
	}

	// x86_fp80 is approximated as double throughout the translator.
	[MangledName("llvm.is.fpclass.f80")]
	public static bool llvm_is_fpclass_f80(double x, int mask) => llvm_is_fpclass_f64(x, mask);

	// ── Fixed-point arithmetic ────────────────────────────────────────────────
	// llvm.smul.fix / llvm.umul.fix / llvm.udiv.fix
	// All non-saturating variants; scale is the number of fractional bits.

	// Signed multiply: ((wide)a * (wide)b) >> scale, truncated
	[MangledName("llvm.smul.fix.i16")]
	public static short llvm_smul_fix_i16(short a, short b, int scale) =>
		unchecked((short)(((int)a * (int)b) >> scale));

	[MangledName("llvm.smul.fix.i32")]
	public static int llvm_smul_fix_i32(int a, int b, int scale) =>
		unchecked((int)(((long)a * (long)b) >> scale));

	// Unsigned multiply: treat bit patterns as unsigned, multiply, shift, reinterpret
	[MangledName("llvm.umul.fix.i8")]
	public static sbyte llvm_umul_fix_i8(sbyte a, sbyte b, int scale) =>
		unchecked((sbyte)(byte)((ushort)((byte)a * (byte)b) >> scale));

	[MangledName("llvm.umul.fix.i16")]
	public static short llvm_umul_fix_i16(short a, short b, int scale) =>
		unchecked((short)(ushort)((uint)((ushort)a * (ushort)b) >> scale));

	[MangledName("llvm.umul.fix.i32")]
	public static int llvm_umul_fix_i32(int a, int b, int scale) =>
		unchecked((int)(uint)((ulong)((uint)a * (uint)b) >> scale));

	// Unsigned divide: ((wide)a << scale) / (wide)b, truncated
	[MangledName("llvm.udiv.fix.i8")]
	public static sbyte llvm_udiv_fix_i8(sbyte a, sbyte b, int scale) =>
		unchecked((sbyte)(byte)(((ushort)(byte)a << scale) / (byte)b));

	[MangledName("llvm.udiv.fix.i16")]
	public static short llvm_udiv_fix_i16(short a, short b, int scale) =>
		unchecked((short)(ushort)(((uint)(ushort)a << scale) / (ushort)b));

	[MangledName("llvm.udiv.fix.i32")]
	public static int llvm_udiv_fix_i32(int a, int b, int scale) =>
		unchecked((int)(uint)(((ulong)(uint)a << scale) / (uint)b));
}
#pragma warning restore IDE0060 // Remove unused parameter
