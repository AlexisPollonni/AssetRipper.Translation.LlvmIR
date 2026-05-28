using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Atan_eval_gjyy9x
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L9atan_evalEdj.60")]
	[DemangledName("__llvm_libc_20_1_2_::atan_eval(double, unsigned int) (.60)")]
	[CleanName("Atan_eval")]
	public unsafe static double Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("i")][NativeType("unsigned int")] int I)
	{
		double num = 0.0;
		double z = 0.0;
		double y = 0.0;
		double z2 = 0.0;
		double y2 = 0.0;
		double x = 0.0;
		double z3 = 0.0;
		double y3 = 0.0;
		double num2 = 0.0;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = X * X;
		Llvm_lifetime_start_p0.Invoke(8L, &z);
		unchecked
		{
			z = Fputil_multiply_add_double.Invoke(X, ((double*)((byte*)ATAN_COEFFS.Pointer + (nint)(uint)I * (nint)sizeof(InlineArray9_Double)))[2L], ((double*)((byte*)ATAN_COEFFS.Pointer + (nint)(uint)I * (nint)sizeof(InlineArray9_Double)))[1]);
			Llvm_lifetime_start_p0.Invoke(8L, &y);
			y = Fputil_multiply_add_double.Invoke(X, ((double*)((byte*)ATAN_COEFFS.Pointer + (nint)(uint)I * (nint)sizeof(InlineArray9_Double)))[4L], ((double*)((byte*)ATAN_COEFFS.Pointer + (nint)(uint)I * (nint)sizeof(InlineArray9_Double)))[3L]);
			Llvm_lifetime_start_p0.Invoke(8L, &z2);
			z2 = Fputil_multiply_add_double.Invoke(X, ((double*)((byte*)ATAN_COEFFS.Pointer + (nint)(uint)I * (nint)sizeof(InlineArray9_Double)))[6L], ((double*)((byte*)ATAN_COEFFS.Pointer + (nint)(uint)I * (nint)sizeof(InlineArray9_Double)))[5L]);
			Llvm_lifetime_start_p0.Invoke(8L, &y2);
			y2 = Fputil_multiply_add_double.Invoke(X, ((double*)((byte*)ATAN_COEFFS.Pointer + (nint)(uint)I * (nint)sizeof(InlineArray9_Double)))[8L], ((double*)((byte*)ATAN_COEFFS.Pointer + (nint)(uint)I * (nint)sizeof(InlineArray9_Double)))[7L]);
			Llvm_lifetime_start_p0.Invoke(8L, &x);
			x = num * num;
			Llvm_lifetime_start_p0.Invoke(8L, &z3);
			z3 = Fputil_multiply_add_double.Invoke(num, y, z);
			Llvm_lifetime_start_p0.Invoke(8L, &y3);
			y3 = Fputil_multiply_add_double.Invoke(num, y2, z2);
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = Fputil_multiply_add_double.Invoke(x, y3, z3);
			double result = num2;
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &y3);
			Llvm_lifetime_end_p0.Invoke(8L, &z3);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			Llvm_lifetime_end_p0.Invoke(8L, &y2);
			Llvm_lifetime_end_p0.Invoke(8L, &z2);
			Llvm_lifetime_end_p0.Invoke(8L, &y);
			Llvm_lifetime_end_p0.Invoke(8L, &z);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
