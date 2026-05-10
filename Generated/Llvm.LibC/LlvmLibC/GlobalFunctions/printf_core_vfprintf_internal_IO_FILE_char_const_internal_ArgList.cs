using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core17vfprintf_internalEP8_IO_FILEPKcRNS_8internal7ArgListE")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::vfprintf_internal(_IO_FILE*, char const*, __llvm_libc_20_1_2_::internal::ArgList&)")]
internal static partial class printf_core_vfprintf_internal_IO_FILE_char_const_internal_ArgList
{
	public unsafe static int Invoke(void* stream, void* format, void* args)
	{
		long num = 0L;
		InlineArray1024_SByte inlineArray1024_SByte = default(InlineArray1024_SByte);
		printf_core_WriteBuffer printf_core_WriteBuffer2 = default(printf_core_WriteBuffer);
		printf_core_Writer printf_core_Writer2 = default(printf_core_Writer);
		int num2 = 0;
		int num3 = 0;
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 1024L;
		llvm_lifetime_start_p0.Invoke(1024L, &inlineArray1024_SByte);
		llvm_memset_p0_i64.Invoke(&inlineArray1024_SByte, -86, 1024L, isVolatile: false);
		llvm_lifetime_start_p0.Invoke(56L, &printf_core_WriteBuffer2);
		llvm_memset_p0_i64.Invoke(&printf_core_WriteBuffer2, -86, 56L, isVolatile: false);
		printf_core_WriteBuffer_WriteBuffer_char_unsigned_long_int_cpp_string_view_void_void.Invoke(&printf_core_WriteBuffer2, &inlineArray1024_SByte, 1024L, printf_core_file_write_hook_cpp_string_view_void.__pointer, stream);
		llvm_lifetime_start_p0.Invoke(16L, &printf_core_Writer2);
		unchecked
		{
			*(IntPtr*)(&printf_core_Writer2) = unchecked((nint)(-6148914691236517206L));
			((int*)(&printf_core_Writer2))[2] = -1431655766;
			sbyte* ptr = (sbyte*)(&printf_core_Writer2) + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			printf_core_Writer_Writer_printf_core_WriteBuffer.Invoke(&printf_core_Writer2, &printf_core_WriteBuffer2);
			internal_flockfile_IO_FILE.Invoke(stream);
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = printf_core_printf_main_printf_core_Writer_char_const_internal_ArgList.Invoke(&printf_core_Writer2, format, args);
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			cpp_string_view_string_view_char_const.Invoke(&cpp_string_view2, str_116.Pointer);
			num3 = printf_core_WriteBuffer_overflow_write_cpp_string_view.Invoke(&printf_core_WriteBuffer2, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
			if (num3 != 0)
			{
				num2 = num3;
			}
			internal_funlockfile_IO_FILE.Invoke(stream);
			int result = num2;
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(16L, &printf_core_Writer2);
			llvm_lifetime_end_p0.Invoke(56L, &printf_core_WriteBuffer2);
			llvm_lifetime_end_p0.Invoke(1024L, &inlineArray1024_SByte);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
