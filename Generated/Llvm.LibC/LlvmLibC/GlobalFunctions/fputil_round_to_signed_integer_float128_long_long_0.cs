using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_round_to_signed_integer_float128_long_long_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil23round_to_signed_integerIgxTnNS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EEiE4typeELi0EEES5_S4_")]
	[DemangledName("long long __llvm_libc_20_1_2_::fputil::round_to_signed_integer<__float128, long long, 0>(__float128)")]
	[return: NativeType("long long")]
	public static long Invoke([NativeType("__float128")] double x)
	{
		return internal_rounded_float_to_signed_integer_float128_long_long_0.Invoke(fputil_round_float128_0.Invoke(x));
	}
}
