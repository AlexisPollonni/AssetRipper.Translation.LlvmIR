using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_hexadecimal_string_to_float_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal27hexadecimal_string_to_floatIfEENS_14StrToNumResultINS0_13ExpandedFloatIT_EEEEPKccNS0_14RoundDirectionE")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>> __llvm_libc_20_1_2_::internal::hexadecimal_string_to_float<float>(char const*, char, __llvm_libc_20_1_2_::internal::RoundDirection)")]
	[return: NativeType("__llvm_libc_20_1_2_::StrToNumResult<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>")]
	public unsafe static void Invoke([MangledName("agg.result")] StrToNumResult_kkgahp* agg_result, [NativeType("char const*")] void* src, [NativeType("char")] sbyte DECIMAL_POINT, [NativeType("__llvm_libc_20_1_2_::internal::RoundDirection")] RoundDirection_b3pcwy round)
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
		StrToNumResult_imtnam strToNumResult_imtnam = default(StrToNumResult_imtnam);
		int num7 = 0;
		long num8 = 0L;
		internal_FloatConvertReturn_a8f9er internal_FloatConvertReturn_a8f9er2 = default(internal_FloatConvertReturn_a8f9er);
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up3 = default(internal_ExpandedFloat_i7t5up);
		Struct_3driym struct_3driym = default(Struct_3driym);
		sbyte b6 = DECIMAL_POINT;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 16;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		b = 112;
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
			StrToNumResult_internal_ExpandedFloat_float_Constructor.Invoke(agg_result, *(long*)(&internal_ExpandedFloat_i7t5up2));
			llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = 268435455;
			while (true)
			{
				if (internal_isalnum_eh69hd.Invoke(((sbyte*)src)[num4]))
				{
					llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = internal_b36_char_to_int_kxqrdt.Invoke(((sbyte*)src)[num4]);
					int num9;
					if ((uint)num6 < 16u)
					{
						b3 = 1;
						if ((uint)num2 < 268435455u)
						{
							num2 = num2 * 16 + num6;
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
						num9 = 2;
					}
					else
					{
						num9 = 3;
					}
					llvm_lifetime_end_p0.Invoke(4L, &num6);
					switch (num9)
					{
					case 2:
						continue;
					case 3:
						break;
					default:
						throw new NotImplementedException("Reached LLVM unreachable instruction.");
					}
					break;
				}
				if (((sbyte*)src)[num4] != b6 || (b4 & 1) == 1)
				{
					break;
				}
				b4 = 1;
				num4++;
			}
			if ((b3 & 1) == 1)
			{
				num3 = checked(num3 * 4);
				if (internal_tolower_b2645y.Invoke(((sbyte*)src)[num4]) == 112)
				{
					llvm_lifetime_start_p0.Invoke(1L, &b5);
					b5 = 0;
					if (((sbyte*)src)[num4 + 1L] == 43 || ((sbyte*)src)[num4 + 1L] == 45)
					{
						b5 = 1;
					}
					if (internal_isdigit_u2vjuj.Invoke(((sbyte*)src)[num4 + 1L + (((b5 & 1) == 1) ? 1L : 0L)]))
					{
						num4++;
						llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_imtnam);
						*(int*)(&strToNumResult_imtnam) = -1431655766;
						((int*)(&strToNumResult_imtnam))[1] = -1431655766;
						((long*)(&strToNumResult_imtnam))[1] = -6148914691236517206L;
						Struct_fiz2nb struct_fiz2nb = internal_strtointeger_int.Invoke((byte*)src + num4, 10, integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
						StrToNumResult_imtnam* num10 = &strToNumResult_imtnam;
						Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
						*(long*)num10 = struct_fiz2nb2.field_0;
						byte* num11 = (byte*)(&strToNumResult_imtnam) + 8u;
						Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
						*(long*)num11 = struct_fiz2nb3.field_1;
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
						num3 = (int)((num8 <= 255L) ? ((num8 >= -255L) ? num8 : (-255)) : 255);
						llvm_lifetime_end_p0.Invoke(8L, &num8);
						llvm_lifetime_end_p0.Invoke(4L, &num7);
						llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_imtnam);
					}
					llvm_lifetime_end_p0.Invoke(1L, &b5);
				}
				agg_result->parsed_len = num4;
				if (num2 == 0)
				{
					agg_result->value.exponent = 0;
					agg_result->value.mantissa = 0;
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(12L, &internal_FloatConvertReturn_a8f9er2);
					sbyte* ptr2 = (sbyte*)(&internal_FloatConvertReturn_a8f9er2);
					*(int*)ptr2 = -1431655766;
					((int*)ptr2)[1] = -1431655766;
					((int*)(&internal_FloatConvertReturn_a8f9er2))[2] = -1431655766;
					internal_ExpandedFloat_i7t5up3.mantissa = num2;
					internal_ExpandedFloat_i7t5up3.exponent = num3;
					struct_3driym = internal_binary_exp_to_float_float.Invoke(truncated: (b2 & 1) == 1, init_num: *(long*)(&internal_ExpandedFloat_i7t5up3), round: round);
					llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er2, &struct_3driym, 12L, isVolatile: false);
					agg_result->error = internal_FloatConvertReturn_a8f9er2.error;
					llvm_memcpy_p0_p0_i64.Invoke(source: &internal_FloatConvertReturn_a8f9er2.num, destination: &agg_result->value, length: 8L, isVolatile: false);
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
