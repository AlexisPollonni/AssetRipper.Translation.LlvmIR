using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_20exp2_range_reductionEDF16_")]
[DemangledName("__llvm_libc_20_1_2_::exp2_range_reduction(_Float16)")]
internal static partial class exp2_range_reduction_Float16
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
		int x3 = 0;
		float exp_hi_mid = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
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
			num4 = num3 >>> 3;
			llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = num3 & 7;
			llvm_lifetime_start_p0.Invoke(4L, &x2);
			x2 = cpp_enable_if_sizeof_float_8ul_float_type_fputil_multiply_add_float_float_float_float.Invoke(num2, -0.125f, num);
			llvm_lifetime_start_p0.Invoke(4L, &x3);
			x3 = *(int*)cpp_array_unsigned_int_8ul_operator_unsigned_long_const.Invoke(Index: (uint)num5, @this: EXP2_MID_BITS.Pointer) + (num4 << 23);
			llvm_lifetime_start_p0.Invoke(4L, &exp_hi_mid);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			fputil_FPBits_float_FPBits_unsigned_int_unsigned_int.Invoke(&fputil_FPBits_5nkvcs2, x3);
			float num6 = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			exp_hi_mid = num6;
			llvm_lifetime_start_p0.Invoke(4L, &exp_lo);
			exp_lo = cpp_enable_if_sizeof_float_8ul_float_type_fputil_polyeval_float_float_float_float_float_float_float_float_float.Invoke(x2, 1f, 0.6931472f, 0.24025469f, 0.05550606f);
			expRangeReduction.exp_hi_mid = exp_hi_mid;
			expRangeReduction.exp_lo = exp_lo;
			llvm_lifetime_end_p0.Invoke(4L, &exp_lo);
			llvm_lifetime_end_p0.Invoke(4L, &exp_hi_mid);
			llvm_lifetime_end_p0.Invoke(4L, &x3);
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
