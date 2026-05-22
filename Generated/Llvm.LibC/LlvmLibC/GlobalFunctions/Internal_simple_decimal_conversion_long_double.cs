using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_simple_decimal_conversion_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal25simple_decimal_conversionIeEENS0_18FloatConvertReturnIT_EEPKcmNS0_14RoundDirectionE")]
	[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<long double> __llvm_libc_20_1_2_::internal::simple_decimal_conversion<long double>(char const*, unsigned long, __llvm_libc_20_1_2_::internal::RoundDirection)")]
	[return: NativeType("__llvm_libc_20_1_2_::internal::FloatConvertReturn<long double>")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_internal_FloatConvertReturn_hgyipa* Agg_result, [MangledName("numStart")][NativeType("char const*")] void* NumStart, [MangledName("num_len")][NativeType("unsigned long")] long Num_len, [MangledName("round")][NativeType("__llvm_libc_20_1_2_::internal::RoundDirection")] RoundDirection_b3pcwy Round)
	{
		int i = 0;
		Llvm_libc_20_1_2_internal_HighPrecisionDecimal llvm_libc_20_1_2_internal_HighPrecisionDecimal = default(Llvm_libc_20_1_2_internal_HighPrecisionDecimal);
		Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq llvm_libc_20_1_2_internal_ExpandedFloat_9jummq = default(Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq);
		Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq llvm_libc_20_1_2_internal_ExpandedFloat_9jummq2 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq);
		Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq llvm_libc_20_1_2_internal_ExpandedFloat_9jummq3 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq);
		int num = 0;
		int num2 = 0;
		Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq llvm_libc_20_1_2_internal_ExpandedFloat_9jummq4 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq llvm_libc_20_1_2_internal_ExpandedFloat_9jummq5 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq);
		Llvm_lifetime_start_p0.Invoke(4L, &i);
		i = 0;
		Llvm_lifetime_start_p0.Invoke(812L, &llvm_libc_20_1_2_internal_HighPrecisionDecimal);
		Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal, -86, 812L, isVolatile: false);
		HighPrecisionDecimal_Constructor.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal, NumStart, Num_len);
		Llvm_memset_p0_i64.Invoke(Agg_result, -86, 48L, isVolatile: false);
		FloatConvertReturn_long_double_Constructor.Invoke(Agg_result);
		if (HighPrecisionDecimal_get_num_digits.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal) == 0)
		{
			Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq);
			Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_internal_ExpandedFloat_9jummq, 0, 32L, isVolatile: false);
			_ = ref llvm_libc_20_1_2_internal_ExpandedFloat_9jummq.Mantissa;
			_ = ref llvm_libc_20_1_2_internal_ExpandedFloat_9jummq.Exponent;
			Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Num, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq, 32L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq);
		}
		else if (HighPrecisionDecimal_get_decimal_point.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal) > 0 && Internal_exp10_to_exp2.Invoke(HighPrecisionDecimal_get_decimal_point.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal) - 1) > 16383)
		{
			Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq2);
			Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_internal_ExpandedFloat_9jummq2, 0, 32L, isVolatile: false);
			_ = ref llvm_libc_20_1_2_internal_ExpandedFloat_9jummq2.Mantissa;
			llvm_libc_20_1_2_internal_ExpandedFloat_9jummq2.Exponent = 32767;
			Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Num, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq2, 32L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq2);
			Agg_result->Error = 34;
		}
		else if (HighPrecisionDecimal_get_decimal_point.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal) < 0 && Internal_exp10_to_exp2.Invoke(-HighPrecisionDecimal_get_decimal_point.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal)) > 16446)
		{
			Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq3);
			Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_internal_ExpandedFloat_9jummq3, 0, 32L, isVolatile: false);
			_ = ref llvm_libc_20_1_2_internal_ExpandedFloat_9jummq3.Mantissa;
			_ = ref llvm_libc_20_1_2_internal_ExpandedFloat_9jummq3.Exponent;
			Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Num, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq3, 32L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq3);
			Agg_result->Error = 34;
		}
		else
		{
			while (HighPrecisionDecimal_get_decimal_point.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal) > 0)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = 0;
				if (HighPrecisionDecimal_get_decimal_point.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal) >= 19)
				{
					num = 60;
				}
				else
				{
					long num3 = HighPrecisionDecimal_get_decimal_point.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal);
					num = unchecked((byte)((sbyte*)Llvm_libc_20_1_2_internal_POWERS_OF_TWO.Pointer)[num3]);
				}
				i += num;
				HighPrecisionDecimal_shift.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal, -num);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			while (HighPrecisionDecimal_get_decimal_point.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal) < 0 || (HighPrecisionDecimal_get_decimal_point.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal) == 0 && unchecked((byte)(*(sbyte*)HighPrecisionDecimal_get_digits.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal))) < 5))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = 0;
				if (-HighPrecisionDecimal_get_decimal_point.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal) >= 19)
				{
					num2 = 60;
				}
				else if (HighPrecisionDecimal_get_decimal_point.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal) != 0)
				{
					long num4 = -HighPrecisionDecimal_get_decimal_point.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal);
					num2 = unchecked((byte)((sbyte*)Llvm_libc_20_1_2_internal_POWERS_OF_TWO.Pointer)[num4]);
				}
				else
				{
					num2 = 1;
				}
				i -= num2;
				HighPrecisionDecimal_shift.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal, num2);
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			i += -1;
			HighPrecisionDecimal_shift.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal, 1);
			i += 16383;
			if (i >= 32767)
			{
				Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq4);
				Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_internal_ExpandedFloat_9jummq4, 0, 32L, isVolatile: false);
				_ = ref llvm_libc_20_1_2_internal_ExpandedFloat_9jummq4.Mantissa;
				llvm_libc_20_1_2_internal_ExpandedFloat_9jummq4.Exponent = 32767;
				Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Num, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq4, 32L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq4);
				Agg_result->Error = 34;
			}
			else
			{
				HighPrecisionDecimal_shift.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal, 63);
				Llvm_lifetime_start_p0.Invoke(16L, &@int);
				Struct_fiz2nb struct_fiz2nb = HighPrecisionDecimal_round_to_integer_type_unsigned_int128.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal, RoundDirection_b3pcwy.Nearest);
				Int128* num5 = &int2;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				unchecked
				{
					*(long*)num5 = struct_fiz2nb2.field_0;
					byte* num6 = (byte*)(&int2) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num6 = struct_fiz2nb3.field_1;
					@int = int2;
				}
				if (i <= 0)
				{
					for (; i < 0; i++)
					{
						HighPrecisionDecimal_shift.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal, -1);
					}
					HighPrecisionDecimal_shift.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal, -1);
					Struct_fiz2nb struct_fiz2nb4 = HighPrecisionDecimal_round_to_integer_type_unsigned_int128.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal, Round);
					Int128* num7 = &int3;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					unchecked
					{
						*(long*)num7 = struct_fiz2nb5.field_0;
						byte* num8 = (byte*)(&int3) + 8u;
						Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
						*(long*)num8 = struct_fiz2nb6.field_1;
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
						Agg_result->Error = 34;
					}
				}
				if (i == 0)
				{
					Agg_result->Error = 34;
				}
				Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq5);
				llvm_libc_20_1_2_internal_ExpandedFloat_9jummq5.Mantissa = @int;
				llvm_libc_20_1_2_internal_ExpandedFloat_9jummq5.Exponent = i;
				Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Num, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq5, 32L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq5);
				Llvm_lifetime_end_p0.Invoke(16L, &@int);
			}
		}
		Llvm_lifetime_end_p0.Invoke(812L, &llvm_libc_20_1_2_internal_HighPrecisionDecimal);
		Llvm_lifetime_end_p0.Invoke(4L, &i);
	}
}
