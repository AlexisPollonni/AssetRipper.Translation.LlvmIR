using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cimagf128
{
	public unsafe static double Invoke(void* x)
	{
		Complex_22i76p complex_22i76p = default(Complex_22i76p);
		llvm_lifetime_start_p0.Invoke(32L, &complex_22i76p);
		unchecked
		{
			*(double*)(&complex_22i76p) = double.NaN;
			((double*)(&complex_22i76p))[2] = double.NaN;
			cpp_bit_cast_Complex_float128_float128_complex.Invoke(&complex_22i76p, x);
			double imag = complex_22i76p.imag;
			llvm_lifetime_end_p0.Invoke(32L, &complex_22i76p);
			return imag;
		}
	}
}
