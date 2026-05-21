using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_small_range_reduction
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic21small_range_reductionEdRd")]
	[DemangledName("__llvm_libc_20_1_2_::generic::small_range_reduction(double, double&)")]
	public unsafe static long Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("y")][NativeType("double&")] void* Y)
	{
		double num = 0.0;
		double num2 = 0.0;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = X * *(double*)Llvm_libc_20_1_2_generic_THIRTYTWO_OVER_PI_28.Pointer;
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = Fputil_nearest_integer.Invoke(num);
			*(double*)Y = num - num2;
			*(double*)Y = Fputil_multiply_add_double.Invoke(X, ((double*)Llvm_libc_20_1_2_generic_THIRTYTWO_OVER_PI_28.Pointer)[1], *(double*)Y);
			*(double*)Y = Fputil_multiply_add_double.Invoke(X, ((double*)Llvm_libc_20_1_2_generic_THIRTYTWO_OVER_PI_28.Pointer)[2L], *(double*)Y);
			long result = (long)num2;
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
