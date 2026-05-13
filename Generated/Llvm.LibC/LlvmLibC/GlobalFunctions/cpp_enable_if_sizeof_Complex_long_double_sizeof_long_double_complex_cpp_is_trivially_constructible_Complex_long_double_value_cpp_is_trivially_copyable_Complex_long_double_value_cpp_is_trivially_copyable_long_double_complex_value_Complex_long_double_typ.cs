using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castINS_7ComplexIeEECeEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS6_EE5valuesr3cpp21is_trivially_copyableIS6_EE5valuesr3cpp21is_trivially_copyableIS7_EE5valueES6_E4typeERKS7_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (__llvm_libc_20_1_2_::Complex<long double>) == sizeof (long double complex) && cpp::is_trivially_constructible<__llvm_libc_20_1_2_::Complex<long double>>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::Complex<long double>>::value && cpp::is_trivially_copyable<long double complex>::value, __llvm_libc_20_1_2_::Complex<long double>>::type __llvm_libc_20_1_2_::cpp::bit_cast<__llvm_libc_20_1_2_::Complex<long double>, long double complex>(long double complex const&)")]
internal static partial class cpp_enable_if_sizeof_Complex_long_double_sizeof_long_double_complex_cpp_is_trivially_constructible_Complex_long_double_value_cpp_is_trivially_copyable_Complex_long_double_value_cpp_is_trivially_copyable_long_double_complex_value_Complex_long_double_type_cpp_bit_cast_Complex_long_double_long_double_complex_long_double_complex_const
{
	public unsafe static void Invoke([MangledName("agg.result")] Complex_wk9una* agg_result, void* from)
	{
		llvm_memcpy_p0_p0_i64.Invoke(agg_result, from, 32L, isVolatile: false);
	}
}
