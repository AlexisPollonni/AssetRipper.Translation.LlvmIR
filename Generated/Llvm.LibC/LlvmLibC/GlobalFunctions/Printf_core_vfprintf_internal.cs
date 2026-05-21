using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Printf_core_vfprintf_internal
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core17vfprintf_internalEP8_IO_FILEPKcRNS_8internal7ArgListE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::vfprintf_internal(_IO_FILE*, char const*, __llvm_libc_20_1_2_::internal::ArgList&)")]
	public unsafe static int Invoke([MangledName("stream")][NativeType("_IO_FILE*")] void* Stream, [MangledName("format")][NativeType("char const*")] void* Format, [MangledName("args")][NativeType("__llvm_libc_20_1_2_::internal::ArgList&")] Llvm_libc_20_1_2_internal_ArgList* Args)
	{
		long num = 0L;
		InlineArray1024_SByte inlineArray1024_SByte = default(InlineArray1024_SByte);
		Llvm_libc_20_1_2_printf_core_WriteBuffer llvm_libc_20_1_2_printf_core_WriteBuffer = default(Llvm_libc_20_1_2_printf_core_WriteBuffer);
		Llvm_libc_20_1_2_printf_core_Writer llvm_libc_20_1_2_printf_core_Writer = default(Llvm_libc_20_1_2_printf_core_Writer);
		int num2 = 0;
		int num3 = 0;
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 1024L;
		Llvm_lifetime_start_p0.Invoke(1024L, &inlineArray1024_SByte);
		Llvm_memset_p0_i64.Invoke(&inlineArray1024_SByte, -86, 1024L, isVolatile: false);
		Llvm_lifetime_start_p0.Invoke(56L, &llvm_libc_20_1_2_printf_core_WriteBuffer);
		Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_WriteBuffer, -86, 56L, isVolatile: false);
		WriteBuffer_Constructor.Invoke(&llvm_libc_20_1_2_printf_core_WriteBuffer, &inlineArray1024_SByte, 1024L, Printf_core_file_write_hook.__pointer, Stream);
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_printf_core_Writer);
		unchecked
		{
			*(IntPtr*)(&llvm_libc_20_1_2_printf_core_Writer) = unchecked((nint)(-6148914691236517206L));
			((int*)(&llvm_libc_20_1_2_printf_core_Writer))[2] = -1431655766;
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_printf_core_Writer) + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			Writer_Constructor.Invoke(&llvm_libc_20_1_2_printf_core_Writer, &llvm_libc_20_1_2_printf_core_WriteBuffer);
			Internal_flockfile.Invoke(Stream);
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = Printf_core_printf_main.Invoke(&llvm_libc_20_1_2_printf_core_Writer, Format, Args);
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view, Str_118.Pointer);
			num3 = WriteBuffer_overflow_write.Invoke(&llvm_libc_20_1_2_printf_core_WriteBuffer, *(void**)(&llvm_libc_20_1_2_cpp_string_view), ((long*)(&llvm_libc_20_1_2_cpp_string_view))[1]);
			if (num3 != 0)
			{
				num2 = num3;
			}
			Internal_funlockfile.Invoke(Stream);
			int result = num2;
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_printf_core_Writer);
			Llvm_lifetime_end_p0.Invoke(56L, &llvm_libc_20_1_2_printf_core_WriteBuffer);
			Llvm_lifetime_end_p0.Invoke(1024L, &inlineArray1024_SByte);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
