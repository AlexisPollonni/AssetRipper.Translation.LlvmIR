using System;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core18vasprintf_internalEPPcPKcNS_8internal7ArgListE")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::vasprintf_internal(char**, char const*, __llvm_libc_20_1_2_::internal::ArgList)")]
internal static partial class printf_core_vasprintf_internal_char_char_const_internal_ArgList
{
	public unsafe static int Invoke(void* ret, void* format, void* args)
	{
		InlineArray200_SByte inlineArray200_SByte = default(InlineArray200_SByte);
		printf_core_WriteBuffer printf_core_WriteBuffer2 = default(printf_core_WriteBuffer);
		printf_core_Writer printf_core_Writer2 = default(printf_core_Writer);
		int num = 0;
		llvm_lifetime_start_p0.Invoke(200L, &inlineArray200_SByte);
		llvm_memset_p0_i64.Invoke(&inlineArray200_SByte, -86, 200L, isVolatile: false);
		llvm_lifetime_start_p0.Invoke(56L, &printf_core_WriteBuffer2);
		llvm_memset_p0_i64.Invoke(&printf_core_WriteBuffer2, -86, 56L, isVolatile: false);
		printf_core_WriteBuffer_WriteBuffer_char_unsigned_long_int_cpp_string_view_void.Invoke(&printf_core_WriteBuffer2, &inlineArray200_SByte, 200L, printf_core_resize_overflow_hook_cpp_string_view_void.__pointer);
		llvm_lifetime_start_p0.Invoke(16L, &printf_core_Writer2);
		int result;
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
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = printf_core_printf_main_printf_core_Writer_char_const_internal_ArgList.Invoke(&printf_core_Writer2, format, args);
			if (num < 0)
			{
				*(IntPtr*)ret = (nint)0;
				result = -1;
			}
			else
			{
				if (printf_core_WriteBuffer2.buff == &inlineArray200_SByte)
				{
					*(void**)ret = malloc.Invoke(checked(num + 1));
					if (ret == null)
					{
						result = -6;
						goto IL_016d;
					}
					inline_memcpy_void_void_const_unsigned_long.Invoke(*(void**)ret, printf_core_WriteBuffer2.buff, num);
				}
				else
				{
					*(void**)ret = printf_core_WriteBuffer2.buff;
				}
				*(sbyte*)((nint)(*(IntPtr*)ret) + num) = 0;
				result = num;
			}
			goto IL_016d;
		}
		IL_016d:
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(16L, &printf_core_Writer2);
		llvm_lifetime_end_p0.Invoke(56L, &printf_core_WriteBuffer2);
		llvm_lifetime_end_p0.Invoke(200L, &inlineArray200_SByte);
		return result;
	}
}
