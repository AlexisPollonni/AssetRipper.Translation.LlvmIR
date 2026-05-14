using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic21small_range_reductionEdRd")]
[DemangledName("__llvm_libc_20_1_2_::generic::small_range_reduction(double, double&)")]
internal static partial class generic_small_range_reduction_double_double
{
	public unsafe static long Invoke(double x, void* y)
	{
		double num = 0.0;
		double num2 = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			num = x * *(double*)generic_THIRTYTWO_OVER_PI_28.Pointer;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = fputil_nearest_integer_double.Invoke(num);
			*(double*)y = num - num2;
			*(double*)y = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x, ((double*)generic_THIRTYTWO_OVER_PI_28.Pointer)[1], *(double*)y);
			*(double*)y = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x, ((double*)generic_THIRTYTWO_OVER_PI_28.Pointer)[2L], *(double*)y);
			long result = (long)num2;
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
