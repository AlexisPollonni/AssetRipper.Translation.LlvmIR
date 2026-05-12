using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castICgNS_7ComplexIgEEEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS6_EE5valuesr3cpp21is_trivially_copyableIS6_EE5valuesr3cpp21is_trivially_copyableIS7_EE5valueES6_E4typeERKS7_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (__float128 complex) == sizeof (__llvm_libc_20_1_2_::Complex<__float128>) && cpp::is_trivially_constructible<__float128 complex>::value && cpp::is_trivially_copyable<__float128 complex>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::Complex<__float128>>::value, __float128 complex>::type __llvm_libc_20_1_2_::cpp::bit_cast<__float128 complex, __llvm_libc_20_1_2_::Complex<__float128>>(__llvm_libc_20_1_2_::Complex<__float128> const&)")]
internal static partial class cpp_enable_if_sizeof_float128_complex_sizeof_Complex_float128_cpp_is_trivially_constructible_float128_complex_value_cpp_is_trivially_copyable_float128_complex_value_cpp_is_trivially_copyable_Complex_float128_value_float128_complex_type_cpp_bit_cast_float128_complex_Complex_float128_Complex_float128_const
{
	public unsafe static void Invoke([MangledName("agg.result")] Struct_unhbb7* agg_result, Complex_22i76p* from)
	{
		unchecked
		{
			double field_ = ((Struct_unhbb7*)from)->field_0;
			double field_2 = ((Struct_unhbb7*)from)->field_1;
			double* field_3 = &agg_result->field_1;
			agg_result->field_0 = field_;
			*field_3 = field_2;
			double field_4 = agg_result->field_0;
			double field_5 = agg_result->field_1;
			double* field_6 = &agg_result->field_1;
			agg_result->field_0 = field_4;
			*field_6 = field_5;
		}
	}
}
