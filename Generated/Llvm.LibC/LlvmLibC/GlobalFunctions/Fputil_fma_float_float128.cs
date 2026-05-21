using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_fma_float_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIfgEET_T0_S3_S3_")]
	[DemangledName("float __llvm_libc_20_1_2_::fputil::fma<float, __float128>(__float128, __float128, __float128)")]
	[return: NativeType("float")]
	public static float Invoke([MangledName("x")][NativeType("__float128")] double X, [MangledName("y")][NativeType("__float128")] double Y, [MangledName("z")][NativeType("__float128")] double Z)
	{
		return Generic_fma_float_float128.Invoke(X, Y, Z);
	}
}
