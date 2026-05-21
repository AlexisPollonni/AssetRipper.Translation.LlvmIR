using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_cast_double_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4castIddEENS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_EES4_E4typeES5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<double>, double>::type __llvm_libc_20_1_2_::fputil::cast<double, double>(double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double> && cpp::is_floating_point_v<double>, double>::type")]
	public static double Invoke([MangledName("x")][NativeType("double")] double X)
	{
		return X;
	}
}
