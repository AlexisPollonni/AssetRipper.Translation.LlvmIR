using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal23decimal_string_to_floatIfEENS_14StrToNumResultINS0_13ExpandedFloatIT_EEEEPKccNS0_14RoundDirectionE")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>> __llvm_libc_20_1_2_::internal::decimal_string_to_float<float>(char const*, char, __llvm_libc_20_1_2_::internal::RoundDirection)")]
internal static partial class StrToNumResult_internal_ExpandedFloat_float_internal_decimal_string_to_float_float_char_const_char_internal_RoundDirection
{
	public unsafe static void Invoke([MangledName("agg.result")] StrToNumResult_kkgahp* agg_result, void* src, sbyte DECIMAL_POINT, RoundDirection_b3pcwy round)
	{
		int num = 0;
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		sbyte b4 = 0;
		int num2 = 0;
		int num3 = 0;
		long num4 = 0L;
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up2 = default(internal_ExpandedFloat_i7t5up);
		int num5 = 0;
		int num6 = 0;
		sbyte b5 = 0;
		StrToNumResult_yrtfty strToNumResult_yrtfty = default(StrToNumResult_yrtfty);
		int num7 = 0;
		long num8 = 0L;
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up3 = default(internal_ExpandedFloat_i7t5up);
		internal_FloatConvertReturn_a8f9er internal_FloatConvertReturn_a8f9er2 = default(internal_FloatConvertReturn_a8f9er);
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up4 = default(internal_ExpandedFloat_i7t5up);
		Struct_3driym struct_3driym = default(Struct_3driym);
		sbyte b6 = DECIMAL_POINT;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 10;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		b = 101;
		llvm_lifetime_start_p0.Invoke(1L, &b2);
		b2 = 0;
		llvm_lifetime_start_p0.Invoke(1L, &b3);
		b3 = 0;
		llvm_lifetime_start_p0.Invoke(1L, &b4);
		b4 = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num4);
		num4 = 0L;
		unchecked
		{
			*(int*)agg_result = -1431655766;
			((int*)agg_result)[1] = -1431655766;
			((int*)agg_result)[2] = -1431655766;
			sbyte* ptr = (sbyte*)agg_result + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			((long*)agg_result)[2] = -6148914691236517206L;
			internal_ExpandedFloat_i7t5up2.mantissa = 0;
			internal_ExpandedFloat_i7t5up2.exponent = 0;
			StrToNumResult_internal_ExpandedFloat_float_StrToNumResult_internal_ExpandedFloat_float.Invoke(agg_result, *(long*)(&internal_ExpandedFloat_i7t5up2));
			llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = 429496729;
			while (true)
			{
				if (internal_isdigit_int_121.Invoke(((sbyte*)src)[num4]))
				{
					llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = internal_b36_char_to_int_int_120.Invoke(((sbyte*)src)[num4]);
					b3 = 1;
					if ((uint)num2 < 429496729u)
					{
						num2 = num2 * 10 + num6;
						if ((b4 & 1) == 1)
						{
							num3 = checked(num3 + -1);
						}
					}
					else
					{
						if (num6 != 0)
						{
							b2 = 1;
						}
						if ((b4 & 1) != 1)
						{
							num3 = checked(num3 + 1);
						}
					}
					num4++;
					llvm_lifetime_end_p0.Invoke(4L, &num6);
				}
				else
				{
					if (((sbyte*)src)[num4] != b6 || (b4 & 1) == 1)
					{
						break;
					}
					b4 = 1;
					num4++;
				}
			}
			if ((b3 & 1) == 1)
			{
				if (internal_tolower_int_118.Invoke(((sbyte*)src)[num4]) == 101)
				{
					llvm_lifetime_start_p0.Invoke(1L, &b5);
					b5 = 0;
					if (((sbyte*)src)[num4 + 1L] == 43 || ((sbyte*)src)[num4 + 1L] == 45)
					{
						b5 = 1;
					}
					if (internal_isdigit_int_121.Invoke(((sbyte*)src)[num4 + 1L + (((b5 & 1) == 1) ? 1L : 0L)]))
					{
						num4++;
						llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_yrtfty);
						*(int*)(&strToNumResult_yrtfty) = -1431655766;
						((int*)(&strToNumResult_yrtfty))[1] = -1431655766;
						((long*)(&strToNumResult_yrtfty))[1] = -6148914691236517206L;
						Struct_fiz2nb struct_fiz2nb = StrToNumResult_int_internal_strtointeger_int_char_const_int_unsigned_long.Invoke((byte*)src + num4, 10, cpp_internal_integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
						StrToNumResult_yrtfty* num9 = &strToNumResult_yrtfty;
						Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
						*(long*)num9 = struct_fiz2nb2.field_0;
						byte* num10 = (byte*)(&strToNumResult_yrtfty) + 8u;
						Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
						*(long*)num10 = struct_fiz2nb3.field_1;
						if (StrToNumResult_int_has_error.Invoke(&strToNumResult_yrtfty))
						{
							agg_result->error = strToNumResult_yrtfty.error;
						}
						llvm_lifetime_start_p0.Invoke(4L, &num7);
						num7 = strToNumResult_yrtfty.value;
						long parsed_len = strToNumResult_yrtfty.parsed_len;
						num4 += parsed_len;
						llvm_lifetime_start_p0.Invoke(8L, &num8);
						checked
						{
							num8 = unchecked((long)num3) + unchecked((long)num7);
						}
						num3 = (int)((num8 <= 255L) ? ((num8 >= -255L) ? num8 : (-255)) : 255);
						llvm_lifetime_end_p0.Invoke(8L, &num8);
						llvm_lifetime_end_p0.Invoke(4L, &num7);
						llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_yrtfty);
					}
					llvm_lifetime_end_p0.Invoke(1L, &b5);
				}
				agg_result->parsed_len = num4;
				if (num2 == 0)
				{
					llvm_lifetime_start_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up3);
					internal_ExpandedFloat_i7t5up3.mantissa = 0;
					internal_ExpandedFloat_i7t5up3.exponent = 0;
					llvm_memcpy_p0_p0_i64.Invoke(&agg_result->value, &internal_ExpandedFloat_i7t5up3, 8L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up3);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(12L, &internal_FloatConvertReturn_a8f9er2);
					sbyte* ptr2 = (sbyte*)(&internal_FloatConvertReturn_a8f9er2);
					*(int*)ptr2 = -1431655766;
					((int*)ptr2)[1] = -1431655766;
					((int*)(&internal_FloatConvertReturn_a8f9er2))[2] = -1431655766;
					internal_ExpandedFloat_i7t5up4.mantissa = num2;
					internal_ExpandedFloat_i7t5up4.exponent = num3;
					struct_3driym = internal_FloatConvertReturn_float_internal_decimal_exp_to_float_float_internal_ExpandedFloat_float_bool_internal_RoundDirection_char_const_unsigned_long.Invoke(truncated: (b2 & 1) == 1, round: round, numStart: src, num_len: cpp_internal_integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke(), init_num: *(long*)(&internal_ExpandedFloat_i7t5up4));
					llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er2, &struct_3driym, 12L, isVolatile: false);
					llvm_memcpy_p0_p0_i64.Invoke(source: &internal_FloatConvertReturn_a8f9er2.num, destination: &agg_result->value, length: 8L, isVolatile: false);
					agg_result->error = internal_FloatConvertReturn_a8f9er2.error;
					llvm_lifetime_end_p0.Invoke(12L, &internal_FloatConvertReturn_a8f9er2);
				}
			}
			llvm_lifetime_end_p0.Invoke(4L, &num5);
			llvm_lifetime_end_p0.Invoke(8L, &num4);
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(1L, &b4);
			llvm_lifetime_end_p0.Invoke(1L, &b3);
			llvm_lifetime_end_p0.Invoke(1L, &b2);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}
