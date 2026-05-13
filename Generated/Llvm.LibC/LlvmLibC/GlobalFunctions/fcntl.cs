using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Intrinsics.Unimplemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fcntl
{
	public unsafe static int Invoke(int fd, int cmd, ReadOnlySpan<nint> args)
	{
		void* parameter_ = null;
		InlineArray1_va_list_tag inlineArray1_va_list_tag = default(InlineArray1_va_list_tag);
		llvm_lifetime_start_p0.Invoke(8L, &parameter_);
		unchecked
		{
			parameter_ = (void*)12297829382473034410uL;
			llvm_lifetime_start_p0.Invoke(24L, &inlineArray1_va_list_tag);
			va_list_tag* ptr = (va_list_tag*)(&inlineArray1_va_list_tag);
			*(int*)ptr = -1431655766;
			((int*)ptr)[1] = -1431655766;
			*(IntPtr*)((byte*)ptr + 8) = unchecked((nint)(-6148914691236517206L));
			*(IntPtr*)((byte*)ptr + 16) = unchecked((nint)(-6148914691236517206L));
			InstructionHelper.VAStart((void**)(&inlineArray1_va_list_tag), args);
			va_list_tag* ptr2 = (va_list_tag*)(&inlineArray1_va_list_tag);
			int* gp_offset = &ptr2->gp_offset;
			int num = *gp_offset;
			nint num2;
			if ((uint)num <= 40u)
			{
				num2 = (nint)((byte*)ptr2->reg_save_area + num);
				*gp_offset = num + 8;
			}
			else
			{
				void** overflow_arg_area = &ptr2->overflow_arg_area;
				void* ptr3 = *overflow_arg_area;
				*overflow_arg_area = (byte*)ptr3 + 8;
				num2 = (nint)ptr3;
			}
			parameter_ = *(void**)num2;
			int result = internal_fcntl_int_int_void.Invoke(fd, cmd, parameter_);
			llvm_lifetime_end_p0.Invoke(24L, &inlineArray1_va_list_tag);
			llvm_lifetime_end_p0.Invoke(8L, &parameter_);
			return result;
		}
	}
}
