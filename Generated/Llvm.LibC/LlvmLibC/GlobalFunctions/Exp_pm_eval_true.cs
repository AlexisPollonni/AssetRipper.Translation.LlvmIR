using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Exp_pm_eval_true
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11exp_pm_evalILb1EEEdf")]
	[DemangledName("double __llvm_libc_20_1_2_::exp_pm_eval<true>(float)")]
	[return: NativeType("double")]
	public unsafe static double Invoke([MangledName("x")][NativeType("float")] float X)
	{
		double num = 0.0;
		double x = 0.0;
		int num2 = 0;
		int num3 = 0;
		InlineArray2_Double inlineArray2_Double = default(InlineArray2_Double);
		long num4 = 0L;
		long num5 = 0L;
		long x2 = 0L;
		long x3 = 0L;
		double num6 = 0.0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		double num7 = 0.0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		double num8 = 0.0;
		double num9 = 0.0;
		double num10 = 0.0;
		double x4 = 0.0;
		double num11 = 0.0;
		double y = 0.0;
		double num12 = 0.0;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = X;
		Llvm_lifetime_start_p0.Invoke(8L, &x);
		x = double.NaN;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = -1431655766;
		Llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = -1431655766;
		Llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_Double);
		long num13;
		unchecked
		{
			*(double*)(&inlineArray2_Double) = 0.5;
			((double*)(&inlineArray2_Double))[1] = -0.5;
			num2 = (int)Fputil_multiply_add_double.Invoke(num, 46.16624130844683, Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double, ((X < 0f) ? ((nint)1) : ((nint)0)) * (nint)sizeof(double))));
			num3 = checked(-num2);
			x = num2;
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = (long)(num2 >> 5) << 52;
			Llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = (long)(num3 >> 5) << 52;
			Llvm_lifetime_start_p0.Invoke(8L, &x2);
			num13 = num2 & 0x1F;
		}
		x2 = unchecked((long*)ExpBase_EXP_2_MID.Pointer)[num13] + num4;
		Llvm_lifetime_start_p0.Invoke(8L, &x3);
		long num14 = num3 & 0x1F;
		x3 = unchecked((long*)ExpBase_EXP_2_MID.Pointer)[num14] + num5;
		Llvm_lifetime_start_p0.Invoke(8L, &num6);
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm, x2);
		double num15 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm);
		Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		num6 = num15;
		Llvm_lifetime_start_p0.Invoke(8L, &num7);
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm2, x3);
		double num16 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
		Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		num7 = num16;
		Llvm_lifetime_start_p0.Invoke(8L, &num8);
		num8 = num6 + num7;
		Llvm_lifetime_start_p0.Invoke(8L, &num9);
		num9 = num6 - num7;
		Llvm_lifetime_start_p0.Invoke(8L, &num10);
		num10 = Fputil_multiply_add_double.Invoke(x, -5.145609244655338E-14, Fputil_multiply_add_double.Invoke(x, -0.021660849392446835, num));
		Llvm_lifetime_start_p0.Invoke(8L, &x4);
		x4 = num10 * num10;
		Llvm_lifetime_start_p0.Invoke(8L, &num11);
		unchecked
		{
			num11 = Fputil_polyeval_double_double_double.Invoke(x4, 0.5, *(double*)ExpBase_COEFFS.Pointer * 0.5, ((double*)ExpBase_COEFFS.Pointer)[2L] * 0.5);
			Llvm_lifetime_start_p0.Invoke(8L, &y);
			y = Fputil_polyeval_double_double_double.Invoke(x4, 0.5, ((double*)ExpBase_COEFFS.Pointer)[1] * 0.5, ((double*)ExpBase_COEFFS.Pointer)[3L] * 0.5);
			Llvm_lifetime_start_p0.Invoke(8L, &num12);
			num12 = double.NaN;
			num12 = Fputil_multiply_add_double.Invoke(num10 * num8, y, num11 * num9);
			double result = num12;
			Llvm_lifetime_end_p0.Invoke(8L, &num12);
			Llvm_lifetime_end_p0.Invoke(8L, &y);
			Llvm_lifetime_end_p0.Invoke(8L, &num11);
			Llvm_lifetime_end_p0.Invoke(8L, &x4);
			Llvm_lifetime_end_p0.Invoke(8L, &num10);
			Llvm_lifetime_end_p0.Invoke(8L, &num9);
			Llvm_lifetime_end_p0.Invoke(8L, &num8);
			Llvm_lifetime_end_p0.Invoke(8L, &num7);
			Llvm_lifetime_end_p0.Invoke(8L, &num6);
			Llvm_lifetime_end_p0.Invoke(8L, &x3);
			Llvm_lifetime_end_p0.Invoke(8L, &x2);
			Llvm_lifetime_end_p0.Invoke(8L, &num5);
			Llvm_lifetime_end_p0.Invoke(8L, &num4);
			Llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_Double);
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
