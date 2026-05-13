using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_120intial_approximationEd")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::intial_approximation(double)")]
internal static partial class anonymous_namespace_intial_approximation_double
{
	public unsafe static double Invoke(double x)
	{
		InlineArray8_Double inlineArray8_Double = default(InlineArray8_Double);
		double num = 0.0;
		double z = 0.0;
		double y = 0.0;
		double z2 = 0.0;
		double y2 = 0.0;
		double x2 = 0.0;
		double z3 = 0.0;
		double y3 = 0.0;
		llvm_lifetime_start_p0.Invoke(64L, &inlineArray8_Double);
		unchecked
		{
			*(double*)(&inlineArray8_Double) = 3.471273287514779;
			((double*)(&inlineArray8_Double))[1] = -6.830810247982458;
			((double*)(&inlineArray8_Double))[2L] = 8.92351619384915;
			((double*)(&inlineArray8_Double))[3L] = -7.471540905640615;
			((double*)(&inlineArray8_Double))[4L] = 4.0208001193431615;
			((double*)(&inlineArray8_Double))[5L] = -1.3494228382831837;
			((double*)(&inlineArray8_Double))[6L] = 0.2575661358537974;
			((double*)(&inlineArray8_Double))[7L] = -0.021382296276922758;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = x * x;
			llvm_lifetime_start_p0.Invoke(8L, &z);
			z = fputil_multiply_add_double_double_double.Invoke(x, Unsafe.As<InlineArray8_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray8_Double, sizeof(double))), *(double*)(&inlineArray8_Double));
			llvm_lifetime_start_p0.Invoke(8L, &y);
			y = fputil_multiply_add_double_double_double.Invoke(x, Unsafe.As<InlineArray8_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray8_Double, (nint)3 * sizeof(double))), Unsafe.As<InlineArray8_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray8_Double, (nint)2 * sizeof(double))));
			llvm_lifetime_start_p0.Invoke(8L, &z2);
			z2 = fputil_multiply_add_double_double_double.Invoke(x, Unsafe.As<InlineArray8_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray8_Double, (nint)5 * sizeof(double))), Unsafe.As<InlineArray8_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray8_Double, (nint)4 * sizeof(double))));
			llvm_lifetime_start_p0.Invoke(8L, &y2);
			y2 = fputil_multiply_add_double_double_double.Invoke(x, Unsafe.As<InlineArray8_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray8_Double, (nint)7 * sizeof(double))), Unsafe.As<InlineArray8_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray8_Double, (nint)6 * sizeof(double))));
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = num * num;
			llvm_lifetime_start_p0.Invoke(8L, &z3);
			z3 = fputil_multiply_add_double_double_double.Invoke(num, y, z);
			llvm_lifetime_start_p0.Invoke(8L, &y3);
			y3 = fputil_multiply_add_double_double_double.Invoke(num, y2, z2);
			double result = fputil_multiply_add_double_double_double.Invoke(x2, y3, z3);
			llvm_lifetime_end_p0.Invoke(8L, &y3);
			llvm_lifetime_end_p0.Invoke(8L, &z3);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(8L, &y2);
			llvm_lifetime_end_p0.Invoke(8L, &z2);
			llvm_lifetime_end_p0.Invoke(8L, &y);
			llvm_lifetime_end_p0.Invoke(8L, &z);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(64L, &inlineArray8_Double);
			return result;
		}
	}
}
