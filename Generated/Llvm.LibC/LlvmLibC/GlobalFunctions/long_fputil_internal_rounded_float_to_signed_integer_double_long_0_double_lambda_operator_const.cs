using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZZN19__llvm_libc_20_1_2_6fputil8internal31rounded_float_to_signed_integerIdlTnNS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EEiE4typeELi0EEES6_S5_ENKUlvE_clEv")]
[DemangledName("long __llvm_libc_20_1_2_::fputil::internal::rounded_float_to_signed_integer<double, long, 0>(double)::'lambda'()::operator()() const")]
internal static partial class long_fputil_internal_rounded_float_to_signed_integer_double_long_0_double_lambda_operator_const
{
	public unsafe static void Invoke(void* @this)
	{
		fputil_set_errno_if_required_int.Invoke(33);
		fputil_raise_except_if_required_int.Invoke(1);
	}
}
