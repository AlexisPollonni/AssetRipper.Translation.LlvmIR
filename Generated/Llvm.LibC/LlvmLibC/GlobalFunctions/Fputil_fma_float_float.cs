using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_fma_float_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIffEET_T0_S3_S3_")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::fma<float, float>(float, float, float)")]
	[return: NativeType("float")]
	public static float Invoke([MangledName("x")][NativeType("float")] float X, [MangledName("y")][NativeType("float")] float Y, [MangledName("z")][NativeType("float")] float Z)
	{
		return Generic_fma_float_float.Invoke(X, Y, Z);
	}
}
