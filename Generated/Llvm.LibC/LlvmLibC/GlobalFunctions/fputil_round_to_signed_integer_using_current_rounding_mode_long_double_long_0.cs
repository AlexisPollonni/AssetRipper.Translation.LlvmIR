using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_round_to_signed_integer_using_current_rounding_mode_long_double_long_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil51round_to_signed_integer_using_current_rounding_modeIelTnNS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EEiE4typeELi0EEES5_S4_")]
	[DemangledName("long __llvm_libc_20_1_2_::fputil::round_to_signed_integer_using_current_rounding_mode<long double, long, 0>(long double)")]
	[return: NativeType("long")]
	public static long Invoke([NativeType("long double")] double x)
	{
		return internal_rounded_float_to_signed_integer_long_double_long_0.Invoke(fputil_round_using_current_rounding_mode_long_double.Invoke(x));
	}
}
