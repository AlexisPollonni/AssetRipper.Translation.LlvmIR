using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_19exp_range_reductionEDF16_")]
[DemangledName("__llvm_libc_20_1_2_::exp_range_reduction(_Float16)")]
internal static partial class exp_range_reduction_Float16
{
	public unsafe static InlineArray2_Single Invoke(Half x)
	{
		ExpRangeReduction expRangeReduction = default(ExpRangeReduction);
		float num = 0f;
		float num2 = 0f;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		float x2 = 0f;
		float num6 = 0f;
		float num7 = 0f;
		float exp_lo = 0f;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = (float)x;
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = fputil_nearest_integer_float.Invoke(num * 8f);
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = (int)num2;
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = num3 >> 3;
			llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = num3 & 7;
			llvm_lifetime_start_p0.Invoke(4L, &x2);
			x2 = fputil_multiply_add_float_float_float.Invoke(num2, -0.125f, num);
			llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = *(float*)cpp_array_float_31ul_operator_unsigned_long_const.Invoke(Index: checked(num4 + 18), @this: EXP_HI.Pointer);
			llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = *(float*)cpp_array_float_8ul_operator_unsigned_long_const.Invoke(Index: num5, @this: EXP_MID.Pointer);
			llvm_lifetime_start_p0.Invoke(4L, &exp_lo);
			exp_lo = cpp_enable_if_sizeof_float_8ul_float_type_fputil_polyeval_float_float_float_float_float_float_float_float_float.Invoke(x2, 1f, 1f, 0.5001221f, 0.16668294f);
			expRangeReduction.exp_hi_mid = num6 * num7;
			expRangeReduction.exp_lo = exp_lo;
			llvm_lifetime_end_p0.Invoke(4L, &exp_lo);
			llvm_lifetime_end_p0.Invoke(4L, &num7);
			llvm_lifetime_end_p0.Invoke(4L, &num6);
			llvm_lifetime_end_p0.Invoke(4L, &x2);
			llvm_lifetime_end_p0.Invoke(4L, &num5);
			llvm_lifetime_end_p0.Invoke(4L, &num4);
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return *(InlineArray2_Single*)(&expRangeReduction);
		}
	}
}
