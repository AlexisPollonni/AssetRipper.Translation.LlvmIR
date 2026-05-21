using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class conjugate_float128_complex
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9conjugateICgEET_S2_")]
	[DemangledName("__float128 complex __llvm_libc_20_1_2_::conjugate<__float128 complex>(__float128 complex)")]
	[return: NativeType("__float128 complex")]
	public unsafe static void Invoke([MangledName("agg.result")] Struct_unhbb7* agg_result, [NativeType("__float128 complex")] void* c)
	{
		Complex_22i76p complex_22i76p = default(Complex_22i76p);
		Struct_unhbb7 struct_unhbb = default(Struct_unhbb7);
		llvm_lifetime_start_p0.Invoke(32L, &complex_22i76p);
		unchecked
		{
			*(double*)(&complex_22i76p) = double.NaN;
			((double*)(&complex_22i76p))[2] = double.NaN;
			cpp_bit_cast_Complex_float128_float128_complex.Invoke(&complex_22i76p, c);
			complex_22i76p.imag = 0.0 - complex_22i76p.imag;
			cpp_bit_cast_float128_complex_Complex_float128.Invoke(&struct_unhbb, &complex_22i76p);
			double field_ = struct_unhbb.field_0;
			double field_2 = struct_unhbb.field_1;
			double* field_3 = &agg_result->field_1;
			agg_result->field_0 = field_;
			*field_3 = field_2;
			llvm_lifetime_end_p0.Invoke(32L, &complex_22i76p);
			double field_4 = agg_result->field_0;
			double field_5 = agg_result->field_1;
			double* field_6 = &agg_result->field_1;
			agg_result->field_0 = field_4;
			*field_6 = field_5;
		}
	}
}
