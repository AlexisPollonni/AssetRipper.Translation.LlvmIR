using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11exp_pm_evalILb0EEEdf")]
[DemangledName("double __llvm_libc_20_1_2_::exp_pm_eval<false>(float)")]
internal static partial class double_exp_pm_eval_false_float
{
	public unsafe static double Invoke(float x)
	{
		double num = 0.0;
		double num2 = 0.0;
		int num3 = 0;
		int num4 = 0;
		long num5 = 0L;
		long num6 = 0L;
		long x2 = 0L;
		long x3 = 0L;
		double num7 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		double num8 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		double num9 = 0.0;
		double num10 = 0.0;
		double num11 = 0.0;
		double x4 = 0.0;
		double num12 = 0.0;
		double y = 0.0;
		double num13 = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = x;
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = double.NaN;
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = -1431655766;
		llvm_lifetime_start_p0.Invoke(4L, &num4);
		num4 = -1431655766;
		num2 = fputil_nearest_integer_double.Invoke(46.16624130844683 * num);
		num3 = unchecked((int)num2);
		num4 = -num3;
		llvm_lifetime_start_p0.Invoke(8L, &num5);
		long num14;
		unchecked
		{
			num5 = (long)(num3 >> 5) << 52;
			llvm_lifetime_start_p0.Invoke(8L, &num6);
			num6 = (long)(num4 >> 5) << 52;
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			num14 = num3 & 0x1F;
		}
		x2 = unchecked((long*)ExpBase_EXP_2_MID.Pointer)[num14] + num5;
		llvm_lifetime_start_p0.Invoke(8L, &x3);
		long num15 = num4 & 0x1F;
		x3 = unchecked((long*)ExpBase_EXP_2_MID.Pointer)[num15] + num6;
		llvm_lifetime_start_p0.Invoke(8L, &num7);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm2, x2);
		double num16 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		num7 = num16;
		llvm_lifetime_start_p0.Invoke(8L, &num8);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
		fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm3, x3);
		double num17 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm3);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
		num8 = num17;
		llvm_lifetime_start_p0.Invoke(8L, &num9);
		num9 = num7 + num8;
		llvm_lifetime_start_p0.Invoke(8L, &num10);
		num10 = num7 - num8;
		llvm_lifetime_start_p0.Invoke(8L, &num11);
		num11 = fputil_multiply_add_double_double_double.Invoke(num2, -5.145609244655338E-14, fputil_multiply_add_double_double_double.Invoke(num2, -0.021660849392446835, num));
		llvm_lifetime_start_p0.Invoke(8L, &x4);
		x4 = num11 * num11;
		llvm_lifetime_start_p0.Invoke(8L, &num12);
		unchecked
		{
			num12 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double.Invoke(x4, 0.5, *(double*)ExpBase_COEFFS.Pointer * 0.5, ((double*)ExpBase_COEFFS.Pointer)[2L] * 0.5);
			llvm_lifetime_start_p0.Invoke(8L, &y);
			y = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double.Invoke(x4, 0.5, ((double*)ExpBase_COEFFS.Pointer)[1] * 0.5, ((double*)ExpBase_COEFFS.Pointer)[3L] * 0.5);
			llvm_lifetime_start_p0.Invoke(8L, &num13);
			num13 = double.NaN;
			num13 = fputil_multiply_add_double_double_double.Invoke(num11 * num10, y, num12 * num9);
			double result = num13;
			llvm_lifetime_end_p0.Invoke(8L, &num13);
			llvm_lifetime_end_p0.Invoke(8L, &y);
			llvm_lifetime_end_p0.Invoke(8L, &num12);
			llvm_lifetime_end_p0.Invoke(8L, &x4);
			llvm_lifetime_end_p0.Invoke(8L, &num11);
			llvm_lifetime_end_p0.Invoke(8L, &num10);
			llvm_lifetime_end_p0.Invoke(8L, &num9);
			llvm_lifetime_end_p0.Invoke(8L, &num8);
			llvm_lifetime_end_p0.Invoke(8L, &num7);
			llvm_lifetime_end_p0.Invoke(8L, &x3);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(8L, &num6);
			llvm_lifetime_end_p0.Invoke(8L, &num5);
			llvm_lifetime_end_p0.Invoke(4L, &num4);
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
