using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_fma_float_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIfeEET_T0_S3_S3_")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::fma<float, long double>(long double, long double, long double)")]
	[return: NativeType("float")]
	public static float Invoke([MangledName("x")][NativeType("long double")] double X, [MangledName("y")][NativeType("long double")] double Y, [MangledName("z")][NativeType("long double")] double Z)
	{
		return Generic_fma_float_long_double.Invoke(X, Y, Z);
	}
}
