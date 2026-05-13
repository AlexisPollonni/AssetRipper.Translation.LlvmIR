using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_9conjugateICfEET_S2_")]
[DemangledName("float complex __llvm_libc_20_1_2_::conjugate<float complex>(float complex)")]
internal static partial class float_complex_conjugate_float_complex_float_complex
{
	public unsafe static InlineArray2_Single Invoke([MangledName("c.coerce")] InlineArray2_Single c)
	{
		Struct_kh2xpj struct_kh2xpj = default(Struct_kh2xpj);
		Struct_kh2xpj struct_kh2xpj2 = default(Struct_kh2xpj);
		ExpRangeReduction expRangeReduction = default(ExpRangeReduction);
		Struct_kh2xpj struct_kh2xpj3 = default(Struct_kh2xpj);
		unchecked
		{
			*(InlineArray2_Single*)(&struct_kh2xpj2) = c;
			llvm_lifetime_start_p0.Invoke(8L, &expRangeReduction);
			*(float*)(&expRangeReduction) = float.NaN;
			((float*)(&expRangeReduction))[1] = float.NaN;
			*(InlineArray2_Single*)(&expRangeReduction) = cpp_enable_if_sizeof_Complex_float_sizeof_float_complex_cpp_is_trivially_constructible_Complex_float_value_cpp_is_trivially_copyable_Complex_float_value_cpp_is_trivially_copyable_float_complex_value_Complex_float_type_cpp_bit_cast_Complex_float_float_complex_float_complex_const.Invoke(&struct_kh2xpj2);
			expRangeReduction.exp_lo = 0f - expRangeReduction.exp_lo;
			*(InlineArray2_Single*)(&struct_kh2xpj3) = cpp_enable_if_sizeof_float_complex_sizeof_Complex_float_cpp_is_trivially_constructible_float_complex_value_cpp_is_trivially_copyable_float_complex_value_cpp_is_trivially_copyable_Complex_float_value_float_complex_type_cpp_bit_cast_float_complex_Complex_float_Complex_float_const.Invoke(&expRangeReduction);
			float field_ = struct_kh2xpj3.field_0;
			float field_2 = struct_kh2xpj3.field_1;
			float* ptr = &struct_kh2xpj.field_1;
			struct_kh2xpj.field_0 = field_;
			*ptr = field_2;
			llvm_lifetime_end_p0.Invoke(8L, &expRangeReduction);
			return *(InlineArray2_Single*)(&struct_kh2xpj);
		}
	}
}
