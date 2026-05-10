using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_9conjugateICgEET_S2_")]
[DemangledName("__float128 complex __llvm_libc_20_1_2_::conjugate<__float128 complex>(__float128 complex)")]
internal static partial class float128_complex_conjugate_float128_complex_float128_complex
{
	public unsafe static void Invoke([MangledName("agg.result")] Struct_unhbb7* agg_result, void* c)
	{
		Complex_22i76p complex_22i76p = default(Complex_22i76p);
		Struct_unhbb7 struct_unhbb = default(Struct_unhbb7);
		llvm_lifetime_start_p0.Invoke(32L, &complex_22i76p);
		unchecked
		{
			*(double*)(&complex_22i76p) = double.NaN;
			((double*)(&complex_22i76p))[2] = double.NaN;
			cpp_enable_if_sizeof_Complex_float128_sizeof_float128_complex_cpp_is_trivially_constructible_Complex_float128_value_cpp_is_trivially_copyable_Complex_float128_value_cpp_is_trivially_copyable_float128_complex_value_Complex_float128_type_cpp_bit_cast_Complex_float128_float128_complex_float128_complex_const.Invoke(&complex_22i76p, c);
			complex_22i76p.imag = 0.0 - complex_22i76p.imag;
			cpp_enable_if_sizeof_float128_complex_sizeof_Complex_float128_cpp_is_trivially_constructible_float128_complex_value_cpp_is_trivially_copyable_float128_complex_value_cpp_is_trivially_copyable_Complex_float128_value_float128_complex_type_cpp_bit_cast_float128_complex_Complex_float128_Complex_float128_const.Invoke(&struct_unhbb, &complex_22i76p);
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
