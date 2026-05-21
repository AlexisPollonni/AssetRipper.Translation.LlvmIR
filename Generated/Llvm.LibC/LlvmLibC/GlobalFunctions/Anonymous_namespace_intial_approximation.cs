using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Anonymous_namespace_intial_approximation
{
	[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_120intial_approximationEd")]
	[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::intial_approximation(double)")]
	public unsafe static double Invoke([MangledName("x")][NativeType("double")] double X)
	{
		InlineArray8_Double inlineArray8_Double = default(InlineArray8_Double);
		double num = 0.0;
		double z = 0.0;
		double y = 0.0;
		double z2 = 0.0;
		double y2 = 0.0;
		double x = 0.0;
		double z3 = 0.0;
		double y3 = 0.0;
		Llvm_lifetime_start_p0.Invoke(64L, &inlineArray8_Double);
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
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = X * X;
			Llvm_lifetime_start_p0.Invoke(8L, &z);
			z = Fputil_multiply_add_double.Invoke(X, Unsafe.As<InlineArray8_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray8_Double, sizeof(double))), *(double*)(&inlineArray8_Double));
			Llvm_lifetime_start_p0.Invoke(8L, &y);
			y = Fputil_multiply_add_double.Invoke(X, Unsafe.As<InlineArray8_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray8_Double, (nint)3 * sizeof(double))), Unsafe.As<InlineArray8_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray8_Double, (nint)2 * sizeof(double))));
			Llvm_lifetime_start_p0.Invoke(8L, &z2);
			z2 = Fputil_multiply_add_double.Invoke(X, Unsafe.As<InlineArray8_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray8_Double, (nint)5 * sizeof(double))), Unsafe.As<InlineArray8_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray8_Double, (nint)4 * sizeof(double))));
			Llvm_lifetime_start_p0.Invoke(8L, &y2);
			y2 = Fputil_multiply_add_double.Invoke(X, Unsafe.As<InlineArray8_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray8_Double, (nint)7 * sizeof(double))), Unsafe.As<InlineArray8_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray8_Double, (nint)6 * sizeof(double))));
			Llvm_lifetime_start_p0.Invoke(8L, &x);
			x = num * num;
			Llvm_lifetime_start_p0.Invoke(8L, &z3);
			z3 = Fputil_multiply_add_double.Invoke(num, y, z);
			Llvm_lifetime_start_p0.Invoke(8L, &y3);
			y3 = Fputil_multiply_add_double.Invoke(num, y2, z2);
			double result = Fputil_multiply_add_double.Invoke(x, y3, z3);
			Llvm_lifetime_end_p0.Invoke(8L, &y3);
			Llvm_lifetime_end_p0.Invoke(8L, &z3);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			Llvm_lifetime_end_p0.Invoke(8L, &y2);
			Llvm_lifetime_end_p0.Invoke(8L, &z2);
			Llvm_lifetime_end_p0.Invoke(8L, &y);
			Llvm_lifetime_end_p0.Invoke(8L, &z);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(64L, &inlineArray8_Double);
			return result;
		}
	}
}
