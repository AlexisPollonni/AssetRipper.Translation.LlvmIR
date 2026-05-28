using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Crealf128
{
	[MangledName("crealf128")]
	[DemangledName("crealf128")]
	public unsafe static double Invoke([MangledName("x")] void* X)
	{
		Complex_22i76p complex_22i76p = default(Complex_22i76p);
		Llvm_lifetime_start_p0.Invoke(32L, &complex_22i76p);
		unchecked
		{
			*(double*)(&complex_22i76p) = double.NaN;
			((double*)(&complex_22i76p))[2] = double.NaN;
			Cpp_bit_cast_Complex_float128_float128_complex.Invoke(&complex_22i76p, X);
			double real = complex_22i76p.Real;
			Llvm_lifetime_end_p0.Invoke(32L, &complex_22i76p);
			return real;
		}
	}
}
