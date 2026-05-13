using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castINS_7ComplexIfEECfEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS6_EE5valuesr3cpp21is_trivially_copyableIS6_EE5valuesr3cpp21is_trivially_copyableIS7_EE5valueES6_E4typeERKS7_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (__llvm_libc_20_1_2_::Complex<float>) == sizeof (float complex) && cpp::is_trivially_constructible<__llvm_libc_20_1_2_::Complex<float>>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::Complex<float>>::value && cpp::is_trivially_copyable<float complex>::value, __llvm_libc_20_1_2_::Complex<float>>::type __llvm_libc_20_1_2_::cpp::bit_cast<__llvm_libc_20_1_2_::Complex<float>, float complex>(float complex const&)")]
internal static partial class cpp_enable_if_sizeof_Complex_float_sizeof_float_complex_cpp_is_trivially_constructible_Complex_float_value_cpp_is_trivially_copyable_Complex_float_value_cpp_is_trivially_copyable_float_complex_value_Complex_float_type_cpp_bit_cast_Complex_float_float_complex_float_complex_const
{
	public unsafe static InlineArray2_Single Invoke(void* from)
	{
		ExpRangeReduction expRangeReduction = default(ExpRangeReduction);
		llvm_memcpy_p0_p0_i64.Invoke(&expRangeReduction, from, 8L, isVolatile: false);
		return *unchecked((InlineArray2_Single*)(&expRangeReduction));
	}
}
