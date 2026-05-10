using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_9conjugateICeEET_S2_")]
[DemangledName("long double complex __llvm_libc_20_1_2_::conjugate<long double complex>(long double complex)")]
internal static partial class long_double_complex_conjugate_long_double_complex_long_double_complex
{
	public unsafe static Struct_29m54m Invoke(void* c)
	{
		Struct_29m54m result = default(Struct_29m54m);
		Complex_wk9una complex_wk9una = default(Complex_wk9una);
		llvm_lifetime_start_p0.Invoke(32L, &complex_wk9una);
		unchecked
		{
			*(double*)(&complex_wk9una) = double.NaN;
			((double*)(&complex_wk9una))[2] = double.NaN;
			cpp_enable_if_sizeof_Complex_long_double_sizeof_long_double_complex_cpp_is_trivially_constructible_Complex_long_double_value_cpp_is_trivially_copyable_Complex_long_double_value_cpp_is_trivially_copyable_long_double_complex_value_Complex_long_double_type_cpp_bit_cast_Complex_long_double_long_double_complex_long_double_complex_const.Invoke(&complex_wk9una, c);
			complex_wk9una.imag = 0.0 - complex_wk9una.imag;
			Struct_29m54m struct_29m54m = cpp_enable_if_sizeof_long_double_complex_sizeof_Complex_long_double_cpp_is_trivially_constructible_long_double_complex_value_cpp_is_trivially_copyable_long_double_complex_value_cpp_is_trivially_copyable_Complex_long_double_value_long_double_complex_type_cpp_bit_cast_long_double_complex_Complex_long_double_Complex_long_double_const.Invoke(&complex_wk9una);
			Struct_29m54m struct_29m54m2 = struct_29m54m;
			double field_ = struct_29m54m2.field_0;
			Struct_29m54m struct_29m54m3 = struct_29m54m;
			double field_2 = struct_29m54m3.field_1;
			double* ptr = &result.field_1;
			result.field_0 = field_;
			*ptr = field_2;
			llvm_lifetime_end_p0.Invoke(32L, &complex_wk9una);
			return result;
		}
	}
}
