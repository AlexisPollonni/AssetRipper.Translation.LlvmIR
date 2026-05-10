using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_L24range_reduction_sincospiEdRd")]
[DemangledName("__llvm_libc_20_1_2_::range_reduction_sincospi(double, double&)")]
internal static partial class range_reduction_sincospi_double_double
{
	public unsafe static long Invoke(double x, void* y)
	{
		double num = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = fputil_nearest_integer_double.Invoke(x * 32.0);
		unchecked
		{
			*(double*)y = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x, 32.0, 0.0 - num);
			long result = (long)num;
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
