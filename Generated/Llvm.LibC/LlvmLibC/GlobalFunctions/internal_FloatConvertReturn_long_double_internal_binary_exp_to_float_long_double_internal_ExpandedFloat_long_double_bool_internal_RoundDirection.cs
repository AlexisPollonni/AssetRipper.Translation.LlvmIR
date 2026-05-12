using System;
using LlvmLibC.Enumerations;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal19binary_exp_to_floatIeEENS0_18FloatConvertReturnIT_EENS0_13ExpandedFloatIS3_EEbNS0_14RoundDirectionE")]
[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<long double> __llvm_libc_20_1_2_::internal::binary_exp_to_float<long double>(__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>, bool, __llvm_libc_20_1_2_::internal::RoundDirection)")]
internal static partial class internal_FloatConvertReturn_long_double_internal_binary_exp_to_float_long_double_internal_ExpandedFloat_long_double_bool_internal_RoundDirection
{
	public unsafe static void Invoke([MangledName("agg.result")] internal_FloatConvertReturn_hgyipa* agg_result, void* init_num, bool truncated, RoundDirection_b3pcwy round)
	{
		Int128 @int = default(Int128);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq2 = default(internal_ExpandedFloat_9jummq);
		int num5 = 0;
		internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq3 = default(internal_ExpandedFloat_9jummq);
		Int128 int2 = default(Int128);
		Int128 y = default(Int128);
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq4 = default(internal_ExpandedFloat_9jummq);
		sbyte b4 = (truncated ? ((sbyte)1) : ((sbyte)0));
		llvm_lifetime_start_p0.Invoke(16L, &@int);
		unchecked
		{
			@int = ((internal_ExpandedFloat_9jummq*)init_num)->mantissa;
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = ((internal_ExpandedFloat_9jummq*)init_num)->exponent;
			llvm_memset_p0_i64.Invoke(agg_result, -86, 48L, isVolatile: false);
			internal_FloatConvertReturn_long_double_FloatConvertReturn.Invoke(agg_result);
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = 32767;
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			Int128 int3 = @int;
			num3 = cpp_enable_if_cpp_is_unsigned_v_unsigned_int128_int_type_cpp_countl_zero_unsigned_int128_unsigned_int128.Invoke(*(long*)(&int3), ((long*)(&int3))[1]);
			@int = NumericHelper.ShiftLeft(@int, (Int128)(UInt128)(uint)num3);
			num -= num3;
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = checked(num + 128 + 16383 - 1);
			if (num4 >= 32767)
			{
				llvm_lifetime_start_p0.Invoke(32L, &internal_ExpandedFloat_9jummq2);
				llvm_memset_p0_i64.Invoke(&internal_ExpandedFloat_9jummq2, 0, 32L, isVolatile: false);
				_ = ref internal_ExpandedFloat_9jummq2.mantissa;
				internal_ExpandedFloat_9jummq2.exponent = 32767;
				llvm_memcpy_p0_p0_i64.Invoke(&agg_result->num, &internal_ExpandedFloat_9jummq2, 32L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(32L, &internal_ExpandedFloat_9jummq2);
				agg_result->error = 34;
				goto IL_0543;
			}
			llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = 64;
			if (num4 <= 0)
			{
				num5 += checked(1 - num4);
				num4 = 0;
				if ((uint)num5 > 128u)
				{
					llvm_lifetime_start_p0.Invoke(32L, &internal_ExpandedFloat_9jummq3);
					llvm_memset_p0_i64.Invoke(&internal_ExpandedFloat_9jummq3, 0, 32L, isVolatile: false);
					_ = ref internal_ExpandedFloat_9jummq3.mantissa;
					_ = ref internal_ExpandedFloat_9jummq3.exponent;
					llvm_memcpy_p0_p0_i64.Invoke(&agg_result->num, &internal_ExpandedFloat_9jummq3, 32L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(32L, &internal_ExpandedFloat_9jummq3);
					agg_result->error = 34;
					goto IL_0531;
				}
			}
			llvm_lifetime_start_p0.Invoke(16L, &int2);
			int2 = NumericHelper.ShiftLeft(y: (Int128)(UInt128)(uint)(num5 - 1), x: 1L);
			llvm_lifetime_start_p0.Invoke(16L, &y);
			y = NumericHelper.Subtract(int2, 1L);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(@int, int2), 0L) ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(1L, &b2);
			b2 = (sbyte)(byte)((!NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(@int, y), 0L)) ? (((b4 & 1) == 1) ? 1 : 0) : (-1));
			if ((uint)num5 < 128u)
			{
				@int = NumericHelper.ShiftRightLogical(@int, (Int128)(UInt128)(uint)num5);
				@int = NumericHelper.BitwiseAnd(@int, long.MaxValue);
			}
			else
			{
				@int = 0L;
			}
			llvm_lifetime_start_p0.Invoke(1L, &b3);
			b3 = (NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(@int, 1L), 0L) ? ((sbyte)1) : ((sbyte)0));
			switch (round)
			{
			case RoundDirection_b3pcwy.Nearest:
				if ((b & 1) == 1 && ((b3 & 1) == 1 || (b2 & 1) == 1))
				{
					@int = NumericHelper.Add(@int, 1L);
				}
				break;
			case RoundDirection_b3pcwy.Up:
				if ((b & 1) == 1 || (b2 & 1) == 1)
				{
					@int = NumericHelper.Add(@int, 1L);
				}
				break;
			default:
				if ((b & 1) == 1 && (b2 & 1) == 1)
				{
					@int = NumericHelper.Add(@int, 1L);
				}
				break;
			}
		}
		if (NumericHelper.IntCmpUgt(@int, long.MaxValue))
		{
			num4++;
			if (num4 == 32767)
			{
				agg_result->error = 34;
			}
		}
		if (num4 == 0)
		{
			agg_result->error = 34;
		}
		llvm_lifetime_start_p0.Invoke(32L, &internal_ExpandedFloat_9jummq4);
		internal_ExpandedFloat_9jummq4.mantissa = NumericHelper.BitwiseAnd(@int, long.MaxValue);
		internal_ExpandedFloat_9jummq4.exponent = num4;
		llvm_memcpy_p0_p0_i64.Invoke(&agg_result->num, &internal_ExpandedFloat_9jummq4, 32L, isVolatile: false);
		llvm_lifetime_end_p0.Invoke(32L, &internal_ExpandedFloat_9jummq4);
		llvm_lifetime_end_p0.Invoke(1L, &b3);
		llvm_lifetime_end_p0.Invoke(1L, &b2);
		llvm_lifetime_end_p0.Invoke(1L, &b);
		llvm_lifetime_end_p0.Invoke(16L, &y);
		llvm_lifetime_end_p0.Invoke(16L, &int2);
		goto IL_0531;
		IL_0531:
		llvm_lifetime_end_p0.Invoke(4L, &num5);
		goto IL_0543;
		IL_0543:
		llvm_lifetime_end_p0.Invoke(4L, &num4);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(16L, &@int);
	}
}
