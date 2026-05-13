using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castICeNS_7ComplexIeEEEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS6_EE5valuesr3cpp21is_trivially_copyableIS6_EE5valuesr3cpp21is_trivially_copyableIS7_EE5valueES6_E4typeERKS7_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (long double complex) == sizeof (__llvm_libc_20_1_2_::Complex<long double>) && cpp::is_trivially_constructible<long double complex>::value && cpp::is_trivially_copyable<long double complex>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::Complex<long double>>::value, long double complex>::type __llvm_libc_20_1_2_::cpp::bit_cast<long double complex, __llvm_libc_20_1_2_::Complex<long double>>(__llvm_libc_20_1_2_::Complex<long double> const&)")]
internal static partial class cpp_enable_if_sizeof_long_double_complex_sizeof_Complex_long_double_cpp_is_trivially_constructible_long_double_complex_value_cpp_is_trivially_copyable_long_double_complex_value_cpp_is_trivially_copyable_Complex_long_double_value_long_double_complex_type_cpp_bit_cast_long_double_complex_Complex_long_double_Complex_long_double_const
{
	public unsafe static Struct_29m54m Invoke(void* from)
	{
		Struct_29m54m result = default(Struct_29m54m);
		unchecked
		{
			double field_ = ((Struct_29m54m*)from)->field_0;
			double field_2 = ((Struct_29m54m*)from)->field_1;
			double* ptr = &result.field_1;
			result.field_0 = field_;
			*ptr = field_2;
			return result;
		}
	}
}
