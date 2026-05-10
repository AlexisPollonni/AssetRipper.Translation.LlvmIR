using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal25simple_decimal_conversionIdEENS0_18FloatConvertReturnIT_EEPKcmNS0_14RoundDirectionE")]
[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<double> __llvm_libc_20_1_2_::internal::simple_decimal_conversion<double>(char const*, unsigned long, __llvm_libc_20_1_2_::internal::RoundDirection)")]
internal static partial class internal_FloatConvertReturn_double_internal_simple_decimal_conversion_double_char_const_unsigned_long_internal_RoundDirection
{
	public unsafe static void Invoke([MangledName("agg.result")] internal_FloatConvertReturn_g92bm8* agg_result, void* numStart, long num_len, int round)
	{
		int i = 0;
		internal_HighPrecisionDecimal internal_HighPrecisionDecimal2 = default(internal_HighPrecisionDecimal);
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv2 = default(internal_ExpandedFloat_k68bhv);
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv3 = default(internal_ExpandedFloat_k68bhv);
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv4 = default(internal_ExpandedFloat_k68bhv);
		int num = 0;
		int num2 = 0;
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv5 = default(internal_ExpandedFloat_k68bhv);
		long num3 = 0L;
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv6 = default(internal_ExpandedFloat_k68bhv);
		llvm_lifetime_start_p0.Invoke(4L, &i);
		i = 0;
		llvm_lifetime_start_p0.Invoke(812L, &internal_HighPrecisionDecimal2);
		llvm_memset_p0_i64.Invoke(&internal_HighPrecisionDecimal2, -86, 812L, isVolatile: false);
		internal_HighPrecisionDecimal_HighPrecisionDecimal_char_const_unsigned_long.Invoke(&internal_HighPrecisionDecimal2, numStart, num_len);
		unchecked
		{
			*(long*)agg_result = -6148914691236517206L;
			((int*)agg_result)[2] = -1431655766;
			sbyte* ptr = (sbyte*)agg_result + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			((int*)agg_result)[4] = -1431655766;
			sbyte* ptr2 = (sbyte*)agg_result + 20;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			ptr2[3] = -86;
			internal_FloatConvertReturn_double_FloatConvertReturn.Invoke(agg_result);
		}
		if (internal_HighPrecisionDecimal_get_num_digits.Invoke(&internal_HighPrecisionDecimal2) == 0)
		{
			llvm_lifetime_start_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv2);
			internal_ExpandedFloat_k68bhv2.mantissa = 0L;
			internal_ExpandedFloat_k68bhv2.exponent = 0;
			llvm_memcpy_p0_p0_i64.Invoke(&agg_result->num, &internal_ExpandedFloat_k68bhv2, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv2);
		}
		else if (internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) > 0 && internal_exp10_to_exp2_int.Invoke(internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) - 1) > 1023)
		{
			llvm_lifetime_start_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv3);
			internal_ExpandedFloat_k68bhv3.mantissa = 0L;
			internal_ExpandedFloat_k68bhv3.exponent = 2047;
			llvm_memcpy_p0_p0_i64.Invoke(&agg_result->num, &internal_ExpandedFloat_k68bhv3, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv3);
			agg_result->error = 34;
		}
		else if (internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) < 0 && internal_exp10_to_exp2_int.Invoke(-internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2)) > 1075)
		{
			llvm_lifetime_start_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv4);
			internal_ExpandedFloat_k68bhv4.mantissa = 0L;
			internal_ExpandedFloat_k68bhv4.exponent = 0;
			llvm_memcpy_p0_p0_i64.Invoke(&agg_result->num, &internal_ExpandedFloat_k68bhv4, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv4);
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
					long num4 = internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2);
					num = unchecked((byte)((sbyte*)internal_POWERS_OF_TWO.Pointer)[num4]);
				}
				i += num;
				internal_HighPrecisionDecimal_shift_int.Invoke(&internal_HighPrecisionDecimal2, -num);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			while (true)
			{
				int num5;
				if (internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) < 0)
				{
					num5 = -1;
				}
				else
				{
					if (internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) != 0)
					{
						break;
					}
					num5 = ((unchecked((byte)(*(sbyte*)internal_HighPrecisionDecimal_get_digits.Invoke(&internal_HighPrecisionDecimal2))) < 5) ? 1 : 0);
				}
				if (num5 == 0)
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
					long num6 = -internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2);
					num2 = unchecked((byte)((sbyte*)internal_POWERS_OF_TWO.Pointer)[num6]);
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
			i += 1023;
			if (i >= 2047)
			{
				llvm_lifetime_start_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv5);
				internal_ExpandedFloat_k68bhv5.mantissa = 0L;
				internal_ExpandedFloat_k68bhv5.exponent = 2047;
				llvm_memcpy_p0_p0_i64.Invoke(&agg_result->num, &internal_ExpandedFloat_k68bhv5, 16L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv5);
				agg_result->error = 34;
			}
			else
			{
				internal_HighPrecisionDecimal_shift_int.Invoke(&internal_HighPrecisionDecimal2, 52);
				llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = unsigned_long_internal_HighPrecisionDecimal_round_to_integer_type_unsigned_long_internal_RoundDirection.Invoke(&internal_HighPrecisionDecimal2, 2);
				if (i <= 0)
				{
					for (; i < 0; i++)
					{
						internal_HighPrecisionDecimal_shift_int.Invoke(&internal_HighPrecisionDecimal2, -1);
					}
					internal_HighPrecisionDecimal_shift_int.Invoke(&internal_HighPrecisionDecimal2, -1);
					num3 = unsigned_long_internal_HighPrecisionDecimal_round_to_integer_type_unsigned_long_internal_RoundDirection.Invoke(&internal_HighPrecisionDecimal2, round);
					if (num3 >>> 52 != 0L)
					{
						i++;
					}
				}
				if (num3 == 9007199254740992L)
				{
					num3 >>>= 1;
					i++;
					if (i >= 2047)
					{
						agg_result->error = 34;
					}
				}
				if (i == 0)
				{
					agg_result->error = 34;
				}
				llvm_lifetime_start_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv6);
				internal_ExpandedFloat_k68bhv6.mantissa = num3;
				internal_ExpandedFloat_k68bhv6.exponent = i;
				llvm_memcpy_p0_p0_i64.Invoke(&agg_result->num, &internal_ExpandedFloat_k68bhv6, 16L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv6);
				llvm_lifetime_end_p0.Invoke(8L, &num3);
			}
		}
		llvm_lifetime_end_p0.Invoke(812L, &internal_HighPrecisionDecimal2);
		llvm_lifetime_end_p0.Invoke(4L, &i);
	}
}
