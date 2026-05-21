using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class printf_core_vfprintf_internal
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core17vfprintf_internalEP8_IO_FILEPKcRNS_8internal7ArgListE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::vfprintf_internal(_IO_FILE*, char const*, __llvm_libc_20_1_2_::internal::ArgList&)")]
	public unsafe static int Invoke([NativeType("_IO_FILE*")] void* stream, [NativeType("char const*")] void* format, [NativeType("__llvm_libc_20_1_2_::internal::ArgList&")] internal_ArgList* args)
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
		WriteBuffer_Constructor.Invoke(&printf_core_WriteBuffer2, &inlineArray1024_SByte, 1024L, printf_core_file_write_hook.__pointer, stream);
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
			Writer_Constructor.Invoke(&printf_core_Writer2, &printf_core_WriteBuffer2);
			internal_flockfile.Invoke(stream);
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = printf_core_printf_main.Invoke(&printf_core_Writer2, format, args);
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			string_view_Constructor.Invoke(&cpp_string_view2, str_118.Pointer);
			num3 = WriteBuffer_overflow_write.Invoke(&printf_core_WriteBuffer2, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
			if (num3 != 0)
			{
				num2 = num3;
			}
			internal_funlockfile.Invoke(stream);
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
