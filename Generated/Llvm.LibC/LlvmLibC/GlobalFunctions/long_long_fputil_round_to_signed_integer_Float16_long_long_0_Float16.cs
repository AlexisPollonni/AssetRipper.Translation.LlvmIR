using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil23round_to_signed_integerIDF16_xTnNS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EEiE4typeELi0EEES5_S4_")]
[DemangledName("long long __llvm_libc_20_1_2_::fputil::round_to_signed_integer<_Float16, long long, 0>(_Float16)")]
internal static partial class long_long_fputil_round_to_signed_integer_Float16_long_long_0_Float16
{
	public static long Invoke(Half x)
	{
		return long_long_fputil_internal_rounded_float_to_signed_integer_Float16_long_long_0_Float16.Invoke(Float16_fputil_round_Float16_0_Float16.Invoke(x));
	}
}
