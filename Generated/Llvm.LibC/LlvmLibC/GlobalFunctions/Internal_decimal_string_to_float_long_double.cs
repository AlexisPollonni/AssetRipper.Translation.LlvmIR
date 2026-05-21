using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_decimal_string_to_float_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal23decimal_string_to_floatIeEENS_14StrToNumResultINS0_13ExpandedFloatIT_EEEEPKccNS0_14RoundDirectionE")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>> __llvm_libc_20_1_2_::internal::decimal_string_to_float<long double>(char const*, char, __llvm_libc_20_1_2_::internal::RoundDirection)")]
	[return: NativeType("__llvm_libc_20_1_2_::StrToNumResult<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_StrToNumResult_ggsbhp* Agg_result, [MangledName("src")][NativeType("char const*")] void* Src, [NativeType("char")] sbyte DECIMAL_POINT, [MangledName("round")][NativeType("__llvm_libc_20_1_2_::internal::RoundDirection")] RoundDirection_b3pcwy Round)
	{
		int num = 0;
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		sbyte b4 = 0;
		Int128 @int = default(Int128);
		int num2 = 0;
		long num3 = 0L;
		Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq llvm_libc_20_1_2_internal_ExpandedFloat_9jummq = default(Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq);
		Int128 int2 = default(Int128);
		int num4 = 0;
		sbyte b5 = 0;
		Llvm_libc_20_1_2_StrToNumResult_imtnam llvm_libc_20_1_2_StrToNumResult_imtnam = default(Llvm_libc_20_1_2_StrToNumResult_imtnam);
		int num5 = 0;
		long num6 = 0L;
		Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq llvm_libc_20_1_2_internal_ExpandedFloat_9jummq2 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq);
		Llvm_libc_20_1_2_internal_FloatConvertReturn_hgyipa llvm_libc_20_1_2_internal_FloatConvertReturn_hgyipa = default(Llvm_libc_20_1_2_internal_FloatConvertReturn_hgyipa);
		Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq llvm_libc_20_1_2_internal_ExpandedFloat_9jummq3 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq);
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
		Llvm_lifetime_start_p0.Invoke(16L, &@int);
		@int = 0L;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = 0L;
		Llvm_memset_p0_i64.Invoke(Agg_result, -86, 48L, isVolatile: false);
		Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_internal_ExpandedFloat_9jummq, 0, 32L, isVolatile: false);
		_ = ref llvm_libc_20_1_2_internal_ExpandedFloat_9jummq.Mantissa;
		_ = ref llvm_libc_20_1_2_internal_ExpandedFloat_9jummq.Exponent;
		StrToNumResult_internal_ExpandedFloat_long_double_Constructor.Invoke(Agg_result, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq);
		Llvm_lifetime_start_p0.Invoke(16L, &int2);
		int2 = -7378697629483820647L;
		unchecked
		{
			while (true)
			{
				if (Internal_isdigit_u2vjuj.Invoke(((sbyte*)Src)[num3]))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = Internal_b36_char_to_int_kxqrdt.Invoke(((sbyte*)Src)[num3]);
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
					Llvm_lifetime_end_p0.Invoke(4L, &num4);
				}
				else
				{
					if (((sbyte*)Src)[num3] != b6 || (b4 & 1) == 1)
					{
						break;
					}
					b4 = 1;
					num3++;
				}
			}
			if ((b3 & 1) == 1)
			{
				if (Internal_tolower_b2645y.Invoke(((sbyte*)Src)[num3]) == 101)
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
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_StrToNumResult_imtnam);
						*(int*)(&llvm_libc_20_1_2_StrToNumResult_imtnam) = -1431655766;
						((int*)(&llvm_libc_20_1_2_StrToNumResult_imtnam))[1] = -1431655766;
						((long*)(&llvm_libc_20_1_2_StrToNumResult_imtnam))[1] = -6148914691236517206L;
						Struct_fiz2nb struct_fiz2nb = Internal_strtointeger_int.Invoke((byte*)Src + num3, 10, Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
						Llvm_libc_20_1_2_StrToNumResult_imtnam* num7 = &llvm_libc_20_1_2_StrToNumResult_imtnam;
						Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
						*(long*)num7 = struct_fiz2nb2.field_0;
						byte* num8 = (byte*)(&llvm_libc_20_1_2_StrToNumResult_imtnam) + 8u;
						Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
						*(long*)num8 = struct_fiz2nb3.field_1;
						if (StrToNumResult_int_has_error.Invoke(&llvm_libc_20_1_2_StrToNumResult_imtnam))
						{
							Agg_result->Error = llvm_libc_20_1_2_StrToNumResult_imtnam.Error;
						}
						Llvm_lifetime_start_p0.Invoke(4L, &num5);
						num5 = llvm_libc_20_1_2_StrToNumResult_imtnam.Value;
						long parsed_len = llvm_libc_20_1_2_StrToNumResult_imtnam.Parsed_len;
						num3 += parsed_len;
						Llvm_lifetime_start_p0.Invoke(8L, &num6);
						checked
						{
							num6 = unchecked((long)num2) + unchecked((long)num5);
						}
						num2 = (int)((num6 <= 32767L) ? ((num6 >= -32767L) ? num6 : (-32767)) : 32767);
						Llvm_lifetime_end_p0.Invoke(8L, &num6);
						Llvm_lifetime_end_p0.Invoke(4L, &num5);
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_StrToNumResult_imtnam);
					}
					Llvm_lifetime_end_p0.Invoke(1L, &b5);
				}
				Agg_result->Parsed_len = num3;
				if (NumericHelper.IntCmpEq(@int, 0L))
				{
					Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq2);
					Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_internal_ExpandedFloat_9jummq2, 0, 32L, isVolatile: false);
					_ = ref llvm_libc_20_1_2_internal_ExpandedFloat_9jummq2.Mantissa;
					_ = ref llvm_libc_20_1_2_internal_ExpandedFloat_9jummq2.Exponent;
					Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Value, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq2, 32L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq2);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(48L, &llvm_libc_20_1_2_internal_FloatConvertReturn_hgyipa);
					Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_internal_FloatConvertReturn_hgyipa, -86, 48L, isVolatile: false);
					llvm_libc_20_1_2_internal_ExpandedFloat_9jummq3.Mantissa = @int;
					llvm_libc_20_1_2_internal_ExpandedFloat_9jummq3.Exponent = num2;
					Internal_decimal_exp_to_float_long_double.Invoke(&llvm_libc_20_1_2_internal_FloatConvertReturn_hgyipa, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq3, (b2 & 1) == 1, Round, Src, Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
					Llvm_memcpy_p0_p0_i64.Invoke(source: &llvm_libc_20_1_2_internal_FloatConvertReturn_hgyipa.Num, destination: &Agg_result->Value, length: 32L, isVolatile: false);
					Agg_result->Error = llvm_libc_20_1_2_internal_FloatConvertReturn_hgyipa.Error;
					Llvm_lifetime_end_p0.Invoke(48L, &llvm_libc_20_1_2_internal_FloatConvertReturn_hgyipa);
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
