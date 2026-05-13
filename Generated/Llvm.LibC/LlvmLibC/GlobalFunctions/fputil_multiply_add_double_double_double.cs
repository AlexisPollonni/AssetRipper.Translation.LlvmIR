using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Unimplemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12multiply_addEddd")]
[DemangledName("__llvm_libc_20_1_2_::fputil::multiply_add(double, double, double)")]
internal static partial class fputil_multiply_add_double_double_double
{
	public static double Invoke(double x, double y, double z)
	{
		return llvm_fma_f64.Invoke(x, y, z);
	}
}
