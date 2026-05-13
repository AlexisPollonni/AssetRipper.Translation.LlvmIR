using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil23round_to_signed_integerIdlTnNS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EEiE4typeELi0EEES5_S4_")]
[DemangledName("long __llvm_libc_20_1_2_::fputil::round_to_signed_integer<double, long, 0>(double)")]
internal static partial class long_fputil_round_to_signed_integer_double_long_0_double
{
	public static long Invoke(double x)
	{
		return long_fputil_internal_rounded_float_to_signed_integer_double_long_0_double.Invoke(double_fputil_round_double_0_double.Invoke(x));
	}
}
