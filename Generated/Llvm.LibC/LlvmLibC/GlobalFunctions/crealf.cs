using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class crealf
{
	public unsafe static float Invoke([MangledName("x.coerce")] InlineArray2_Single x)
	{
		Struct_kh2xpj struct_kh2xpj = default(Struct_kh2xpj);
		ExpRangeReduction expRangeReduction = default(ExpRangeReduction);
		unchecked
		{
			*(InlineArray2_Single*)(&struct_kh2xpj) = x;
			llvm_lifetime_start_p0.Invoke(8L, &expRangeReduction);
			*(float*)(&expRangeReduction) = float.NaN;
			((float*)(&expRangeReduction))[1] = float.NaN;
			*(InlineArray2_Single*)(&expRangeReduction) = cpp_enable_if_sizeof_Complex_float_sizeof_float_complex_cpp_is_trivially_constructible_Complex_float_value_cpp_is_trivially_copyable_Complex_float_value_cpp_is_trivially_copyable_float_complex_value_Complex_float_type_cpp_bit_cast_Complex_float_float_complex_float_complex_const.Invoke(&struct_kh2xpj);
			float exp_hi_mid = expRangeReduction.exp_hi_mid;
			llvm_lifetime_end_p0.Invoke(8L, &expRangeReduction);
			return exp_hi_mid;
		}
	}
}
