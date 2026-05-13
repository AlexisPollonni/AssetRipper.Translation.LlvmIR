using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3fmaIddEET_T0_S3_S3_")]
[DemangledName("double __llvm_libc_20_1_2_::fputil::fma<double, double>(double, double, double)")]
internal static partial class double_fputil_fma_double_double_double_double_double
{
	public static double Invoke(double x, double y, double z)
	{
		return llvm_fma_f64.Invoke(x, y, z);
	}
}
