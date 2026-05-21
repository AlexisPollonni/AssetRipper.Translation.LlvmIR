using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class lambda_Invoke_4rnd3b
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_6fputil8internal31rounded_float_to_signed_integerIfxTnNS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EEiE4typeELi0EEES6_S5_ENKUlvE_clEv")]
	[DemangledName("long long __llvm_libc_20_1_2_::fputil::internal::rounded_float_to_signed_integer<float, long long, 0>(float)::'lambda'()::operator()() const")]
	[CleanName("lambda_Invoke")]
	[return: NativeType("long long")]
	public unsafe static void Invoke(void* @this)
	{
		fputil_set_errno_if_required.Invoke(33);
		fputil_raise_except_if_required.Invoke(1);
	}
}
