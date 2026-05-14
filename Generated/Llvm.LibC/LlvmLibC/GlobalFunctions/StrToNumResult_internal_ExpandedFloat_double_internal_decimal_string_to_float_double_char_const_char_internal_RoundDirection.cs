using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal23decimal_string_to_floatIdEENS_14StrToNumResultINS0_13ExpandedFloatIT_EEEEPKccNS0_14RoundDirectionE")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>> __llvm_libc_20_1_2_::internal::decimal_string_to_float<double>(char const*, char, __llvm_libc_20_1_2_::internal::RoundDirection)")]
internal static partial class StrToNumResult_internal_ExpandedFloat_double_internal_decimal_string_to_float_double_char_const_char_internal_RoundDirection
{
	public unsafe static void Invoke([MangledName("agg.result")] StrToNumResult_wpp2wp* agg_result, void* src, sbyte DECIMAL_POINT, RoundDirection_b3pcwy round)
	{
		int num = 0;
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		sbyte b4 = 0;
		long num2 = 0L;
		int num3 = 0;
		long num4 = 0L;
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv2 = default(internal_ExpandedFloat_k68bhv);
		long num5 = 0L;
		int num6 = 0;
		sbyte b5 = 0;
		StrToNumResult_imtnam strToNumResult_imtnam = default(StrToNumResult_imtnam);
		int num7 = 0;
		long num8 = 0L;
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv3 = default(internal_ExpandedFloat_k68bhv);
		internal_FloatConvertReturn_g92bm8 internal_FloatConvertReturn_g92bm9 = default(internal_FloatConvertReturn_g92bm8);
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv4 = default(internal_ExpandedFloat_k68bhv);
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
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 0L;
		llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num4);
		num4 = 0L;
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
			((long*)agg_result)[3] = -6148914691236517206L;
			internal_ExpandedFloat_k68bhv2.mantissa = 0L;
			internal_ExpandedFloat_k68bhv2.exponent = 0;
			StrToNumResult_internal_ExpandedFloat_double_StrToNumResult_internal_ExpandedFloat_double.Invoke(agg_result, *(long*)(&internal_ExpandedFloat_k68bhv2), ((int*)(&internal_ExpandedFloat_k68bhv2))[2]);
			llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = 1844674407370955161L;
			while (true)
			{
				if (internal_isdigit_int_123.Invoke(((sbyte*)src)[num4]))
				{
					llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = internal_b36_char_to_int_int_122.Invoke(((sbyte*)src)[num4]);
					b3 = 1;
					if ((ulong)num2 < 1844674407370955161uL)
					{
						num2 = num2 * 10L + (uint)num6;
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
				if (internal_tolower_int_120.Invoke(((sbyte*)src)[num4]) == 101)
				{
					llvm_lifetime_start_p0.Invoke(1L, &b5);
					b5 = 0;
					if (((sbyte*)src)[num4 + 1L] == 43 || ((sbyte*)src)[num4 + 1L] == 45)
					{
						b5 = 1;
					}
					if (internal_isdigit_int_123.Invoke(((sbyte*)src)[num4 + 1L + (((b5 & 1) == 1) ? 1L : 0L)]))
					{
						num4++;
						llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_imtnam);
						*(int*)(&strToNumResult_imtnam) = -1431655766;
						((int*)(&strToNumResult_imtnam))[1] = -1431655766;
						((long*)(&strToNumResult_imtnam))[1] = -6148914691236517206L;
						Struct_fiz2nb struct_fiz2nb = StrToNumResult_int_internal_strtointeger_int_char_const_int_unsigned_long.Invoke((byte*)src + num4, 10, cpp_internal_integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
						StrToNumResult_imtnam* num9 = &strToNumResult_imtnam;
						Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
						*(long*)num9 = struct_fiz2nb2.field_0;
						byte* num10 = (byte*)(&strToNumResult_imtnam) + 8u;
						Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
						*(long*)num10 = struct_fiz2nb3.field_1;
						if (StrToNumResult_int_has_error.Invoke(&strToNumResult_imtnam))
						{
							agg_result->error = strToNumResult_imtnam.error;
						}
						llvm_lifetime_start_p0.Invoke(4L, &num7);
						num7 = strToNumResult_imtnam.value;
						long parsed_len = strToNumResult_imtnam.parsed_len;
						num4 += parsed_len;
						llvm_lifetime_start_p0.Invoke(8L, &num8);
						checked
						{
							num8 = unchecked((long)num3) + unchecked((long)num7);
						}
						num3 = (int)((num8 <= 2047L) ? ((num8 >= -2047L) ? num8 : (-2047)) : 2047);
						llvm_lifetime_end_p0.Invoke(8L, &num8);
						llvm_lifetime_end_p0.Invoke(4L, &num7);
						llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_imtnam);
					}
					llvm_lifetime_end_p0.Invoke(1L, &b5);
				}
				agg_result->parsed_len = num4;
				if (num2 == 0L)
				{
					llvm_lifetime_start_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv3);
					internal_ExpandedFloat_k68bhv3.mantissa = 0L;
					internal_ExpandedFloat_k68bhv3.exponent = 0;
					llvm_memcpy_p0_p0_i64.Invoke(&agg_result->value, &internal_ExpandedFloat_k68bhv3, 16L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv3);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(24L, &internal_FloatConvertReturn_g92bm9);
					sbyte* ptr3 = (sbyte*)(&internal_FloatConvertReturn_g92bm9);
					*(long*)ptr3 = -6148914691236517206L;
					((int*)ptr3)[2] = -1431655766;
					sbyte* ptr4 = ptr3 + 12;
					*ptr4 = -86;
					ptr4[1] = -86;
					ptr4[2] = -86;
					ptr4[3] = -86;
					((int*)(&internal_FloatConvertReturn_g92bm9))[4] = -1431655766;
					sbyte* ptr5 = (sbyte*)(&internal_FloatConvertReturn_g92bm9) + 20;
					*ptr5 = -86;
					ptr5[1] = -86;
					ptr5[2] = -86;
					ptr5[3] = -86;
					internal_ExpandedFloat_k68bhv4.mantissa = num2;
					internal_ExpandedFloat_k68bhv4.exponent = num3;
					internal_FloatConvertReturn_double_internal_decimal_exp_to_float_double_internal_ExpandedFloat_double_bool_internal_RoundDirection_char_const_unsigned_long.Invoke(round: (b2 & 1) == 1, numStart: (int)round, num_len: src, mantissa: cpp_internal_integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke(), agg_result: &internal_FloatConvertReturn_g92bm9, init_num: *(long*)(&internal_ExpandedFloat_k68bhv4), truncated: ((int*)(&internal_ExpandedFloat_k68bhv4))[2]);
					llvm_memcpy_p0_p0_i64.Invoke(source: &internal_FloatConvertReturn_g92bm9.num, destination: &agg_result->value, length: 16L, isVolatile: false);
					agg_result->error = internal_FloatConvertReturn_g92bm9.error;
					llvm_lifetime_end_p0.Invoke(24L, &internal_FloatConvertReturn_g92bm9);
				}
			}
			llvm_lifetime_end_p0.Invoke(8L, &num5);
			llvm_lifetime_end_p0.Invoke(8L, &num4);
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(1L, &b4);
			llvm_lifetime_end_p0.Invoke(1L, &b3);
			llvm_lifetime_end_p0.Invoke(1L, &b2);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}
