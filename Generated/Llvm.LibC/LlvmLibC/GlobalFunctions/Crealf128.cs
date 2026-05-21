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
		Llvm_libc_20_1_2_Complex_22i76p llvm_libc_20_1_2_Complex_22i76p = default(Llvm_libc_20_1_2_Complex_22i76p);
		Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_Complex_22i76p);
		unchecked
		{
			*(double*)(&llvm_libc_20_1_2_Complex_22i76p) = double.NaN;
			((double*)(&llvm_libc_20_1_2_Complex_22i76p))[2] = double.NaN;
			Cpp_bit_cast_Complex_float128_float128_complex.Invoke(&llvm_libc_20_1_2_Complex_22i76p, X);
			double real = llvm_libc_20_1_2_Complex_22i76p.Real;
			Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_Complex_22i76p);
			return real;
		}
	}
}
