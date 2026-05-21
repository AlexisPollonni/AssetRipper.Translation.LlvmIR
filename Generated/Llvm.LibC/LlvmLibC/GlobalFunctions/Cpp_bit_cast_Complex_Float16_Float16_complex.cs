using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_cast_Complex_Float16_Float16_complex
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castINS_7ComplexIDF16_EECDF16_EENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS6_EE5valuesr3cpp21is_trivially_copyableIS6_EE5valuesr3cpp21is_trivially_copyableIS7_EE5valueES6_E4typeERKS7_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (__llvm_libc_20_1_2_::Complex<_Float16>) == sizeof (_Float16 complex) && cpp::is_trivially_constructible<__llvm_libc_20_1_2_::Complex<_Float16>>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::Complex<_Float16>>::value && cpp::is_trivially_copyable<_Float16 complex>::value, __llvm_libc_20_1_2_::Complex<_Float16>>::type __llvm_libc_20_1_2_::cpp::bit_cast<__llvm_libc_20_1_2_::Complex<_Float16>, _Float16 complex>(_Float16 complex const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (__llvm_libc_20_1_2_::Complex<_Float16>) == sizeof (_Float16 complex) && cpp::is_trivially_constructible<__llvm_libc_20_1_2_::Complex<_Float16>>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::Complex<_Float16>>::value && cpp::is_trivially_copyable<_Float16 complex>::value, __llvm_libc_20_1_2_::Complex<_Float16>>::type")]
	public unsafe static InlineArray2_Half Invoke([MangledName("from")][NativeType("_Float16 complex const&")] void* From)
	{
		Llvm_libc_20_1_2_Complex_mify6x llvm_libc_20_1_2_Complex_mify6x = default(Llvm_libc_20_1_2_Complex_mify6x);
		Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_Complex_mify6x, From, 4L, isVolatile: false);
		return *unchecked((InlineArray2_Half*)(&llvm_libc_20_1_2_Complex_mify6x));
	}
}
