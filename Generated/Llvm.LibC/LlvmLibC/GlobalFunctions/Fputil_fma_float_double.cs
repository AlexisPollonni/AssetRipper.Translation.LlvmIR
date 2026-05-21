using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_fma_float_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIfdEET_T0_S3_S3_")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::fma<float, double>(double, double, double)")]
	[return: NativeType("float")]
	public static float Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("y")][NativeType("double")] double Y, [MangledName("z")][NativeType("double")] double Z)
	{
		return Generic_fma_float_double.Invoke(X, Y, Z);
	}
}
