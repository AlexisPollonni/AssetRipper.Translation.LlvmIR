using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_fma_double_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIdeEET_T0_S3_S3_")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::fma<double, long double>(long double, long double, long double)")]
	[return: NativeType("double")]
	public static double Invoke([MangledName("x")][NativeType("long double")] double X, [MangledName("y")][NativeType("long double")] double Y, [MangledName("z")][NativeType("long double")] double Z)
	{
		return Generic_fma_double_long_double.Invoke(X, Y, Z);
	}
}
