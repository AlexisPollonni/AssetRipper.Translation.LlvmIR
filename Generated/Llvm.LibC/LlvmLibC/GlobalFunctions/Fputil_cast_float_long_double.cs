using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_cast_float_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4castIfeEENS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_EES4_E4typeES5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<long double>, float>::type __llvm_libc_20_1_2_::fputil::cast<float, long double>(long double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<long double>, float>::type")]
	public static float Invoke([MangledName("x")][NativeType("long double")] double X)
	{
		return (float)X;
	}
}
