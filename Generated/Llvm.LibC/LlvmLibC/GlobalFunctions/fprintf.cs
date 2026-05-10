using System;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fprintf
{
	public unsafe static int Invoke(void* stream, void* format, ReadOnlySpan<nint> args)
	{
		InlineArray1_va_list_tag inlineArray1_va_list_tag = default(InlineArray1_va_list_tag);
		internal_ArgList internal_ArgList2 = default(internal_ArgList);
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
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = printf_core_vfprintf_internal_IO_FILE_char_const_internal_ArgList.Invoke(stream, format, &internal_ArgList2);
			int result = num;
			llvm_lifetime_end_p0.Invoke(4L, &num);
			internal_ArgList_ArgList.Invoke(&internal_ArgList2);
			llvm_lifetime_end_p0.Invoke(24L, &internal_ArgList2);
			llvm_lifetime_end_p0.Invoke(24L, &inlineArray1_va_list_tag);
			return result;
		}
	}
}
