using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_sub_float_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3subIfeEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<long double> && sizeof (float) <= sizeof (long double), float>::type __llvm_libc_20_1_2_::fputil::generic::sub<float, long double>(long double, long double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<long double> && sizeof (float) <= sizeof (long double), float>::type")]
	public static float Invoke([NativeType("long double")] double x, [NativeType("long double")] double y)
	{
		return generic_add_or_sub_true_float_long_double.Invoke(x, y);
	}
}
