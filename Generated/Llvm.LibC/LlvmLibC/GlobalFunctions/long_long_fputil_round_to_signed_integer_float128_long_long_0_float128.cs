using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil23round_to_signed_integerIgxTnNS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EEiE4typeELi0EEES5_S4_")]
[DemangledName("long long __llvm_libc_20_1_2_::fputil::round_to_signed_integer<__float128, long long, 0>(__float128)")]
internal static partial class long_long_fputil_round_to_signed_integer_float128_long_long_0_float128
{
	public static long Invoke(double x)
	{
		return long_long_fputil_internal_rounded_float_to_signed_integer_float128_long_long_0_float128.Invoke(float128_fputil_round_float128_0_float128.Invoke(x));
	}
}
