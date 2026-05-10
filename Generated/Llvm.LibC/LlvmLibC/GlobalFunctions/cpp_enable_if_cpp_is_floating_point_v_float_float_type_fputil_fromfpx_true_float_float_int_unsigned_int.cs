using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7fromfpxILb1EfEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EES4_E4typeES4_ij")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float>, float>::type __llvm_libc_20_1_2_::fputil::fromfpx<true, float>(float, int, unsigned int)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_float_float_type_fputil_fromfpx_true_float_float_int_unsigned_int
{
	public unsafe static float Invoke(float x, int rnd, int width)
	{
		float num = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = cpp_enable_if_cpp_is_floating_point_v_float_float_type_fputil_fromfp_true_float_float_int_unsigned_int.Invoke(x, rnd, width);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		*unchecked((int*)(&fputil_FPBits_5nkvcs2)) = -1431655766;
		fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, num);
		if (!fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan_const.Invoke(&fputil_FPBits_5nkvcs2) && NumericHelper.IsUnorderedOrNotEquals(num, x))
		{
			fputil_raise_except_if_required_int.Invoke(32);
		}
		float result = num;
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
