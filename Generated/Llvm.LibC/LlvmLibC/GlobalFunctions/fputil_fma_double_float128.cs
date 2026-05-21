using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_fma_double_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIdgEET_T0_S3_S3_")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::fma<double, __float128>(__float128, __float128, __float128)")]
	[return: NativeType("double")]
	public static double Invoke([NativeType("__float128")] double x, [NativeType("__float128")] double y, [NativeType("__float128")] double z)
	{
		return generic_fma_double_float128.Invoke(x, y, z);
	}
}
