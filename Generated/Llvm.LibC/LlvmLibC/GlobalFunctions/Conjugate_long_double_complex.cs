using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Conjugate_long_double_complex
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9conjugateICeEET_S2_")]
	[DemangledName("long double complex __llvm_libc_20_1_2_::conjugate<long double complex>(long double complex)")]
	[return: NativeType("long double complex")]
	public unsafe static Struct_29m54m Invoke([MangledName("c")][NativeType("long double complex")] void* C)
	{
		Struct_29m54m result = default(Struct_29m54m);
		Complex_p54sq8 complex_p54sq = default(Complex_p54sq8);
		Llvm_lifetime_start_p0.Invoke(32L, &complex_p54sq);
		unchecked
		{
			*(double*)(&complex_p54sq) = double.NaN;
			((double*)(&complex_p54sq))[2] = double.NaN;
			Cpp_bit_cast_Complex_long_double_long_double_complex.Invoke(&complex_p54sq, C);
			complex_p54sq.Imag = 0.0 - complex_p54sq.Imag;
			Struct_29m54m struct_29m54m = Cpp_bit_cast_long_double_complex_Complex_long_double.Invoke(&complex_p54sq);
			Struct_29m54m struct_29m54m2 = struct_29m54m;
			double field_ = struct_29m54m2.field_0;
			Struct_29m54m struct_29m54m3 = struct_29m54m;
			double field_2 = struct_29m54m3.field_1;
			double* ptr = &result.field_1;
			result.field_0 = field_;
			*ptr = field_2;
			Llvm_lifetime_end_p0.Invoke(32L, &complex_p54sq);
			return result;
		}
	}
}
