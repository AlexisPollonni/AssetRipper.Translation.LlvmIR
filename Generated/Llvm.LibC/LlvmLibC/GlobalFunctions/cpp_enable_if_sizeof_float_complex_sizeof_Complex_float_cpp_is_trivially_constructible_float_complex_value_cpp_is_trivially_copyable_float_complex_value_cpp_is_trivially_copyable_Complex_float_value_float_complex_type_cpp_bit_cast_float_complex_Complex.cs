using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castICfNS_7ComplexIfEEEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS6_EE5valuesr3cpp21is_trivially_copyableIS6_EE5valuesr3cpp21is_trivially_copyableIS7_EE5valueES6_E4typeERKS7_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (float complex) == sizeof (__llvm_libc_20_1_2_::Complex<float>) && cpp::is_trivially_constructible<float complex>::value && cpp::is_trivially_copyable<float complex>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::Complex<float>>::value, float complex>::type __llvm_libc_20_1_2_::cpp::bit_cast<float complex, __llvm_libc_20_1_2_::Complex<float>>(__llvm_libc_20_1_2_::Complex<float> const&)")]
internal static partial class cpp_enable_if_sizeof_float_complex_sizeof_Complex_float_cpp_is_trivially_constructible_float_complex_value_cpp_is_trivially_copyable_float_complex_value_cpp_is_trivially_copyable_Complex_float_value_float_complex_type_cpp_bit_cast_float_complex_Complex_float_Complex_float_const
{
	public unsafe static InlineArray2_Single Invoke(void* from)
	{
		Struct_kh2xpj struct_kh2xpj = default(Struct_kh2xpj);
		unchecked
		{
			float field_ = ((Struct_kh2xpj*)from)->field_0;
			float field_2 = ((Struct_kh2xpj*)from)->field_1;
			float* ptr = &struct_kh2xpj.field_1;
			struct_kh2xpj.field_0 = field_;
			*ptr = field_2;
			return *(InlineArray2_Single*)(&struct_kh2xpj);
		}
	}
}
