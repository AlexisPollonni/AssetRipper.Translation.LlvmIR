using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Range_reduction_small
{
	[MangledName("_ZN19__llvm_libc_20_1_2_21range_reduction_smallEdRNS_10NumberPairIdEE")]
	[DemangledName("__llvm_libc_20_1_2_::range_reduction_small(double, __llvm_libc_20_1_2_::NumberPair<double>&)")]
	public unsafe static int Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("u")][NativeType("__llvm_libc_20_1_2_::NumberPair<double>&")] NumberPair* U)
	{
		InlineArray3_Double inlineArray3_Double = default(InlineArray3_Double);
		double num = 0.0;
		double x = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		double z = 0.0;
		double z2 = 0.0;
		Llvm_lifetime_start_p0.Invoke(24L, &inlineArray3_Double);
		unchecked
		{
			*(double*)(&inlineArray3_Double) = -0.024543692605220713;
			((double*)(&inlineArray3_Double))[1] = -9.495469541099947E-13;
			((double*)(&inlineArray3_Double))[2L] = -3.159791013743673E-23;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 128.0 / Math.PI;
			Llvm_lifetime_start_p0.Invoke(8L, &x);
			x = X * (128.0 / Math.PI);
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = Fputil_nearest_integer.Invoke(x);
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = Fputil_multiply_add_double.Invoke(num2, *(double*)(&inlineArray3_Double), X);
			U->Hi = Fputil_multiply_add_double.Invoke(num2, Unsafe.As<InlineArray3_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray3_Double, sizeof(double))), num3);
			Llvm_lifetime_start_p0.Invoke(8L, &z);
			z = num3 - U->Hi;
			Llvm_lifetime_start_p0.Invoke(8L, &z2);
			z2 = Fputil_multiply_add_double.Invoke(num2, Unsafe.As<InlineArray3_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray3_Double, sizeof(double))), z);
			U->Lo = Fputil_multiply_add_double.Invoke(num2, Unsafe.As<InlineArray3_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray3_Double, (nint)2 * sizeof(double))), z2);
			int result = (int)(long)num2;
			Llvm_lifetime_end_p0.Invoke(8L, &z2);
			Llvm_lifetime_end_p0.Invoke(8L, &z);
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(24L, &inlineArray3_Double);
			return result;
		}
	}
}
