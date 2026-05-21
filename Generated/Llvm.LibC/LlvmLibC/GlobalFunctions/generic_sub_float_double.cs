using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_sub_float_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3subIfdEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<double> && sizeof (float) <= sizeof (double), float>::type __llvm_libc_20_1_2_::fputil::generic::sub<float, double>(double, double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<double> && sizeof (float) <= sizeof (double), float>::type")]
	public static float Invoke([NativeType("double")] double x, [NativeType("double")] double y)
	{
		return generic_add_or_sub_true_float_double.Invoke(x, y);
	}
}
