using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7intlogbIlfEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EET_E4typeES4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, long>::type __llvm_libc_20_1_2_::fputil::intlogb<long, float>(float)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_float_long_type_fputil_intlogb_long_float_float
{
	public unsafe static long Invoke(float x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_DyadicFloat_c8qpxg fputil_DyadicFloat_c8qpxg2 = default(fputil_DyadicFloat_c8qpxg);
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			long result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((!fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero_const.Invoke(&fputil_FPBits_5nkvcs2)) ? fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan_const.Invoke(&fputil_FPBits_5nkvcs2) : true, expected: false))
			{
				fputil_set_errno_if_required_int.Invoke(33);
				fputil_raise_except_if_required_int.Invoke(1);
				result = ((!fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero_const.Invoke(&fputil_FPBits_5nkvcs2)) ? ((!fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan_const.Invoke(&fputil_FPBits_5nkvcs2)) ? long.MaxValue : (-2147483648L)) : (-2147483648L));
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(12L, &fputil_DyadicFloat_c8qpxg2);
				*(sbyte*)(&fputil_DyadicFloat_c8qpxg2) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_c8qpxg2) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_c8qpxg2))[1] = -1431655766;
				((int*)(&fputil_DyadicFloat_c8qpxg2))[2] = -1431655766;
				fputil_DyadicFloat_32ul_DyadicFloat_float_0_float.Invoke(&fputil_DyadicFloat_c8qpxg2, fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2));
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = fputil_DyadicFloat_32ul_get_unbiased_exponent_const.Invoke(&fputil_DyadicFloat_c8qpxg2);
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
				llvm_lifetime_end_p0.Invoke(12L, &fputil_DyadicFloat_c8qpxg2);
			}
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
