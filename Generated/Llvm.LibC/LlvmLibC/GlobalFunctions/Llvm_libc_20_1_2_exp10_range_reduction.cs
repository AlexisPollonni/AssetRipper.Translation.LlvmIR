using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_exp10_range_reduction
{
	[MangledName("_ZN19__llvm_libc_20_1_2_21exp10_range_reductionEDF16_")]
	[DemangledName("__llvm_libc_20_1_2_::exp10_range_reduction(_Float16)")]
	public unsafe static InlineArray2_Single Invoke([MangledName("x")][NativeType("_Float16")] Half X)
	{
		Llvm_libc_20_1_2_ExpRangeReduction llvm_libc_20_1_2_ExpRangeReduction = default(Llvm_libc_20_1_2_ExpRangeReduction);
		float num = 0f;
		float num2 = 0f;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		float x = 0f;
		int x2 = 0;
		float exp_hi_mid = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		float exp_lo = 0f;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = (float)X;
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = Fputil_nearest_integer.Invoke(num * 26.575424f);
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = (int)num2;
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = num3 >>> 3;
			Llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = num3 & 7;
			Llvm_lifetime_start_p0.Invoke(4L, &x);
			x = Fputil_multiply_add_float.Invoke(num2, -0.03762875f, num);
			Llvm_lifetime_start_p0.Invoke(4L, &x2);
			x2 = *(int*)Array_unsigned_int_8ul_Index.Invoke(Index: (uint)num5, This: Llvm_libc_20_1_2_EXP2_MID_BITS_11.Pointer) + (num4 << 23);
			Llvm_lifetime_start_p0.Invoke(4L, &exp_hi_mid);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			FPBits_float_FPBits_unsigned_int.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, x2);
			float num6 = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			exp_hi_mid = num6;
			Llvm_lifetime_start_p0.Invoke(4L, &exp_lo);
			exp_lo = Fputil_polyeval_float_float_float_float_float.Invoke(x, 1f, 2.3025842f, 2.6509514f, 2.0367494f, 1.1711367f);
			llvm_libc_20_1_2_ExpRangeReduction.Exp_hi_mid = exp_hi_mid;
			llvm_libc_20_1_2_ExpRangeReduction.Exp_lo = exp_lo;
			Llvm_lifetime_end_p0.Invoke(4L, &exp_lo);
			Llvm_lifetime_end_p0.Invoke(4L, &exp_hi_mid);
			Llvm_lifetime_end_p0.Invoke(4L, &x2);
			Llvm_lifetime_end_p0.Invoke(4L, &x);
			Llvm_lifetime_end_p0.Invoke(4L, &num5);
			Llvm_lifetime_end_p0.Invoke(4L, &num4);
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return *(InlineArray2_Single*)(&llvm_libc_20_1_2_ExpRangeReduction);
		}
	}
}
