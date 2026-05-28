using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Open
{
	public unsafe static readonly void* __pointer = (delegate*<void*, int, ReadOnlySpan<nint>, int>)(&Invoke);

	[MangledName("open")]
	[DemangledName("open")]
	public unsafe static int Invoke([MangledName("path")] void* Path, [MangledName("flags")] int Flags, ReadOnlySpan<nint> args)
	{
		int ts_w24gdx = 0;
		InlineArray1_Va_list_tag inlineArray1_Va_list_tag = default(InlineArray1_Va_list_tag);
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &ts_w24gdx);
		ts_w24gdx = 0;
		unchecked
		{
			if ((Flags & 0x40) != 0 || (Flags & 0x410000) == 4259840)
			{
				Llvm_lifetime_start_p0.Invoke(24L, &inlineArray1_Va_list_tag);
				Va_list_tag* ptr = (Va_list_tag*)(&inlineArray1_Va_list_tag);
				*(int*)ptr = -1431655766;
				((int*)ptr)[1] = -1431655766;
				*(IntPtr*)((byte*)ptr + 8) = unchecked((nint)(-6148914691236517206L));
				*(IntPtr*)((byte*)ptr + 16) = unchecked((nint)(-6148914691236517206L));
				InstructionHelper.VAStart((void**)(&inlineArray1_Va_list_tag), args);
				Va_list_tag* ptr2 = (Va_list_tag*)(&inlineArray1_Va_list_tag);
				int* gp_offset = &ptr2->Gp_offset;
				int num2 = *gp_offset;
				nint num3;
				if ((uint)num2 <= 40u)
				{
					num3 = (nint)((byte*)ptr2->Reg_save_area + num2);
					*gp_offset = num2 + 8;
				}
				else
				{
					void** overflow_arg_area = &ptr2->Overflow_arg_area;
					void* ptr3 = *overflow_arg_area;
					*overflow_arg_area = (byte*)ptr3 + 8;
					num3 = (nint)ptr3;
				}
				ts_w24gdx = *(int*)num3;
				Llvm_lifetime_end_p0.Invoke(24L, &inlineArray1_Va_list_tag);
			}
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = Syscall_impl_int_char_const_int_unsigned_int.Invoke(2L, Path, Flags, ts_w24gdx);
		}
		int result;
		if (num > 0)
		{
			result = num;
		}
		else
		{
			Errno_Assignment.Invoke(A: -num, This: Libc_errno.Pointer);
			result = -1;
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(4L, &ts_w24gdx);
		return result;
	}
}
