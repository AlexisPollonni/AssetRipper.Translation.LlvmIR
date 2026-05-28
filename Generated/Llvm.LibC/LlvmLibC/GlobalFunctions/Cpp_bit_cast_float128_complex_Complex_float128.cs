using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_cast_float128_complex_Complex_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castICgNS_7ComplexIgEEEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS6_EE5valuesr3cpp21is_trivially_copyableIS6_EE5valuesr3cpp21is_trivially_copyableIS7_EE5valueES6_E4typeERKS7_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (__float128 complex) == sizeof (__llvm_libc_20_1_2_::Complex<__float128>) && cpp::is_trivially_constructible<__float128 complex>::value && cpp::is_trivially_copyable<__float128 complex>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::Complex<__float128>>::value, __float128 complex>::type __llvm_libc_20_1_2_::cpp::bit_cast<__float128 complex, __llvm_libc_20_1_2_::Complex<__float128>>(__llvm_libc_20_1_2_::Complex<__float128> const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (__float128 complex) == sizeof (__llvm_libc_20_1_2_::Complex<__float128>) && cpp::is_trivially_constructible<__float128 complex>::value && cpp::is_trivially_copyable<__float128 complex>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::Complex<__float128>>::value, __float128 complex>::type")]
	public unsafe static void Invoke([MangledName("agg.result")] Struct_unhbb7* Agg_result, [MangledName("from")][NativeType("__llvm_libc_20_1_2_::Complex<__float128> const&")] Complex_22i76p* From)
	{
		unchecked
		{
			double field_ = ((Struct_unhbb7*)From)->field_0;
			double field_2 = ((Struct_unhbb7*)From)->field_1;
			double* field_3 = &Agg_result->field_1;
			Agg_result->field_0 = field_;
			*field_3 = field_2;
			double field_4 = Agg_result->field_0;
			double field_5 = Agg_result->field_1;
			double* field_6 = &Agg_result->field_1;
			Agg_result->field_0 = field_4;
			*field_6 = field_5;
		}
	}
}
