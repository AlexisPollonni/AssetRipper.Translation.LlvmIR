using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castICDF16_NS_7ComplexIDF16_EEEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS6_EE5valuesr3cpp21is_trivially_copyableIS6_EE5valuesr3cpp21is_trivially_copyableIS7_EE5valueES6_E4typeERKS7_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (_Float16 complex) == sizeof (__llvm_libc_20_1_2_::Complex<_Float16>) && cpp::is_trivially_constructible<_Float16 complex>::value && cpp::is_trivially_copyable<_Float16 complex>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::Complex<_Float16>>::value, _Float16 complex>::type __llvm_libc_20_1_2_::cpp::bit_cast<_Float16 complex, __llvm_libc_20_1_2_::Complex<_Float16>>(__llvm_libc_20_1_2_::Complex<_Float16> const&)")]
internal static partial class cpp_enable_if_sizeof_Float16_complex_sizeof_Complex_Float16_cpp_is_trivially_constructible_Float16_complex_value_cpp_is_trivially_copyable_Float16_complex_value_cpp_is_trivially_copyable_Complex_Float16_value_Float16_complex_type_cpp_bit_cast_Float16_complex_Complex_Float16_Complex_Float16_const
{
	public unsafe static InlineArray2_Half Invoke(Complex_ueqjqt* from)
	{
		Struct_zwcg27 struct_zwcg = default(Struct_zwcg27);
		unchecked
		{
			Half field_ = ((Struct_zwcg27*)from)->field_0;
			Half field_2 = ((Struct_zwcg27*)from)->field_1;
			Half* ptr = &struct_zwcg.field_1;
			struct_zwcg.field_0 = field_;
			*ptr = field_2;
			return *(InlineArray2_Half*)(&struct_zwcg);
		}
	}
}
