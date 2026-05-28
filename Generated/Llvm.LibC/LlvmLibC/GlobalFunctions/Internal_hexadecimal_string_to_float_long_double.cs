using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_hexadecimal_string_to_float_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal27hexadecimal_string_to_floatIeEENS_14StrToNumResultINS0_13ExpandedFloatIT_EEEEPKccNS0_14RoundDirectionE")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>> __llvm_libc_20_1_2_::internal::hexadecimal_string_to_float<long double>(char const*, char, __llvm_libc_20_1_2_::internal::RoundDirection)")]
	[return: NativeType("__llvm_libc_20_1_2_::StrToNumResult<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>")]
	public unsafe static void Invoke([MangledName("agg.result")] StrToNumResult_ggsbhp* Agg_result, [MangledName("src")][NativeType("char const*")] void* Src, [NativeType("char")] sbyte DECIMAL_POINT, [MangledName("round")][NativeType("__llvm_libc_20_1_2_::internal::RoundDirection")] RoundDirection_b3pcwy Round)
	{
		int num = 0;
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		sbyte b4 = 0;
		Int128 @int = default(Int128);
		int num2 = 0;
		long num3 = 0L;
		Internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq = default(Internal_ExpandedFloat_9jummq);
		Int128 int2 = default(Int128);
		int num4 = 0;
		sbyte b5 = 0;
		StrToNumResult_imtnam strToNumResult_imtnam = default(StrToNumResult_imtnam);
		int num5 = 0;
		long num6 = 0L;
		Internal_FloatConvertReturn_hgyipa internal_FloatConvertReturn_hgyipa = default(Internal_FloatConvertReturn_hgyipa);
		Internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq2 = default(Internal_ExpandedFloat_9jummq);
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
		Llvm_lifetime_start_p0.Invoke(16L, &@int);
		@int = 0L;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = 0L;
		Llvm_memset_p0_i64.Invoke(Agg_result, -86, 48L, isVolatile: false);
		Llvm_memset_p0_i64.Invoke(&internal_ExpandedFloat_9jummq, 0, 32L, isVolatile: false);
		_ = ref internal_ExpandedFloat_9jummq.Mantissa;
		_ = ref internal_ExpandedFloat_9jummq.Exponent;
		StrToNumResult_internal_ExpandedFloat_long_double_Constructor.Invoke(Agg_result, &internal_ExpandedFloat_9jummq);
		Llvm_lifetime_start_p0.Invoke(16L, &int2);
		int2 = -1L;
		unchecked
		{
			while (true)
			{
				if (Internal_isalnum_eh69hd.Invoke(((sbyte*)Src)[num3]))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = Internal_b36_char_to_int_kxqrdt.Invoke(((sbyte*)Src)[num3]);
					int num7;
					if ((uint)num4 < 16u)
					{
						b3 = 1;
						if (NumericHelper.IntCmpUlt(@int, -1L))
						{
							@int = NumericHelper.Add(NumericHelper.Multiply(@int, 16L), (Int128)(UInt128)(uint)num4);
							if ((b4 & 1) == 1)
							{
								num2 = checked(num2 + -1);
							}
						}
						else
						{
							if (num4 != 0)
							{
								b2 = 1;
							}
							if ((b4 & 1) != 1)
							{
								num2 = checked(num2 + 1);
							}
						}
						num3++;
						num7 = 2;
					}
					else
					{
						num7 = 3;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num4);
					switch (num7)
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
				if (((sbyte*)Src)[num3] != b6 || (b4 & 1) == 1)
				{
					break;
				}
				b4 = 1;
				num3++;
			}
			if ((b3 & 1) == 1)
			{
				num2 = checked(num2 * 4);
				if (Internal_tolower_b2645y.Invoke(((sbyte*)Src)[num3]) == 112)
				{
					Llvm_lifetime_start_p0.Invoke(1L, &b5);
					b5 = 0;
					if (((sbyte*)Src)[num3 + 1L] == 43 || ((sbyte*)Src)[num3 + 1L] == 45)
					{
						b5 = 1;
					}
					if (Internal_isdigit_u2vjuj.Invoke(((sbyte*)Src)[num3 + 1L + (((b5 & 1) == 1) ? 1L : 0L)]))
					{
						num3++;
						Llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_imtnam);
						*(int*)(&strToNumResult_imtnam) = -1431655766;
						((int*)(&strToNumResult_imtnam))[1] = -1431655766;
						((long*)(&strToNumResult_imtnam))[1] = -6148914691236517206L;
						Struct_fiz2nb struct_fiz2nb = Internal_strtointeger_int.Invoke((byte*)Src + num3, 10, Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
						StrToNumResult_imtnam* num8 = &strToNumResult_imtnam;
						Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
						*(long*)num8 = struct_fiz2nb2.field_0;
						byte* num9 = (byte*)(&strToNumResult_imtnam) + 8u;
						Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
						*(long*)num9 = struct_fiz2nb3.field_1;
						if (StrToNumResult_int_has_error.Invoke(&strToNumResult_imtnam))
						{
							Agg_result->Error = strToNumResult_imtnam.Error;
						}
						Llvm_lifetime_start_p0.Invoke(4L, &num5);
						num5 = strToNumResult_imtnam.Value;
						long parsed_len = strToNumResult_imtnam.Parsed_len;
						num3 += parsed_len;
						Llvm_lifetime_start_p0.Invoke(8L, &num6);
						checked
						{
							num6 = unchecked((long)num2) + unchecked((long)num5);
						}
						num2 = (int)((num6 <= 32767L) ? ((num6 >= -32767L) ? num6 : (-32767)) : 32767);
						Llvm_lifetime_end_p0.Invoke(8L, &num6);
						Llvm_lifetime_end_p0.Invoke(4L, &num5);
						Llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_imtnam);
					}
					Llvm_lifetime_end_p0.Invoke(1L, &b5);
				}
				Agg_result->Parsed_len = num3;
				if (NumericHelper.IntCmpEq(@int, 0L))
				{
					Agg_result->Value.Exponent = 0;
					Agg_result->Value.Mantissa = 0L;
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(48L, &internal_FloatConvertReturn_hgyipa);
					Llvm_memset_p0_i64.Invoke(&internal_FloatConvertReturn_hgyipa, -86, 48L, isVolatile: false);
					internal_ExpandedFloat_9jummq2.Mantissa = @int;
					internal_ExpandedFloat_9jummq2.Exponent = num2;
					Internal_binary_exp_to_float_long_double.Invoke(&internal_FloatConvertReturn_hgyipa, &internal_ExpandedFloat_9jummq2, (b2 & 1) == 1, Round);
					Agg_result->Error = internal_FloatConvertReturn_hgyipa.Error;
					Llvm_memcpy_p0_p0_i64.Invoke(source: &internal_FloatConvertReturn_hgyipa.Num, destination: &Agg_result->Value, length: 32L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(48L, &internal_FloatConvertReturn_hgyipa);
				}
			}
			Llvm_lifetime_end_p0.Invoke(16L, &int2);
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(16L, &@int);
			Llvm_lifetime_end_p0.Invoke(1L, &b4);
			Llvm_lifetime_end_p0.Invoke(1L, &b3);
			Llvm_lifetime_end_p0.Invoke(1L, &b2);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}
