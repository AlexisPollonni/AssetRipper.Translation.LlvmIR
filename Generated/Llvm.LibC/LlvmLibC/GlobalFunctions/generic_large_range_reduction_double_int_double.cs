using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic21large_range_reductionEdiRd")]
[DemangledName("__llvm_libc_20_1_2_::generic::large_range_reduction(double, int, double&)")]
internal static partial class generic_large_range_reduction_double_int_double
{
	public unsafe static long Invoke(double x, int x_exp, void* y)
	{
		int num = 0;
		int num2 = 0;
		double num3 = 0.0;
		double num4 = 0.0;
		double z = 0.0;
		double num5 = 0.0;
		double num6 = 0.0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		*unchecked((double*)y) = 0.0;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = x_exp - 23;
		while (true)
		{
			int num7 = num2;
			long num8 = num;
			if (num7 + unchecked((int*)generic_THIRTYTWO_OVER_PI_28_LSB_EXP.Pointer)[num8] <= 5)
			{
				break;
			}
			num++;
		}
		llvm_lifetime_start_p0.Invoke(8L, &num3);
		long num9 = num;
		num3 = x * unchecked((double*)generic_THIRTYTWO_OVER_PI_28.Pointer)[num9];
		llvm_lifetime_start_p0.Invoke(8L, &num4);
		num4 = fputil_nearest_integer_double.Invoke(num3);
		llvm_lifetime_start_p0.Invoke(8L, &z);
		z = num3 - num4;
		llvm_lifetime_start_p0.Invoke(8L, &num5);
		long num10 = num + 1;
		unchecked
		{
			num5 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x, ((double*)generic_THIRTYTWO_OVER_PI_28.Pointer)[num10], z);
			llvm_lifetime_start_p0.Invoke(8L, &num6);
			num6 = fputil_nearest_integer_double.Invoke(num5);
			*(double*)y = num5 - num6;
			long num11 = checked(num + 2);
			*(double*)y = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x, ((double*)generic_THIRTYTWO_OVER_PI_28.Pointer)[num11], *(double*)y);
			long num12 = checked(num + 3);
			*(double*)y = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x, ((double*)generic_THIRTYTWO_OVER_PI_28.Pointer)[num12], *(double*)y);
		}
		long result = unchecked((long)num4) + unchecked((long)num6);
		llvm_lifetime_end_p0.Invoke(8L, &num6);
		llvm_lifetime_end_p0.Invoke(8L, &num5);
		llvm_lifetime_end_p0.Invoke(8L, &z);
		llvm_lifetime_end_p0.Invoke(8L, &num4);
		llvm_lifetime_end_p0.Invoke(8L, &num3);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
