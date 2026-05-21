using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_hexadecimal_string_to_float_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal27hexadecimal_string_to_floatIfEENS_14StrToNumResultINS0_13ExpandedFloatIT_EEEEPKccNS0_14RoundDirectionE")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>> __llvm_libc_20_1_2_::internal::hexadecimal_string_to_float<float>(char const*, char, __llvm_libc_20_1_2_::internal::RoundDirection)")]
	[return: NativeType("__llvm_libc_20_1_2_::StrToNumResult<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_StrToNumResult_kkgahp* Agg_result, [MangledName("src")][NativeType("char const*")] void* Src, [NativeType("char")] sbyte DECIMAL_POINT, [MangledName("round")][NativeType("__llvm_libc_20_1_2_::internal::RoundDirection")] RoundDirection_b3pcwy Round)
	{
		int num = 0;
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		sbyte b4 = 0;
		int num2 = 0;
		int num3 = 0;
		long num4 = 0L;
		Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up = default(Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up);
		int num5 = 0;
		int num6 = 0;
		sbyte b5 = 0;
		Llvm_libc_20_1_2_StrToNumResult_imtnam llvm_libc_20_1_2_StrToNumResult_imtnam = default(Llvm_libc_20_1_2_StrToNumResult_imtnam);
		int num7 = 0;
		long num8 = 0L;
		Llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er = default(Llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er);
		Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up);
		Struct_3driym struct_3driym = default(Struct_3driym);
		sbyte b6 = DECIMAL_POINT;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 16;
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		b = 112;
		Llvm_lifetime_start_p0.Invoke(1L, &b2);
		b2 = 0;
		Llvm_lifetime_start_p0.Invoke(1L, &b3);
		b3 = 0;
		Llvm_lifetime_start_p0.Invoke(1L, &b4);
		b4 = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &num4);
		num4 = 0L;
		unchecked
		{
			*(int*)Agg_result = -1431655766;
			((int*)Agg_result)[1] = -1431655766;
			((int*)Agg_result)[2] = -1431655766;
			sbyte* ptr = (sbyte*)Agg_result + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			((long*)Agg_result)[2] = -6148914691236517206L;
			llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up.Mantissa = 0;
			llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up.Exponent = 0;
			StrToNumResult_internal_ExpandedFloat_float_Constructor.Invoke(Agg_result, *(long*)(&llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up));
			Llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = 268435455;
			while (true)
			{
				if (Internal_isalnum_eh69hd.Invoke(((sbyte*)Src)[num4]))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = Internal_b36_char_to_int_kxqrdt.Invoke(((sbyte*)Src)[num4]);
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
					Llvm_lifetime_end_p0.Invoke(4L, &num6);
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
				if (((sbyte*)Src)[num4] != b6 || (b4 & 1) == 1)
				{
					break;
				}
				b4 = 1;
				num4++;
			}
			if ((b3 & 1) == 1)
			{
				num3 = checked(num3 * 4);
				if (Internal_tolower_b2645y.Invoke(((sbyte*)Src)[num4]) == 112)
				{
					Llvm_lifetime_start_p0.Invoke(1L, &b5);
					b5 = 0;
					if (((sbyte*)Src)[num4 + 1L] == 43 || ((sbyte*)Src)[num4 + 1L] == 45)
					{
						b5 = 1;
					}
					if (Internal_isdigit_u2vjuj.Invoke(((sbyte*)Src)[num4 + 1L + (((b5 & 1) == 1) ? 1L : 0L)]))
					{
						num4++;
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_StrToNumResult_imtnam);
						*(int*)(&llvm_libc_20_1_2_StrToNumResult_imtnam) = -1431655766;
						((int*)(&llvm_libc_20_1_2_StrToNumResult_imtnam))[1] = -1431655766;
						((long*)(&llvm_libc_20_1_2_StrToNumResult_imtnam))[1] = -6148914691236517206L;
						Struct_fiz2nb struct_fiz2nb = Internal_strtointeger_int.Invoke((byte*)Src + num4, 10, Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
						Llvm_libc_20_1_2_StrToNumResult_imtnam* num10 = &llvm_libc_20_1_2_StrToNumResult_imtnam;
						Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
						*(long*)num10 = struct_fiz2nb2.field_0;
						byte* num11 = (byte*)(&llvm_libc_20_1_2_StrToNumResult_imtnam) + 8u;
						Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
						*(long*)num11 = struct_fiz2nb3.field_1;
						if (StrToNumResult_int_has_error.Invoke(&llvm_libc_20_1_2_StrToNumResult_imtnam))
						{
							Agg_result->Error = llvm_libc_20_1_2_StrToNumResult_imtnam.Error;
						}
						Llvm_lifetime_start_p0.Invoke(4L, &num7);
						num7 = llvm_libc_20_1_2_StrToNumResult_imtnam.Value;
						long parsed_len = llvm_libc_20_1_2_StrToNumResult_imtnam.Parsed_len;
						num4 += parsed_len;
						Llvm_lifetime_start_p0.Invoke(8L, &num8);
						checked
						{
							num8 = unchecked((long)num3) + unchecked((long)num7);
						}
						num3 = (int)((num8 <= 255L) ? ((num8 >= -255L) ? num8 : (-255)) : 255);
						Llvm_lifetime_end_p0.Invoke(8L, &num8);
						Llvm_lifetime_end_p0.Invoke(4L, &num7);
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_StrToNumResult_imtnam);
					}
					Llvm_lifetime_end_p0.Invoke(1L, &b5);
				}
				Agg_result->Parsed_len = num4;
				if (num2 == 0)
				{
					Agg_result->Value.Exponent = 0;
					Agg_result->Value.Mantissa = 0;
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(12L, &llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er);
					sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er);
					*(int*)ptr2 = -1431655766;
					((int*)ptr2)[1] = -1431655766;
					((int*)(&llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er))[2] = -1431655766;
					llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2.Mantissa = num2;
					llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2.Exponent = num3;
					struct_3driym = Internal_binary_exp_to_float_float.Invoke(Truncated: (b2 & 1) == 1, Init_num: *(long*)(&llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2), Round: Round);
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er, &struct_3driym, 12L, isVolatile: false);
					Agg_result->Error = llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er.Error;
					Llvm_memcpy_p0_p0_i64.Invoke(source: &llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er.Num, destination: &Agg_result->Value, length: 8L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(12L, &llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er);
				}
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num5);
			Llvm_lifetime_end_p0.Invoke(8L, &num4);
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(1L, &b4);
			Llvm_lifetime_end_p0.Invoke(1L, &b3);
			Llvm_lifetime_end_p0.Invoke(1L, &b2);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}
