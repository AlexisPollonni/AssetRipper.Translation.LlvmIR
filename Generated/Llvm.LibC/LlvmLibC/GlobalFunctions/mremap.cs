using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class mremap
{
	public unsafe static void* Invoke(void* old_address, long old_size, long new_size, int flags, ReadOnlySpan<nint> args)
	{
		long num = 0L;
		void* ts_4jbuhx = null;
		InlineArray1_va_list_tag inlineArray1_va_list_tag = default(InlineArray1_va_list_tag);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &ts_4jbuhx);
		ts_4jbuhx = null;
		unchecked
		{
			if ((flags & 2) != 0)
			{
				llvm_lifetime_start_p0.Invoke(24L, &inlineArray1_va_list_tag);
				va_list_tag* ptr = (va_list_tag*)(&inlineArray1_va_list_tag);
				*(int*)ptr = -1431655766;
				((int*)ptr)[1] = -1431655766;
				*(IntPtr*)((byte*)ptr + 8) = unchecked((nint)(-6148914691236517206L));
				*(IntPtr*)((byte*)ptr + 16) = unchecked((nint)(-6148914691236517206L));
				InstructionHelper.VAStart((void**)(&inlineArray1_va_list_tag), args);
				va_list_tag* ptr2 = (va_list_tag*)(&inlineArray1_va_list_tag);
				int* gp_offset = &ptr2->gp_offset;
				int num2 = *gp_offset;
				nint num3;
				if ((uint)num2 <= 40u)
				{
					num3 = (nint)((byte*)ptr2->reg_save_area + num2);
					*gp_offset = num2 + 8;
				}
				else
				{
					void** overflow_arg_area = &ptr2->overflow_arg_area;
					void* ptr3 = *overflow_arg_area;
					*overflow_arg_area = (byte*)ptr3 + 8;
					num3 = (nint)ptr3;
				}
				ts_4jbuhx = *(void**)num3;
				llvm_lifetime_end_p0.Invoke(24L, &inlineArray1_va_list_tag);
			}
			num = long_syscall_impl_long_void_unsigned_long_unsigned_long_int_void_long_void_unsigned_long_unsigned_long_int_void.Invoke(25L, old_address, old_size, new_size, flags, ts_4jbuhx);
			void* result;
			if (num < 0L && num > -4096L)
			{
				Errno_operator_int_dntwiy.Invoke(a: (int)checked(-num), @this: libc_errno.Pointer);
				result = (void*)ulong.MaxValue;
			}
			else
			{
				result = (void*)num;
			}
			llvm_lifetime_end_p0.Invoke(8L, &ts_4jbuhx);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
