using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_decimal_string_to_float_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal23decimal_string_to_floatIdEENS_14StrToNumResultINS0_13ExpandedFloatIT_EEEEPKccNS0_14RoundDirectionE")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>> __llvm_libc_20_1_2_::internal::decimal_string_to_float<double>(char const*, char, __llvm_libc_20_1_2_::internal::RoundDirection)")]
	[return: NativeType("__llvm_libc_20_1_2_::StrToNumResult<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>>")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_StrToNumResult_wpp2wp* Agg_result, [MangledName("src")][NativeType("char const*")] void* Src, [NativeType("char")] sbyte DECIMAL_POINT, [MangledName("round")][NativeType("__llvm_libc_20_1_2_::internal::RoundDirection")] RoundDirection_b3pcwy Round)
	{
		int num = 0;
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		sbyte b4 = 0;
		long num2 = 0L;
		int num3 = 0;
		long num4 = 0L;
		Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv = default(Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv);
		long num5 = 0L;
		int num6 = 0;
		sbyte b5 = 0;
		Llvm_libc_20_1_2_StrToNumResult_imtnam llvm_libc_20_1_2_StrToNumResult_imtnam = default(Llvm_libc_20_1_2_StrToNumResult_imtnam);
		int num7 = 0;
		long num8 = 0L;
		Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv);
		Llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm8 llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm = default(Llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm8);
		Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv3 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv);
		sbyte b6 = DECIMAL_POINT;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 10;
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		b = 101;
		Llvm_lifetime_start_p0.Invoke(1L, &b2);
		b2 = 0;
		Llvm_lifetime_start_p0.Invoke(1L, &b3);
		b3 = 0;
		Llvm_lifetime_start_p0.Invoke(1L, &b4);
		b4 = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 0L;
		Llvm_lifetime_start_p0.Invoke(4L, &num3);
		num3 = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &num4);
		num4 = 0L;
		unchecked
		{
			*(long*)Agg_result = -6148914691236517206L;
			((int*)Agg_result)[2] = -1431655766;
			sbyte* ptr = (sbyte*)Agg_result + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			((int*)Agg_result)[4] = -1431655766;
			sbyte* ptr2 = (sbyte*)Agg_result + 20;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			ptr2[3] = -86;
			((long*)Agg_result)[3] = -6148914691236517206L;
			llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv.Mantissa = 0L;
			llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv.Exponent = 0;
			StrToNumResult_internal_ExpandedFloat_double_Constructor.Invoke(Agg_result, *(long*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv), ((int*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv))[2]);
			Llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = 1844674407370955161L;
			while (true)
			{
				if (Internal_isdigit_u2vjuj.Invoke(((sbyte*)Src)[num4]))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num6);
					num6 = Internal_b36_char_to_int_kxqrdt.Invoke(((sbyte*)Src)[num4]);
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
					Llvm_lifetime_end_p0.Invoke(4L, &num6);
				}
				else
				{
					if (((sbyte*)Src)[num4] != b6 || (b4 & 1) == 1)
					{
						break;
					}
					b4 = 1;
					num4++;
				}
			}
			if ((b3 & 1) == 1)
			{
				if (Internal_tolower_b2645y.Invoke(((sbyte*)Src)[num4]) == 101)
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
						Llvm_libc_20_1_2_StrToNumResult_imtnam* num9 = &llvm_libc_20_1_2_StrToNumResult_imtnam;
						Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
						*(long*)num9 = struct_fiz2nb2.field_0;
						byte* num10 = (byte*)(&llvm_libc_20_1_2_StrToNumResult_imtnam) + 8u;
						Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
						*(long*)num10 = struct_fiz2nb3.field_1;
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
						num3 = (int)((num8 <= 2047L) ? ((num8 >= -2047L) ? num8 : (-2047)) : 2047);
						Llvm_lifetime_end_p0.Invoke(8L, &num8);
						Llvm_lifetime_end_p0.Invoke(4L, &num7);
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_StrToNumResult_imtnam);
					}
					Llvm_lifetime_end_p0.Invoke(1L, &b5);
				}
				Agg_result->Parsed_len = num4;
				if (num2 == 0L)
				{
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2);
					llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2.Mantissa = 0L;
					llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2.Exponent = 0;
					Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Value, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2, 16L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm);
					sbyte* ptr3 = (sbyte*)(&llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm);
					*(long*)ptr3 = -6148914691236517206L;
					((int*)ptr3)[2] = -1431655766;
					sbyte* ptr4 = ptr3 + 12;
					*ptr4 = -86;
					ptr4[1] = -86;
					ptr4[2] = -86;
					ptr4[3] = -86;
					((int*)(&llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm))[4] = -1431655766;
					sbyte* ptr5 = (sbyte*)(&llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm) + 20;
					*ptr5 = -86;
					ptr5[1] = -86;
					ptr5[2] = -86;
					ptr5[3] = -86;
					llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv3.Mantissa = num2;
					llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv3.Exponent = num3;
					Internal_decimal_exp_to_float_double.Invoke(Round: (b2 & 1) == 1, NumStart: (int)Round, Num_len: Src, Mantissa: Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke(), Agg_result: &llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm, Init_num: *(long*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv3), Truncated: ((int*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv3))[2]);
					Llvm_memcpy_p0_p0_i64.Invoke(source: &llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm.Num, destination: &Agg_result->Value, length: 16L, isVolatile: false);
					Agg_result->Error = llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm.Error;
					Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm);
				}
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num5);
			Llvm_lifetime_end_p0.Invoke(8L, &num4);
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(1L, &b4);
			Llvm_lifetime_end_p0.Invoke(1L, &b3);
			Llvm_lifetime_end_p0.Invoke(1L, &b2);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}
