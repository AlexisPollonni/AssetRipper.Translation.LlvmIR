using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cimagl
{
	public unsafe static double Invoke(void* x)
	{
		Complex_p54sq8 complex_p54sq = default(Complex_p54sq8);
		llvm_lifetime_start_p0.Invoke(32L, &complex_p54sq);
		unchecked
		{
			*(double*)(&complex_p54sq) = double.NaN;
			((double*)(&complex_p54sq))[2] = double.NaN;
			cpp_bit_cast_Complex_long_double_long_double_complex.Invoke(&complex_p54sq, x);
			double imag = complex_p54sq.imag;
			llvm_lifetime_end_p0.Invoke(32L, &complex_p54sq);
			return imag;
		}
	}
}
