using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal25simple_decimal_conversionIeEENS0_18FloatConvertReturnIT_EEPKcmNS0_14RoundDirectionE")]
[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<long double> __llvm_libc_20_1_2_::internal::simple_decimal_conversion<long double>(char const*, unsigned long, __llvm_libc_20_1_2_::internal::RoundDirection)")]
internal static partial class internal_FloatConvertReturn_long_double_internal_simple_decimal_conversion_long_double_char_const_unsigned_long_internal_RoundDirection
{
	public unsafe static void Invoke([MangledName("agg.result")] internal_FloatConvertReturn_hgyipa* agg_result, void* numStart, long num_len, RoundDirection_b3pcwy round)
	{
		int i = 0;
		internal_HighPrecisionDecimal internal_HighPrecisionDecimal2 = default(internal_HighPrecisionDecimal);
		internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq2 = default(internal_ExpandedFloat_9jummq);
		internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq3 = default(internal_ExpandedFloat_9jummq);
		internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq4 = default(internal_ExpandedFloat_9jummq);
		int num = 0;
		int num2 = 0;
		internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq5 = default(internal_ExpandedFloat_9jummq);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq6 = default(internal_ExpandedFloat_9jummq);
		llvm_lifetime_start_p0.Invoke(4L, &i);
		i = 0;
		llvm_lifetime_start_p0.Invoke(812L, &internal_HighPrecisionDecimal2);
		llvm_memset_p0_i64.Invoke(&internal_HighPrecisionDecimal2, -86, 812L, isVolatile: false);
		internal_HighPrecisionDecimal_HighPrecisionDecimal_char_const_unsigned_long.Invoke(&internal_HighPrecisionDecimal2, numStart, num_len);
		llvm_memset_p0_i64.Invoke(agg_result, -86, 48L, isVolatile: false);
		internal_FloatConvertReturn_long_double_FloatConvertReturn.Invoke(agg_result);
		if (internal_HighPrecisionDecimal_get_num_digits.Invoke(&internal_HighPrecisionDecimal2) == 0)
		{
			llvm_lifetime_start_p0.Invoke(32L, &internal_ExpandedFloat_9jummq2);
			llvm_memset_p0_i64.Invoke(&internal_ExpandedFloat_9jummq2, 0, 32L, isVolatile: false);
			_ = ref internal_ExpandedFloat_9jummq2.mantissa;
			_ = ref internal_ExpandedFloat_9jummq2.exponent;
			llvm_memcpy_p0_p0_i64.Invoke(&agg_result->num, &internal_ExpandedFloat_9jummq2, 32L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(32L, &internal_ExpandedFloat_9jummq2);
		}
		else if (internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) > 0 && internal_exp10_to_exp2_int.Invoke(internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) - 1) > 16383)
		{
			llvm_lifetime_start_p0.Invoke(32L, &internal_ExpandedFloat_9jummq3);
			llvm_memset_p0_i64.Invoke(&internal_ExpandedFloat_9jummq3, 0, 32L, isVolatile: false);
			_ = ref internal_ExpandedFloat_9jummq3.mantissa;
			internal_ExpandedFloat_9jummq3.exponent = 32767;
			llvm_memcpy_p0_p0_i64.Invoke(&agg_result->num, &internal_ExpandedFloat_9jummq3, 32L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(32L, &internal_ExpandedFloat_9jummq3);
			agg_result->error = 34;
		}
		else if (internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) < 0 && internal_exp10_to_exp2_int.Invoke(-internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2)) > 16446)
		{
			llvm_lifetime_start_p0.Invoke(32L, &internal_ExpandedFloat_9jummq4);
			llvm_memset_p0_i64.Invoke(&internal_ExpandedFloat_9jummq4, 0, 32L, isVolatile: false);
			_ = ref internal_ExpandedFloat_9jummq4.mantissa;
			_ = ref internal_ExpandedFloat_9jummq4.exponent;
			llvm_memcpy_p0_p0_i64.Invoke(&agg_result->num, &internal_ExpandedFloat_9jummq4, 32L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(32L, &internal_ExpandedFloat_9jummq4);
			agg_result->error = 34;
		}
		else
		{
			while (internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) > 0)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = 0;
				if (internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) >= 19)
				{
					num = 60;
				}
				else
				{
					long num3 = internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2);
					num = unchecked((byte)((sbyte*)internal_POWERS_OF_TWO.Pointer)[num3]);
				}
				i += num;
				internal_HighPrecisionDecimal_shift_int.Invoke(&internal_HighPrecisionDecimal2, -num);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			while (true)
			{
				int num4;
				if (internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) < 0)
				{
					num4 = -1;
				}
				else
				{
					if (internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) != 0)
					{
						break;
					}
					num4 = ((unchecked((byte)(*(sbyte*)internal_HighPrecisionDecimal_get_digits.Invoke(&internal_HighPrecisionDecimal2))) < 5) ? 1 : 0);
				}
				if (num4 == 0)
				{
					break;
				}
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = 0;
				if (-internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) >= 19)
				{
					num2 = 60;
				}
				else if (internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) != 0)
				{
					long num5 = -internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2);
					num2 = unchecked((byte)((sbyte*)internal_POWERS_OF_TWO.Pointer)[num5]);
				}
				else
				{
					num2 = 1;
				}
				i -= num2;
				internal_HighPrecisionDecimal_shift_int.Invoke(&internal_HighPrecisionDecimal2, num2);
				llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			i += -1;
			internal_HighPrecisionDecimal_shift_int.Invoke(&internal_HighPrecisionDecimal2, 1);
			i += 16383;
			if (i >= 32767)
			{
				llvm_lifetime_start_p0.Invoke(32L, &internal_ExpandedFloat_9jummq5);
				llvm_memset_p0_i64.Invoke(&internal_ExpandedFloat_9jummq5, 0, 32L, isVolatile: false);
				_ = ref internal_ExpandedFloat_9jummq5.mantissa;
				internal_ExpandedFloat_9jummq5.exponent = 32767;
				llvm_memcpy_p0_p0_i64.Invoke(&agg_result->num, &internal_ExpandedFloat_9jummq5, 32L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(32L, &internal_ExpandedFloat_9jummq5);
				agg_result->error = 34;
			}
			else
			{
				internal_HighPrecisionDecimal_shift_int.Invoke(&internal_HighPrecisionDecimal2, 63);
				llvm_lifetime_start_p0.Invoke(16L, &@int);
				Struct_fiz2nb struct_fiz2nb = unsigned_int128_internal_HighPrecisionDecimal_round_to_integer_type_unsigned_int128_internal_RoundDirection.Invoke(&internal_HighPrecisionDecimal2, RoundDirection_b3pcwy.Nearest);
				Int128* num6 = &int2;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				unchecked
				{
					*(long*)num6 = struct_fiz2nb2.field_0;
					byte* num7 = (byte*)(&int2) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num7 = struct_fiz2nb3.field_1;
					@int = int2;
				}
				if (i <= 0)
				{
					for (; i < 0; i++)
					{
						internal_HighPrecisionDecimal_shift_int.Invoke(&internal_HighPrecisionDecimal2, -1);
					}
					internal_HighPrecisionDecimal_shift_int.Invoke(&internal_HighPrecisionDecimal2, -1);
					Struct_fiz2nb struct_fiz2nb4 = unsigned_int128_internal_HighPrecisionDecimal_round_to_integer_type_unsigned_int128_internal_RoundDirection.Invoke(&internal_HighPrecisionDecimal2, round);
					Int128* num8 = &int3;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					unchecked
					{
						*(long*)num8 = struct_fiz2nb5.field_0;
						byte* num9 = (byte*)(&int3) + 8u;
						Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
						*(long*)num9 = struct_fiz2nb6.field_1;
						@int = int3;
					}
					if (NumericHelper.IntCmpNe(NumericHelper.ShiftRightLogical(@int, 63L), 0L))
					{
						i++;
					}
				}
				if (NumericHelper.IntCmpEq(@int, 0L))
				{
					@int = NumericHelper.ShiftRightLogical(@int, 1L);
					i++;
					if (i >= 32767)
					{
						agg_result->error = 34;
					}
				}
				if (i == 0)
				{
					agg_result->error = 34;
				}
				llvm_lifetime_start_p0.Invoke(32L, &internal_ExpandedFloat_9jummq6);
				internal_ExpandedFloat_9jummq6.mantissa = @int;
				internal_ExpandedFloat_9jummq6.exponent = i;
				llvm_memcpy_p0_p0_i64.Invoke(&agg_result->num, &internal_ExpandedFloat_9jummq6, 32L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(32L, &internal_ExpandedFloat_9jummq6);
				llvm_lifetime_end_p0.Invoke(16L, &@int);
			}
		}
		llvm_lifetime_end_p0.Invoke(812L, &internal_HighPrecisionDecimal2);
		llvm_lifetime_end_p0.Invoke(4L, &i);
	}
}
