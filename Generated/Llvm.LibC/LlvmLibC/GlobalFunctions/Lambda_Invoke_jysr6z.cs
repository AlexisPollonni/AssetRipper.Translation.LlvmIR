using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Lambda_Invoke_jysr6z
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_6fputil8internal31rounded_float_to_signed_integerIDF16_xTnNS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EEiE4typeELi0EEES6_S5_ENKUlvE_clEv")]
	[DemangledName("long long __llvm_libc_20_1_2_::fputil::internal::rounded_float_to_signed_integer<_Float16, long long, 0>(_Float16)::'lambda'()::operator()() const")]
	[CleanName("Lambda_Invoke")]
	[return: NativeType("long long")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		Fputil_set_errno_if_required.Invoke(33);
		Fputil_raise_except_if_required.Invoke(1);
	}
}
