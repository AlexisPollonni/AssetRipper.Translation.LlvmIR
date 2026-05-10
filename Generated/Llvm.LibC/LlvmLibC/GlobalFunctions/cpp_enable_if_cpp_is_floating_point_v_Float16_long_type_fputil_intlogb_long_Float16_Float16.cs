using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7intlogbIlDF16_EENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EET_E4typeES4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, long>::type __llvm_libc_20_1_2_::fputil::intlogb<long, _Float16>(_Float16)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_Float16_long_type_fputil_intlogb_long_Float16_Float16
{
	public unsafe static long Invoke(Half x)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		fputil_DyadicFloat_jvghxm fputil_DyadicFloat_jvghxm2 = default(fputil_DyadicFloat_jvghxm);
		int num = 0;
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva2, x);
			long result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((!fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero_const.Invoke(&fputil_FPBits_2fahva2)) ? fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan_const.Invoke(&fputil_FPBits_2fahva2) : true, expected: false))
			{
				fputil_set_errno_if_required_int.Invoke(33);
				fputil_raise_except_if_required_int.Invoke(1);
				result = ((!fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero_const.Invoke(&fputil_FPBits_2fahva2)) ? ((!fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan_const.Invoke(&fputil_FPBits_2fahva2)) ? long.MaxValue : (-2147483648L)) : (-2147483648L));
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(12L, &fputil_DyadicFloat_jvghxm2);
				*(sbyte*)(&fputil_DyadicFloat_jvghxm2) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_jvghxm2) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_jvghxm2))[1] = -1431655766;
				((short*)(&fputil_DyadicFloat_jvghxm2))[4] = -21846;
				sbyte* ptr2 = (sbyte*)(&fputil_DyadicFloat_jvghxm2) + 10;
				*ptr2 = -86;
				ptr2[1] = -86;
				fputil_DyadicFloat_16ul_DyadicFloat_Float16_0_Float16.Invoke(&fputil_DyadicFloat_jvghxm2, fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva2));
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = fputil_DyadicFloat_16ul_get_unbiased_exponent_const.Invoke(&fputil_DyadicFloat_jvghxm2);
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((num <= long.MaxValue) ? (num < long.MinValue) : true, expected: false))
				{
					fputil_set_errno_if_required_int.Invoke(34);
					fputil_raise_except_if_required_int.Invoke(1);
					result = InstructionHelper.Select(num > 0, long.MaxValue, long.MinValue);
				}
				else
				{
					result = num;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
				llvm_lifetime_end_p0.Invoke(12L, &fputil_DyadicFloat_jvghxm2);
			}
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result;
		}
	}
}
