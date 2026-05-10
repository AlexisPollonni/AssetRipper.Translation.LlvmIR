using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil23round_to_signed_integerIflTnNS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EEiE4typeELi0EEES5_S4_")]
[DemangledName("long __llvm_libc_20_1_2_::fputil::round_to_signed_integer<float, long, 0>(float)")]
internal static partial class long_fputil_round_to_signed_integer_float_long_0_float
{
	public static long Invoke(float x)
	{
		return long_fputil_internal_rounded_float_to_signed_integer_float_long_0_float.Invoke(float_fputil_round_float_0_float.Invoke(x));
	}
}
