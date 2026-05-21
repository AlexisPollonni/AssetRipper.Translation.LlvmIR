using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_round_to_signed_integer_long_double_long_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil23round_to_signed_integerIelTnNS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EEiE4typeELi0EEES5_S4_")]
	[DemangledName("long __llvm_libc_20_1_2_::fputil::round_to_signed_integer<long double, long, 0>(long double)")]
	[return: NativeType("long")]
	public static long Invoke([NativeType("long double")] double x)
	{
		return internal_rounded_float_to_signed_integer_long_double_long_0.Invoke(fputil_round_long_double_0.Invoke(x));
	}
}
