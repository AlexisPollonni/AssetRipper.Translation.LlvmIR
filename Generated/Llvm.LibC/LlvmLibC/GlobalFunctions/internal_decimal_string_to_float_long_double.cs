using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_decimal_string_to_float_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal23decimal_string_to_floatIeEENS_14StrToNumResultINS0_13ExpandedFloatIT_EEEEPKccNS0_14RoundDirectionE")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>> __llvm_libc_20_1_2_::internal::decimal_string_to_float<long double>(char const*, char, __llvm_libc_20_1_2_::internal::RoundDirection)")]
	[return: NativeType("__llvm_libc_20_1_2_::StrToNumResult<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>")]
	public unsafe static void Invoke([MangledName("agg.result")] StrToNumResult_ggsbhp* agg_result, [NativeType("char const*")] void* src, [NativeType("char")] sbyte DECIMAL_POINT, [NativeType("__llvm_libc_20_1_2_::internal::RoundDirection")] RoundDirection_b3pcwy round)
	{
		int num = 0;
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		sbyte b4 = 0;
		Int128 @int = default(Int128);
		int num2 = 0;
		long num3 = 0L;
		internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq2 = default(internal_ExpandedFloat_9jummq);
		Int128 int2 = default(Int128);
		int num4 = 0;
		sbyte b5 = 0;
		StrToNumResult_imtnam strToNumResult_imtnam = default(StrToNumResult_imtnam);
		int num5 = 0;
		long num6 = 0L;
		internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq3 = default(internal_ExpandedFloat_9jummq);
		internal_FloatConvertReturn_hgyipa internal_FloatConvertReturn_hgyipa2 = default(internal_FloatConvertReturn_hgyipa);
		internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq4 = default(internal_ExpandedFloat_9jummq);
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
		llvm_lifetime_start_p0.Invoke(16L, &@int);
		@int = 0L;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = 0L;
		llvm_memset_p0_i64.Invoke(agg_result, -86, 48L, isVolatile: false);
		llvm_memset_p0_i64.Invoke(&internal_ExpandedFloat_9jummq2, 0, 32L, isVolatile: false);
		_ = ref internal_ExpandedFloat_9jummq2.mantissa;
		_ = ref internal_ExpandedFloat_9jummq2.exponent;
		StrToNumResult_internal_ExpandedFloat_long_double_Constructor.Invoke(agg_result, &internal_ExpandedFloat_9jummq2);
		llvm_lifetime_start_p0.Invoke(16L, &int2);
		int2 = -7378697629483820647L;
		unchecked
		{
			while (true)
			{
				if (internal_isdigit_u2vjuj.Invoke(((sbyte*)src)[num3]))
				{
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = internal_b36_char_to_int_kxqrdt.Invoke(((sbyte*)src)[num3]);
					b3 = 1;
					if (NumericHelper.IntCmpUlt(@int, -7378697629483820647L))
					{
						@int = NumericHelper.Add(NumericHelper.Multiply(@int, 10L), (Int128)(UInt128)(uint)num4);
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
					llvm_lifetime_end_p0.Invoke(4L, &num4);
				}
				else
				{
					if (((sbyte*)src)[num3] != b6 || (b4 & 1) == 1)
					{
						break;
					}
					b4 = 1;
					num3++;
				}
			}
			if ((b3 & 1) == 1)
			{
				if (internal_tolower_b2645y.Invoke(((sbyte*)src)[num3]) == 101)
				{
					llvm_lifetime_start_p0.Invoke(1L, &b5);
					b5 = 0;
					if (((sbyte*)src)[num3 + 1L] == 43 || ((sbyte*)src)[num3 + 1L] == 45)
					{
						b5 = 1;
					}
					if (internal_isdigit_u2vjuj.Invoke(((sbyte*)src)[num3 + 1L + (((b5 & 1) == 1) ? 1L : 0L)]))
					{
						num3++;
						llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_imtnam);
						*(int*)(&strToNumResult_imtnam) = -1431655766;
						((int*)(&strToNumResult_imtnam))[1] = -1431655766;
						((long*)(&strToNumResult_imtnam))[1] = -6148914691236517206L;
						Struct_fiz2nb struct_fiz2nb = internal_strtointeger_int.Invoke((byte*)src + num3, 10, integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
						StrToNumResult_imtnam* num7 = &strToNumResult_imtnam;
						Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
						*(long*)num7 = struct_fiz2nb2.field_0;
						byte* num8 = (byte*)(&strToNumResult_imtnam) + 8u;
						Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
						*(long*)num8 = struct_fiz2nb3.field_1;
						if (StrToNumResult_int_has_error.Invoke(&strToNumResult_imtnam))
						{
							agg_result->error = strToNumResult_imtnam.error;
						}
						llvm_lifetime_start_p0.Invoke(4L, &num5);
						num5 = strToNumResult_imtnam.value;
						long parsed_len = strToNumResult_imtnam.parsed_len;
						num3 += parsed_len;
						llvm_lifetime_start_p0.Invoke(8L, &num6);
						checked
						{
							num6 = unchecked((long)num2) + unchecked((long)num5);
						}
						num2 = (int)((num6 <= 32767L) ? ((num6 >= -32767L) ? num6 : (-32767)) : 32767);
						llvm_lifetime_end_p0.Invoke(8L, &num6);
						llvm_lifetime_end_p0.Invoke(4L, &num5);
						llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_imtnam);
					}
					llvm_lifetime_end_p0.Invoke(1L, &b5);
				}
				agg_result->parsed_len = num3;
				if (NumericHelper.IntCmpEq(@int, 0L))
				{
					llvm_lifetime_start_p0.Invoke(32L, &internal_ExpandedFloat_9jummq3);
					llvm_memset_p0_i64.Invoke(&internal_ExpandedFloat_9jummq3, 0, 32L, isVolatile: false);
					_ = ref internal_ExpandedFloat_9jummq3.mantissa;
					_ = ref internal_ExpandedFloat_9jummq3.exponent;
					llvm_memcpy_p0_p0_i64.Invoke(&agg_result->value, &internal_ExpandedFloat_9jummq3, 32L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(32L, &internal_ExpandedFloat_9jummq3);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(48L, &internal_FloatConvertReturn_hgyipa2);
					llvm_memset_p0_i64.Invoke(&internal_FloatConvertReturn_hgyipa2, -86, 48L, isVolatile: false);
					internal_ExpandedFloat_9jummq4.mantissa = @int;
					internal_ExpandedFloat_9jummq4.exponent = num2;
					internal_decimal_exp_to_float_long_double.Invoke(&internal_FloatConvertReturn_hgyipa2, &internal_ExpandedFloat_9jummq4, (b2 & 1) == 1, round, src, integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
					llvm_memcpy_p0_p0_i64.Invoke(source: &internal_FloatConvertReturn_hgyipa2.num, destination: &agg_result->value, length: 32L, isVolatile: false);
					agg_result->error = internal_FloatConvertReturn_hgyipa2.error;
					llvm_lifetime_end_p0.Invoke(48L, &internal_FloatConvertReturn_hgyipa2);
				}
			}
			llvm_lifetime_end_p0.Invoke(16L, &int2);
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(16L, &@int);
			llvm_lifetime_end_p0.Invoke(1L, &b4);
			llvm_lifetime_end_p0.Invoke(1L, &b3);
			llvm_lifetime_end_p0.Invoke(1L, &b2);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}
