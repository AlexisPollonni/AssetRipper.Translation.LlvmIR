using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_sub_double_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic3subIdeEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS5_stS6_ES5_E4typeES6_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<long double> && sizeof (double) <= sizeof (long double), double>::type __llvm_libc_20_1_2_::fputil::generic::sub<double, long double>(long double, long double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<long double> && sizeof (double) <= sizeof (long double), double>::type")]
	public static double Invoke([MangledName("x")][NativeType("long double")] double X, [MangledName("y")][NativeType("long double")] double Y)
	{
		return Generic_add_or_sub_true_double_long_double.Invoke(X, Y);
	}
}
