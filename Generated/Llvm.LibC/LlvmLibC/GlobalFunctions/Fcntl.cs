using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Intrinsics.Unimplemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fcntl
{
	[MangledName("fcntl")]
	[DemangledName("fcntl")]
	public unsafe static int Invoke([MangledName("fd")] int Fd, [MangledName("cmd")] int Cmd, ReadOnlySpan<nint> args)
	{
		void* parameter_ = null;
		InlineArray1_Va_list_tag inlineArray1_Va_list_tag = default(InlineArray1_Va_list_tag);
		Llvm_lifetime_start_p0.Invoke(8L, &parameter_);
		unchecked
		{
			parameter_ = (void*)12297829382473034410uL;
			Llvm_lifetime_start_p0.Invoke(24L, &inlineArray1_Va_list_tag);
			Va_list_tag* ptr = (Va_list_tag*)(&inlineArray1_Va_list_tag);
			*(int*)ptr = -1431655766;
			((int*)ptr)[1] = -1431655766;
			*(IntPtr*)((byte*)ptr + 8) = unchecked((nint)(-6148914691236517206L));
			*(IntPtr*)((byte*)ptr + 16) = unchecked((nint)(-6148914691236517206L));
			InstructionHelper.VAStart((void**)(&inlineArray1_Va_list_tag), args);
			Va_list_tag* ptr2 = (Va_list_tag*)(&inlineArray1_Va_list_tag);
			int* gp_offset = &ptr2->Gp_offset;
			int num = *gp_offset;
			nint num2;
			if ((uint)num <= 40u)
			{
				num2 = (nint)((byte*)ptr2->Reg_save_area + num);
				*gp_offset = num + 8;
			}
			else
			{
				void** overflow_arg_area = &ptr2->Overflow_arg_area;
				void* ptr3 = *overflow_arg_area;
				*overflow_arg_area = (byte*)ptr3 + 8;
				num2 = (nint)ptr3;
			}
			parameter_ = *(void**)num2;
			int result = Internal_fcntl.Invoke(Fd, Cmd, parameter_);
			Llvm_lifetime_end_p0.Invoke(24L, &inlineArray1_Va_list_tag);
			Llvm_lifetime_end_p0.Invoke(8L, &parameter_);
			return result;
		}
	}
}
