using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7intlogbIldEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EET_E4typeES4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double>, long>::type __llvm_libc_20_1_2_::fputil::intlogb<long, double>(double)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_double_long_type_fputil_intlogb_long_double_double
{
	public unsafe static long Invoke(double x)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_DyadicFloat_374hpp fputil_DyadicFloat_374hpp2 = default(fputil_DyadicFloat_374hpp);
		int num = 0;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x);
			long result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((!fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2))) ? fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) : true, expected: false))
			{
				fputil_set_errno_if_required_int.Invoke(33);
				fputil_raise_except_if_required_int.Invoke(1);
				result = ((!fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2))) ? ((!fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2))) ? long.MaxValue : (-2147483648L)) : (-2147483648L));
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(16L, &fputil_DyadicFloat_374hpp2);
				*(sbyte*)(&fputil_DyadicFloat_374hpp2) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_374hpp2) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_374hpp2))[1] = -1431655766;
				((long*)(&fputil_DyadicFloat_374hpp2))[1] = -6148914691236517206L;
				fputil_DyadicFloat_64ul_DyadicFloat_double_0_double.Invoke(&fputil_DyadicFloat_374hpp2, fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2));
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = fputil_DyadicFloat_64ul_get_unbiased_exponent_const.Invoke(&fputil_DyadicFloat_374hpp2);
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
				llvm_lifetime_end_p0.Invoke(16L, &fputil_DyadicFloat_374hpp2);
			}
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}
