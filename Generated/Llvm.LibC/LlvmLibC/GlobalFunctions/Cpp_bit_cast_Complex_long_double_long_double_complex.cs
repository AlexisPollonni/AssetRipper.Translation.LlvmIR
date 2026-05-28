using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_cast_Complex_long_double_long_double_complex
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castINS_7ComplexIeEECeEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS6_EE5valuesr3cpp21is_trivially_copyableIS6_EE5valuesr3cpp21is_trivially_copyableIS7_EE5valueES6_E4typeERKS7_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (__llvm_libc_20_1_2_::Complex<long double>) == sizeof (long double complex) && cpp::is_trivially_constructible<__llvm_libc_20_1_2_::Complex<long double>>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::Complex<long double>>::value && cpp::is_trivially_copyable<long double complex>::value, __llvm_libc_20_1_2_::Complex<long double>>::type __llvm_libc_20_1_2_::cpp::bit_cast<__llvm_libc_20_1_2_::Complex<long double>, long double complex>(long double complex const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (__llvm_libc_20_1_2_::Complex<long double>) == sizeof (long double complex) && cpp::is_trivially_constructible<__llvm_libc_20_1_2_::Complex<long double>>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::Complex<long double>>::value && cpp::is_trivially_copyable<long double complex>::value, __llvm_libc_20_1_2_::Complex<long double>>::type")]
	public unsafe static void Invoke([MangledName("agg.result")] Complex_p54sq8* Agg_result, [MangledName("from")][NativeType("long double complex const&")] void* From)
	{
		Llvm_memcpy_p0_p0_i64.Invoke(Agg_result, From, 32L, isVolatile: false);
	}
}
