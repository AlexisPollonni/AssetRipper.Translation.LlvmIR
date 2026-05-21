using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_round_to_signed_integer_float_long_long_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil23round_to_signed_integerIfxTnNS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EEiE4typeELi0EEES5_S4_")]
	[DemangledName("long long __llvm_libc_20_1_2_::fputil::round_to_signed_integer<float, long long, 0>(float)")]
	[return: NativeType("long long")]
	public static long Invoke([MangledName("x")][NativeType("float")] float X)
	{
		return Internal_rounded_float_to_signed_integer_float_long_long_0.Invoke(Fputil_round_float_0.Invoke(X));
	}
}
