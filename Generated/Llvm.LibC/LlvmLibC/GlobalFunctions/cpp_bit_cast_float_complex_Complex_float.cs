using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_bit_cast_float_complex_Complex_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castICfNS_7ComplexIfEEEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS6_EE5valuesr3cpp21is_trivially_copyableIS6_EE5valuesr3cpp21is_trivially_copyableIS7_EE5valueES6_E4typeERKS7_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (float complex) == sizeof (__llvm_libc_20_1_2_::Complex<float>) && cpp::is_trivially_constructible<float complex>::value && cpp::is_trivially_copyable<float complex>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::Complex<float>>::value, float complex>::type __llvm_libc_20_1_2_::cpp::bit_cast<float complex, __llvm_libc_20_1_2_::Complex<float>>(__llvm_libc_20_1_2_::Complex<float> const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (float complex) == sizeof (__llvm_libc_20_1_2_::Complex<float>) && cpp::is_trivially_constructible<float complex>::value && cpp::is_trivially_copyable<float complex>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::Complex<float>>::value, float complex>::type")]
	public unsafe static InlineArray2_Single Invoke([NativeType("__llvm_libc_20_1_2_::Complex<float> const&")] void* from)
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
