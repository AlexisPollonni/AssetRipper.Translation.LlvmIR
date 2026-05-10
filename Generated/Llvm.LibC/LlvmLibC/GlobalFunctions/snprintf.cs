using System;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class snprintf
{
	public unsafe static int Invoke(void* buffer, long buffsz, void* format, ReadOnlySpan<nint> args)
	{
		InlineArray1_va_list_tag inlineArray1_va_list_tag = default(InlineArray1_va_list_tag);
		internal_ArgList internal_ArgList2 = default(internal_ArgList);
		printf_core_WriteBuffer printf_core_WriteBuffer2 = default(printf_core_WriteBuffer);
		printf_core_Writer printf_core_Writer2 = default(printf_core_Writer);
		int num = 0;
		llvm_lifetime_start_p0.Invoke(24L, &inlineArray1_va_list_tag);
		unchecked
		{
			va_list_tag* ptr = (va_list_tag*)(&inlineArray1_va_list_tag);
			*(int*)ptr = -1431655766;
			((int*)ptr)[1] = -1431655766;
			*(IntPtr*)((byte*)ptr + 8) = unchecked((nint)(-6148914691236517206L));
			*(IntPtr*)((byte*)ptr + 16) = unchecked((nint)(-6148914691236517206L));
			InstructionHelper.VAStart((void**)(&inlineArray1_va_list_tag), args);
			llvm_lifetime_start_p0.Invoke(24L, &internal_ArgList2);
			va_list_tag* ptr2 = (va_list_tag*)(&internal_ArgList2);
			*(int*)ptr2 = -1431655766;
			((int*)ptr2)[1] = -1431655766;
			*(IntPtr*)((byte*)ptr2 + 8) = unchecked((nint)(-6148914691236517206L));
			*(IntPtr*)((byte*)ptr2 + 16) = unchecked((nint)(-6148914691236517206L));
			internal_ArgList_ArgList_va_list_tag.Invoke(&internal_ArgList2, &inlineArray1_va_list_tag);
			llvm_lifetime_start_p0.Invoke(56L, &printf_core_WriteBuffer2);
			llvm_memset_p0_i64.Invoke(&printf_core_WriteBuffer2, -86, 56L, isVolatile: false);
			printf_core_WriteBuffer_WriteBuffer_char_unsigned_long.Invoke(&printf_core_WriteBuffer2, buffer, ((ulong)buffsz <= 0uL) ? 0L : (buffsz - 1L));
			llvm_lifetime_start_p0.Invoke(16L, &printf_core_Writer2);
			*(IntPtr*)(&printf_core_Writer2) = unchecked((nint)(-6148914691236517206L));
			((int*)(&printf_core_Writer2))[2] = -1431655766;
			sbyte* ptr3 = (sbyte*)(&printf_core_Writer2) + 12;
			*ptr3 = -86;
			ptr3[1] = -86;
			ptr3[2] = -86;
			ptr3[3] = -86;
			printf_core_Writer_Writer_printf_core_WriteBuffer.Invoke(&printf_core_Writer2, &printf_core_WriteBuffer2);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = printf_core_printf_main_printf_core_Writer_char_const_internal_ArgList.Invoke(&printf_core_Writer2, format, &internal_ArgList2);
			if ((ulong)buffsz > 0uL)
			{
				((sbyte*)printf_core_WriteBuffer2.buff)[printf_core_WriteBuffer2.buff_cur] = 0;
			}
			int result = num;
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(16L, &printf_core_Writer2);
			llvm_lifetime_end_p0.Invoke(56L, &printf_core_WriteBuffer2);
			internal_ArgList_ArgList.Invoke(&internal_ArgList2);
			llvm_lifetime_end_p0.Invoke(24L, &internal_ArgList2);
			llvm_lifetime_end_p0.Invoke(24L, &inlineArray1_va_list_tag);
			return result;
		}
	}
}
