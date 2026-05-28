using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Mremap
{
	[MangledName("mremap")]
	[DemangledName("mremap")]
	public unsafe static void* Invoke([MangledName("old_address")] void* Old_address, [MangledName("old_size")] long Old_size, [MangledName("new_size")] long New_size, [MangledName("flags")] int Flags, ReadOnlySpan<nint> args)
	{
		long num = 0L;
		void* ts_4jbuhx = null;
		InlineArray1_Va_list_tag inlineArray1_Va_list_tag = default(InlineArray1_Va_list_tag);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &ts_4jbuhx);
		ts_4jbuhx = null;
		unchecked
		{
			if ((Flags & 2) != 0)
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
				ts_4jbuhx = *(void**)num3;
				Llvm_lifetime_end_p0.Invoke(24L, &inlineArray1_Va_list_tag);
			}
			num = Syscall_impl_long_void_unsigned_long_unsigned_long_int_void.Invoke(25L, Old_address, Old_size, New_size, Flags, ts_4jbuhx);
			void* result;
			if (num < 0L && num > -4096L)
			{
				Errno_Assignment.Invoke(A: (int)checked(-num), This: Libc_errno.Pointer);
				result = (void*)ulong.MaxValue;
			}
			else
			{
				result = (void*)num;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &ts_4jbuhx);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
