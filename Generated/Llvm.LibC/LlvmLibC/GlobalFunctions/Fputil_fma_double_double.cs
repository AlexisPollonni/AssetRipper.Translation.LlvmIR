using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_fma_double_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIddEET_T0_S3_S3_")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::fma<double, double>(double, double, double)")]
	[return: NativeType("double")]
	public static double Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("y")][NativeType("double")] double Y, [MangledName("z")][NativeType("double")] double Z)
	{
		return Generic_fma_double_double.Invoke(X, Y, Z);
	}
}
