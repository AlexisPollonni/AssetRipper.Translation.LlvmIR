using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_intlogb_int_Float16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7intlogbIiDF16_EENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EET_E4typeES4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, int>::type __llvm_libc_20_1_2_::fputil::intlogb<int, _Float16>(_Float16)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, int>::type")]
	public unsafe static int Invoke([MangledName("x")][NativeType("_Float16")] Half X)
	{
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm = default(Llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm);
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva, X);
			int result;
			if (Details_expects_bool_condition_bool.Invoke((!FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva))) ? FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva)) : true, Expected: false))
			{
				Fputil_set_errno_if_required.Invoke(33);
				Fputil_raise_except_if_required.Invoke(1);
				result = ((!FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva))) ? ((!FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva))) ? int.MaxValue : int.MinValue) : int.MinValue);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm);
				*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm) = -86;
				sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm))[1] = -1431655766;
				((short*)(&llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm))[4] = -21846;
				sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm) + 10;
				*ptr2 = -86;
				ptr2[1] = -86;
				DyadicFloat_16ul_DyadicFloat_Float16_0.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm, FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva));
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = DyadicFloat_16ul_get_unbiased_exponent.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm);
				if (Details_expects_bool_condition_bool.Invoke((num <= int.MaxValue) ? (num < int.MinValue) : true, Expected: false))
				{
					Fputil_set_errno_if_required.Invoke(34);
					Fputil_raise_except_if_required.Invoke(1);
					result = InstructionHelper.Select(num > 0, int.MaxValue, int.MinValue);
				}
				else
				{
					result = num;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num);
				Llvm_lifetime_end_p0.Invoke(12L, &llvm_libc_20_1_2_fputil_DyadicFloat_jvghxm);
			}
			Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
			return result;
		}
	}
}
