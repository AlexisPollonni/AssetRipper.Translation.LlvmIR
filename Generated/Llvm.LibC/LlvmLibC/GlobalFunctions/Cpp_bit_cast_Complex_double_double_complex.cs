using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_cast_Complex_double_double_complex
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castINS_7ComplexIdEECdEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS6_EE5valuesr3cpp21is_trivially_copyableIS6_EE5valuesr3cpp21is_trivially_copyableIS7_EE5valueES6_E4typeERKS7_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (__llvm_libc_20_1_2_::Complex<double>) == sizeof (double complex) && cpp::is_trivially_constructible<__llvm_libc_20_1_2_::Complex<double>>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::Complex<double>>::value && cpp::is_trivially_copyable<double complex>::value, __llvm_libc_20_1_2_::Complex<double>>::type __llvm_libc_20_1_2_::cpp::bit_cast<__llvm_libc_20_1_2_::Complex<double>, double complex>(double complex const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (__llvm_libc_20_1_2_::Complex<double>) == sizeof (double complex) && cpp::is_trivially_constructible<__llvm_libc_20_1_2_::Complex<double>>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::Complex<double>>::value && cpp::is_trivially_copyable<double complex>::value, __llvm_libc_20_1_2_::Complex<double>>::type")]
	public unsafe static Struct_4ydhja Invoke([MangledName("from")][NativeType("double complex const&")] void* From)
	{
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_NumberPair, From, 16L, isVolatile: false);
		return *unchecked((Struct_4ydhja*)(&llvm_libc_20_1_2_NumberPair));
	}
}
