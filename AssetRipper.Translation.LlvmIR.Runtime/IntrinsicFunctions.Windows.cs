using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace AssetRipper.Translation.LlvmIR.Runtime;

#pragma warning disable IDE0060 // Remove unused parameter
public static unsafe partial class IntrinsicFunctions
{
	// ── Windows / MSVC-specific intrinsics ───────────────────────────────────

	// ── Formatted I/O (MSVC internal CRT wrappers) ───────────────────────────

	[MangledName("__stdio_common_vfprintf")]
	public static int __stdio_common_vfprintf(
		long options,
		void* stream,
		void* format,
		void* locale,
		void* argList
	)
	{
		// https://learn.microsoft.com/en-us/cpp/c-runtime-library/internal-crt-globals-and-functions?view=msvc-170
		// argList is a va_list, which on Windows x64 is a pointer to the varargs on the stack.
		ReadOnlySpan<nint> args = new((nint*)argList, 64);
		string? result = FormatPrintf((byte*)format, args);
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

	[MangledName("__stdio_common_vsprintf_s")]
	public static int __stdio_common_vsprintf_s(
		long options,
		void* buffer,
		long bufferLength,
		void* format,
		void* locale,
		void* argList
	)
	{
		// https://learn.microsoft.com/en-us/cpp/c-runtime-library/internal-crt-globals-and-functions?view=msvc-170
		ReadOnlySpan<nint> args = new((nint*)argList, 64);
		string? result = FormatPrintf((byte*)format, args);
		if (result is null)
			return -1;
		byte[] encoded = System.Text.Encoding.UTF8.GetBytes(result);
		long copyLen = Math.Min(encoded.Length, bufferLength - 1);
		encoded.AsSpan(0, (int)copyLen).CopyTo(new Span<byte>(buffer, (int)bufferLength));
		((byte*)buffer)[copyLen] = 0; // null-terminate
		return (int)copyLen;
	}

	[MangledName("__stdio_common_vsscanf")]
	public static int __stdio_common_vsscanf(
		long options,
		void* input,
		long inputLength,
		void* format,
		void* locale,
		void* argList
	)
	{
		// https://learn.microsoft.com/en-us/cpp/c-runtime-library/internal-crt-globals-and-functions?view=msvc-170
		throw new NotSupportedException("scanf family is not supported.");
	}

	// ── Standard streams ─────────────────────────────────────────────────────

	[MangledName("__acrt_iob_func")]
	public static void* GetSystemStream(int identifier)
	{
		// https://learn.microsoft.com/en-us/cpp/c-runtime-library/internal-crt-globals-and-functions?view=msvc-170
		// identifier: 0 = stdin, 1 = stdout, 2 = stderr
		return identifier switch
		{
			0 => StandardInput,
			1 => StandardOutput,
			2 => StandardError,
			_ => null,
		};
	}

	// ── Assertions ───────────────────────────────────────────────────────────

	[MangledName("_wassert")]
	[MightThrow]
	public static void Assert(char* message, char* file, uint line)
	{
		ExceptionInfo.Current = new AssertExceptionInfo(
			$"Assertion failed: {Marshal.PtrToStringUni((IntPtr)message)} at {Marshal.PtrToStringUni((IntPtr)file)}:{line}"
		);
	}

	/// <summary>
	/// Triggers a fatal exception, indicating a critical assertion failure in the application.
	/// </summary>
	/// <remarks>
	/// This aligns with the C++ behavior, which causes the application to crash and triggers the Windows Error Reporting (WER) system (aka "Watson").
	/// </remarks>
	[DoesNotReturn]
	[MangledName("_invoke_watson")]
	public static void InvokeWatson(
		char* expression,
		char* function,
		char* file,
		int line,
		long reserved
	)
	{
		throw new FatalException(
			$"Fatal assertion failed: {Marshal.PtrToStringUni((IntPtr)expression)} in {Marshal.PtrToStringUni((IntPtr)function)} at {Marshal.PtrToStringUni((IntPtr)file)}:{line}"
		);
	}

	// ── Termination ──────────────────────────────────────────────────────────

	[DoesNotReturn]
	[MangledName("__std_terminate")]
	public static void StdTerminate() => Terminate();

	// ── MSVC C++ exception ABI ────────────────────────────────────────────────

	[MangledName("_CxxThrowException")]
	[MightThrow]
	public static void CxxThrowException(void* exceptionPointer, void* throwInfo)
	{
		ExceptionInfo.Current = new NativeExceptionInfo(exceptionPointer, (ThrowInfo*)throwInfo);
	}

	[MangledName("__CxxFrameHandler3")]
	public static int CxxFrameHandler3(ReadOnlySpan<nint> args)
	{
		if (args.Length != 3)
			throw new ArgumentException("Expected 3 arguments", nameof(args));

		if (args[0] == 0 || args[1] == 0 || args[2] == 0)
			throw new ArgumentNullException(nameof(args), "Arguments cannot be null");

		RttiTypeDescriptor* rttiTypeDescriptor = *(RttiTypeDescriptor**)args[0];
		int unknown = *(int*)args[1];
		void** outException = (void**)args[2];

		if (ExceptionInfo.Current is NativeExceptionInfo nativeException)
		{
			if (rttiTypeDescriptor is not null && !nativeException.Contains(rttiTypeDescriptor))
				return 1; // Continue search

			if (outException != null)
				*outException = nativeException.ExceptionPointer;

			return 0; // Handled
		}
		else
		{
			if (rttiTypeDescriptor != null || outException != null)
				throw new NotSupportedException(
					$"Current exception is not a {nameof(NativeExceptionInfo)}."
				);
			return 0; // Handled because throwInfo is null
		}
	}

	// ── MSVC operator new / delete / heap ────────────────────────────────────

	[MangledName("??2@YAPEAX_K@Z")] // operator new(size_t)
	public static void* MsvcNew(long size) => NativeMemoryHelper.Allocate(size);

	[MangledName("??3@YAXPEAX_K@Z")] // operator delete(void*, size_t)
	public static void Delete(void* ptr, long size) => NativeMemoryHelper.Free(ptr);

	[MangledName("_msize")]
	public static long Size(void* ptr) => NativeMemoryHelper.Size(ptr);

	[MangledName("expand")]
	public static void* Expand(void* ptr, long size)
	{
		// _expand is a non-standard MSVC CRT function that tries to resize a block in-place.
		// We return null to signal that in-place expansion is not possible.
		return null;
	}

	// ── MSVC-specific nested types ────────────────────────────────────────────

	private sealed class NativeExceptionInfo : ExceptionInfo
	{
		public void* ExceptionPointer { get; private set; }
		public ThrowInfo* ThrowInfo { get; private set; }

		public NativeExceptionInfo(void* exceptionPointer, ThrowInfo* throwInfo)
		{
			ExceptionPointer = exceptionPointer;
			ThrowInfo = throwInfo;
		}

		public bool Contains(RttiTypeDescriptor* rttiTypeDescriptor)
		{
			if (ThrowInfo == null)
				return false;
			foreach (CatchableType catchableType in ThrowInfo->CatchableTypeArray)
			{
				if (catchableType.RttiTypeDescriptor == rttiTypeDescriptor)
					return true;
			}
			return false;
		}

		protected override void Dispose(bool disposing)
		{
			if (ExceptionPointer != null && ThrowInfo != null)
			{
				delegate* <void*, void> destructor = ThrowInfo->Destructor;
				if (destructor != null)
					destructor(ExceptionPointer);
			}
			ExceptionPointer = null;
			ThrowInfo = null;
		}
	}

	private struct ThrowInfo
	{
		public int field_0;
		public int DestructorIndex;
		public int CatchableTypeArrayIndex;

		public readonly delegate* <void*, void> Destructor =>
			(delegate* <void*, void>)PointerIndices.GetPointer(DestructorIndex);
		public readonly ReadOnlySpan<CatchableType> CatchableTypeArray
		{
			get
			{
				CatchableTypeArray* array = (CatchableTypeArray*)
					PointerIndices.GetPointer(CatchableTypeArrayIndex);
				if (array == null || array->Count <= 0)
					return [];
				return new ReadOnlySpan<CatchableType>((byte*)array + sizeof(int), array->Count);
			}
		}
	}

	private struct CatchableTypeArray
	{
		public int Count;
		// Inline array starts here
	}

	private struct CatchableType
	{
		public int field_0;
		public int RttiTypeDescriptorIndex;
		public int field_2;
		public int field_3;
		public int field_4;
		public int field_5;
		public int ConstructorIndex;

		public readonly RttiTypeDescriptor* RttiTypeDescriptor =>
			(RttiTypeDescriptor*)PointerIndices.GetPointer(RttiTypeDescriptorIndex);

		// Not sure if the signature is always this
		public readonly delegate* <void*, void*, void*> Constructor =>
			(delegate* <void*, void*, void*>)PointerIndices.GetPointer(ConstructorIndex);
	}

	private struct RttiTypeDescriptor { }
}
#pragma warning restore IDE0060 // Remove unused parameter
