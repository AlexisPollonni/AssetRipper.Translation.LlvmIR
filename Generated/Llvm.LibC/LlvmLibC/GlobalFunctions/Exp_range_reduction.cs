using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Exp_range_reduction
{
	[MangledName("_ZN19__llvm_libc_20_1_2_19exp_range_reductionEDF16_")]
	[DemangledName("__llvm_libc_20_1_2_::exp_range_reduction(_Float16)")]
	public unsafe static InlineArray2_Single Invoke([MangledName("x")][NativeType("_Float16")] Half X)
	{
		ExpRangeReduction expRangeReduction = default(ExpRangeReduction);
		float num = 0f;
		float num2 = 0f;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		float x = 0f;
		float num6 = 0f;
		float num7 = 0f;
		float exp_lo = 0f;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = (float)X;
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = Fputil_nearest_integer.Invoke(num * 8f);
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = (int)num2;
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = num3 >> 3;
			Llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = num3 & 7;
			Llvm_lifetime_start_p0.Invoke(4L, &x);
			x = Fputil_multiply_add_float.Invoke(num2, -0.125f, num);
			Llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = *(float*)Array_float_31ul_Index.Invoke(Index: checked(num4 + 18), This: EXP_HI.Pointer);
			Llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = *(float*)Array_float_8ul_Index.Invoke(Index: num5, This: EXP_MID.Pointer);
			Llvm_lifetime_start_p0.Invoke(4L, &exp_lo);
			exp_lo = Fputil_polyeval_float_float_float_float.Invoke(x, 1f, 1f, 0.5001221f, 0.16668294f);
			expRangeReduction.Exp_hi_mid = num6 * num7;
			expRangeReduction.Exp_lo = exp_lo;
			Llvm_lifetime_end_p0.Invoke(4L, &exp_lo);
			Llvm_lifetime_end_p0.Invoke(4L, &num7);
			Llvm_lifetime_end_p0.Invoke(4L, &num6);
			Llvm_lifetime_end_p0.Invoke(4L, &x);
			Llvm_lifetime_end_p0.Invoke(4L, &num5);
			Llvm_lifetime_end_p0.Invoke(4L, &num4);
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return *(InlineArray2_Single*)(&expRangeReduction);
		}
	}
}
