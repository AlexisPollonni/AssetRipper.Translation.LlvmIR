using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castINS_7ComplexIgEECgEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS6_EE5valuesr3cpp21is_trivially_copyableIS6_EE5valuesr3cpp21is_trivially_copyableIS7_EE5valueES6_E4typeERKS7_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (__llvm_libc_20_1_2_::Complex<__float128>) == sizeof (__float128 complex) && cpp::is_trivially_constructible<__llvm_libc_20_1_2_::Complex<__float128>>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::Complex<__float128>>::value && cpp::is_trivially_copyable<__float128 complex>::value, __llvm_libc_20_1_2_::Complex<__float128>>::type __llvm_libc_20_1_2_::cpp::bit_cast<__llvm_libc_20_1_2_::Complex<__float128>, __float128 complex>(__float128 complex const&)")]
internal static partial class cpp_enable_if_sizeof_Complex_float128_sizeof_float128_complex_cpp_is_trivially_constructible_Complex_float128_value_cpp_is_trivially_copyable_Complex_float128_value_cpp_is_trivially_copyable_float128_complex_value_Complex_float128_type_cpp_bit_cast_Complex_float128_float128_complex_float128_complex_const
{
	public unsafe static void Invoke([MangledName("agg.result")] Complex_22i76p* agg_result, void* from)
	{
		llvm_memcpy_p0_p0_i64.Invoke(agg_result, from, 32L, isVolatile: false);
	}
}
