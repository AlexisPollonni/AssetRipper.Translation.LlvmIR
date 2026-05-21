using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class exp_pm_eval_true
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11exp_pm_evalILb1EEEdf")]
	[DemangledName("double __llvm_libc_20_1_2_::exp_pm_eval<true>(float)")]
	[return: NativeType("double")]
	public unsafe static double Invoke([NativeType("float")] float x)
	{
		double num = 0.0;
		double x2 = 0.0;
		int num2 = 0;
		int num3 = 0;
		InlineArray2_Double inlineArray2_Double = default(InlineArray2_Double);
		long num4 = 0L;
		long num5 = 0L;
		long x3 = 0L;
		long x4 = 0L;
		double num6 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		double num7 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		double num8 = 0.0;
		double num9 = 0.0;
		double num10 = 0.0;
		double x5 = 0.0;
		double num11 = 0.0;
		double y = 0.0;
		double num12 = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = x;
		llvm_lifetime_start_p0.Invoke(8L, &x2);
		x2 = double.NaN;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = -1431655766;
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = -1431655766;
		llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_Double);
		long num13;
		unchecked
		{
			*(double*)(&inlineArray2_Double) = 0.5;
			((double*)(&inlineArray2_Double))[1] = -0.5;
			num2 = (int)fputil_multiply_add_double.Invoke(num, 46.16624130844683, Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double, ((x < 0f) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double))));
			num3 = checked(-num2);
			x2 = num2;
			llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = (long)(num2 >> 5) << 52;
			llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = (long)(num3 >> 5) << 52;
			llvm_lifetime_start_p0.Invoke(8L, &x3);
			num13 = num2 & 0x1F;
		}
		x3 = unchecked((long*)ExpBase_EXP_2_MID.Pointer)[num13] + num4;
		llvm_lifetime_start_p0.Invoke(8L, &x4);
		long num14 = num3 & 0x1F;
		x4 = unchecked((long*)ExpBase_EXP_2_MID.Pointer)[num14] + num5;
		llvm_lifetime_start_p0.Invoke(8L, &num6);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm2, x3);
		double num15 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		num6 = num15;
		llvm_lifetime_start_p0.Invoke(8L, &num7);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
		FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm3, x4);
		double num16 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
		num7 = num16;
		llvm_lifetime_start_p0.Invoke(8L, &num8);
		num8 = num6 + num7;
		llvm_lifetime_start_p0.Invoke(8L, &num9);
		num9 = num6 - num7;
		llvm_lifetime_start_p0.Invoke(8L, &num10);
		num10 = fputil_multiply_add_double.Invoke(x2, -5.145609244655338E-14, fputil_multiply_add_double.Invoke(x2, -0.021660849392446835, num));
		llvm_lifetime_start_p0.Invoke(8L, &x5);
		x5 = num10 * num10;
		llvm_lifetime_start_p0.Invoke(8L, &num11);
		unchecked
		{
			num11 = fputil_polyeval_double_double_double.Invoke(x5, 0.5, *(double*)ExpBase_COEFFS.Pointer * 0.5, ((double*)ExpBase_COEFFS.Pointer)[2L] * 0.5);
			llvm_lifetime_start_p0.Invoke(8L, &y);
			y = fputil_polyeval_double_double_double.Invoke(x5, 0.5, ((double*)ExpBase_COEFFS.Pointer)[1] * 0.5, ((double*)ExpBase_COEFFS.Pointer)[3L] * 0.5);
			llvm_lifetime_start_p0.Invoke(8L, &num12);
			num12 = double.NaN;
			num12 = fputil_multiply_add_double.Invoke(num10 * num8, y, num11 * num9);
			double result = num12;
			llvm_lifetime_end_p0.Invoke(8L, &num12);
			llvm_lifetime_end_p0.Invoke(8L, &y);
			llvm_lifetime_end_p0.Invoke(8L, &num11);
			llvm_lifetime_end_p0.Invoke(8L, &x5);
			llvm_lifetime_end_p0.Invoke(8L, &num10);
			llvm_lifetime_end_p0.Invoke(8L, &num9);
			llvm_lifetime_end_p0.Invoke(8L, &num8);
			llvm_lifetime_end_p0.Invoke(8L, &num7);
			llvm_lifetime_end_p0.Invoke(8L, &num6);
			llvm_lifetime_end_p0.Invoke(8L, &x4);
			llvm_lifetime_end_p0.Invoke(8L, &x3);
			llvm_lifetime_end_p0.Invoke(8L, &num5);
			llvm_lifetime_end_p0.Invoke(8L, &num4);
			llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_Double);
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
