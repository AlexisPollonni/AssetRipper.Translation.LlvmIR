using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cimagl
{
	[MangledName("cimagl")]
	[DemangledName("cimagl")]
	public unsafe static double Invoke([MangledName("x")] void* X)
	{
		Complex_p54sq8 complex_p54sq = default(Complex_p54sq8);
		Llvm_lifetime_start_p0.Invoke(32L, &complex_p54sq);
		unchecked
		{
			*(double*)(&complex_p54sq) = double.NaN;
			((double*)(&complex_p54sq))[2] = double.NaN;
			Cpp_bit_cast_Complex_long_double_long_double_complex.Invoke(&complex_p54sq, X);
			double imag = complex_p54sq.Imag;
			Llvm_lifetime_end_p0.Invoke(32L, &complex_p54sq);
			return imag;
		}
	}
}
