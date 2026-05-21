using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class range_reduction_small
{
	[MangledName("_ZN19__llvm_libc_20_1_2_21range_reduction_smallEdRNS_10NumberPairIdEE")]
	[DemangledName("__llvm_libc_20_1_2_::range_reduction_small(double, __llvm_libc_20_1_2_::NumberPair<double>&)")]
	public unsafe static int Invoke([NativeType("double")] double x, [NativeType("__llvm_libc_20_1_2_::NumberPair<double>&")] NumberPair* u)
	{
		InlineArray3_Double inlineArray3_Double = default(InlineArray3_Double);
		double num = 0.0;
		double x2 = 0.0;
		double num2 = 0.0;
		double num3 = 0.0;
		double z = 0.0;
		double z2 = 0.0;
		llvm_lifetime_start_p0.Invoke(24L, &inlineArray3_Double);
		unchecked
		{
			*(double*)(&inlineArray3_Double) = -0.024543692605220713;
			((double*)(&inlineArray3_Double))[1] = -9.495469541099947E-13;
			((double*)(&inlineArray3_Double))[2L] = -3.159791013743673E-23;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 128.0 / Math.PI;
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = x * (128.0 / Math.PI);
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = fputil_nearest_integer.Invoke(x2);
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = fputil_multiply_add_double.Invoke(num2, *(double*)(&inlineArray3_Double), x);
			u->hi = fputil_multiply_add_double.Invoke(num2, Unsafe.As<InlineArray3_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray3_Double, sizeof(double))), num3);
			llvm_lifetime_start_p0.Invoke(8L, &z);
			z = num3 - u->hi;
			llvm_lifetime_start_p0.Invoke(8L, &z2);
			z2 = fputil_multiply_add_double.Invoke(num2, Unsafe.As<InlineArray3_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray3_Double, sizeof(double))), z);
			u->lo = fputil_multiply_add_double.Invoke(num2, Unsafe.As<InlineArray3_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray3_Double, (nint)2 * sizeof(double))), z2);
			int result = (int)(long)num2;
			llvm_lifetime_end_p0.Invoke(8L, &z2);
			llvm_lifetime_end_p0.Invoke(8L, &z);
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(24L, &inlineArray3_Double);
			return result;
		}
	}
}
