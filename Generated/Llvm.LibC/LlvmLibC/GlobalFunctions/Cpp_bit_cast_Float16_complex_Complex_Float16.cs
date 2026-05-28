using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_cast_Float16_complex_Complex_Float16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castICDF16_NS_7ComplexIDF16_EEEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS6_EE5valuesr3cpp21is_trivially_copyableIS6_EE5valuesr3cpp21is_trivially_copyableIS7_EE5valueES6_E4typeERKS7_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (_Float16 complex) == sizeof (__llvm_libc_20_1_2_::Complex<_Float16>) && cpp::is_trivially_constructible<_Float16 complex>::value && cpp::is_trivially_copyable<_Float16 complex>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::Complex<_Float16>>::value, _Float16 complex>::type __llvm_libc_20_1_2_::cpp::bit_cast<_Float16 complex, __llvm_libc_20_1_2_::Complex<_Float16>>(__llvm_libc_20_1_2_::Complex<_Float16> const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (_Float16 complex) == sizeof (__llvm_libc_20_1_2_::Complex<_Float16>) && cpp::is_trivially_constructible<_Float16 complex>::value && cpp::is_trivially_copyable<_Float16 complex>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::Complex<_Float16>>::value, _Float16 complex>::type")]
	public unsafe static InlineArray2_Half Invoke([MangledName("from")][NativeType("__llvm_libc_20_1_2_::Complex<_Float16> const&")] Complex_mify6x* From)
	{
		Struct_zwcg27 struct_zwcg = default(Struct_zwcg27);
		unchecked
		{
			Half field_ = ((Struct_zwcg27*)From)->field_0;
			Half field_2 = ((Struct_zwcg27*)From)->field_1;
			Half* ptr = &struct_zwcg.field_1;
			struct_zwcg.field_0 = field_;
			*ptr = field_2;
			return *(InlineArray2_Half*)(&struct_zwcg);
		}
	}
}
