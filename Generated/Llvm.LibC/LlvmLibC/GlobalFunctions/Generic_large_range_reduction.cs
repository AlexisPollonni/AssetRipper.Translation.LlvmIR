using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_large_range_reduction
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic21large_range_reductionEdiRd")]
	[DemangledName("__llvm_libc_20_1_2_::generic::large_range_reduction(double, int, double&)")]
	public unsafe static long Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("x_exp")][NativeType("int")] int X_exp, [MangledName("y")][NativeType("double&")] void* Y)
	{
		int num = 0;
		int num2 = 0;
		double num3 = 0.0;
		double num4 = 0.0;
		double z = 0.0;
		double num5 = 0.0;
		double num6 = 0.0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		*unchecked((double*)Y) = 0.0;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = X_exp - 23;
		while (true)
		{
			int num7 = num2;
			long num8 = num;
			if (num7 + unchecked((int*)Llvm_libc_20_1_2_generic_THIRTYTWO_OVER_PI_28_LSB_EXP.Pointer)[num8] <= 5)
			{
				break;
			}
			num++;
		}
		Llvm_lifetime_start_p0.Invoke(8L, &num3);
		long num9 = num;
		num3 = X * unchecked((double*)Llvm_libc_20_1_2_generic_THIRTYTWO_OVER_PI_28.Pointer)[num9];
		Llvm_lifetime_start_p0.Invoke(8L, &num4);
		num4 = Fputil_nearest_integer.Invoke(num3);
		Llvm_lifetime_start_p0.Invoke(8L, &z);
		z = num3 - num4;
		Llvm_lifetime_start_p0.Invoke(8L, &num5);
		long num10 = num + 1;
		unchecked
		{
			num5 = Fputil_multiply_add_double.Invoke(X, ((double*)Llvm_libc_20_1_2_generic_THIRTYTWO_OVER_PI_28.Pointer)[num10], z);
			Llvm_lifetime_start_p0.Invoke(8L, &num6);
			num6 = Fputil_nearest_integer.Invoke(num5);
			*(double*)Y = num5 - num6;
			long num11 = checked(num + 2);
			*(double*)Y = Fputil_multiply_add_double.Invoke(X, ((double*)Llvm_libc_20_1_2_generic_THIRTYTWO_OVER_PI_28.Pointer)[num11], *(double*)Y);
			long num12 = checked(num + 3);
			*(double*)Y = Fputil_multiply_add_double.Invoke(X, ((double*)Llvm_libc_20_1_2_generic_THIRTYTWO_OVER_PI_28.Pointer)[num12], *(double*)Y);
		}
		long result = unchecked((long)num4) + unchecked((long)num6);
		Llvm_lifetime_end_p0.Invoke(8L, &num6);
		Llvm_lifetime_end_p0.Invoke(8L, &num5);
		Llvm_lifetime_end_p0.Invoke(8L, &z);
		Llvm_lifetime_end_p0.Invoke(8L, &num4);
		Llvm_lifetime_end_p0.Invoke(8L, &num3);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
