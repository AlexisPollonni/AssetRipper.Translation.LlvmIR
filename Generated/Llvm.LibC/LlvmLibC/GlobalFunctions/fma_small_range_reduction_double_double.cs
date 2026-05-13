using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3fma21small_range_reductionEdRd")]
[DemangledName("__llvm_libc_20_1_2_::fma::small_range_reduction(double, double&)")]
internal static partial class fma_small_range_reduction_double_double
{
	public unsafe static long Invoke(double x, void* y)
	{
		double num = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = fputil_nearest_integer_double.Invoke(x * *(double*)fma_THIRTYTWO_OVER_PI.Pointer);
			*(double*)y = double_fputil_fma_double_double_double_double_double.Invoke(x, *(double*)fma_THIRTYTWO_OVER_PI.Pointer, 0.0 - num);
			*(double*)y = double_fputil_fma_double_double_double_double_double.Invoke(x, ((double*)fma_THIRTYTWO_OVER_PI.Pointer)[1], *(double*)y);
			long result = (long)num;
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
