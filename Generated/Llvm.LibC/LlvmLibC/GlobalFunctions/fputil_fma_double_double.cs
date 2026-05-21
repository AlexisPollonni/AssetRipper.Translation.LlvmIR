using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_fma_double_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIddEET_T0_S3_S3_")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::fma<double, double>(double, double, double)")]
	[return: NativeType("double")]
	public static double Invoke([NativeType("double")] double x, [NativeType("double")] double y, [NativeType("double")] double z)
	{
		return generic_fma_double_double.Invoke(x, y, z);
	}
}
