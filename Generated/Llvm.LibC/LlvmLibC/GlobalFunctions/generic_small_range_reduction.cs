using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_small_range_reduction
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic21small_range_reductionEdRd")]
	[DemangledName("__llvm_libc_20_1_2_::generic::small_range_reduction(double, double&)")]
	public unsafe static long Invoke([NativeType("double")] double x, [NativeType("double&")] void* y)
	{
		double num = 0.0;
		double num2 = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = x * *(double*)generic_THIRTYTWO_OVER_PI_28.Pointer;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = fputil_nearest_integer.Invoke(num);
			*(double*)y = num - num2;
			*(double*)y = fputil_multiply_add_double.Invoke(x, ((double*)generic_THIRTYTWO_OVER_PI_28.Pointer)[1], *(double*)y);
			*(double*)y = fputil_multiply_add_double.Invoke(x, ((double*)generic_THIRTYTWO_OVER_PI_28.Pointer)[2L], *(double*)y);
			long result = (long)num2;
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
