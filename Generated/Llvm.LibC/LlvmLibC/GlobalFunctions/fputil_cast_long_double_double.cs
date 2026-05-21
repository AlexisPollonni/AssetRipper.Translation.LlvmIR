using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_cast_long_double_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4castIedEENS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_EES4_E4typeES5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double> && cpp::is_floating_point_v<double>, long double>::type __llvm_libc_20_1_2_::fputil::cast<long double, double>(double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<long double> && cpp::is_floating_point_v<double>, long double>::type")]
	public static double Invoke([NativeType("double")] double x)
	{
		return x;
	}
}
