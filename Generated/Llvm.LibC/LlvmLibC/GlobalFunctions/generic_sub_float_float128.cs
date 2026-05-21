using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_sub_float_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3subIfgEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<__float128> && sizeof (float) <= sizeof (__float128), float>::type __llvm_libc_20_1_2_::fputil::generic::sub<float, __float128>(__float128, __float128)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<__float128> && sizeof (float) <= sizeof (__float128), float>::type")]
	public static float Invoke([NativeType("__float128")] double x, [NativeType("__float128")] double y)
	{
		return generic_add_or_sub_true_float_float128.Invoke(x, y);
	}
}
