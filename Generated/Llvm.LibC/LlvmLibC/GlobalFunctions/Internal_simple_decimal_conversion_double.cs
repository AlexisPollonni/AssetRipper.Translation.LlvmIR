using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_simple_decimal_conversion_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal25simple_decimal_conversionIdEENS0_18FloatConvertReturnIT_EEPKcmNS0_14RoundDirectionE")]
	[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<double> __llvm_libc_20_1_2_::internal::simple_decimal_conversion<double>(char const*, unsigned long, __llvm_libc_20_1_2_::internal::RoundDirection)")]
	[return: NativeType("__llvm_libc_20_1_2_::internal::FloatConvertReturn<double>")]
	public unsafe static void Invoke([MangledName("agg.result")] Internal_FloatConvertReturn_g92bm8* Agg_result, [MangledName("numStart")][NativeType("char const*")] void* NumStart, [MangledName("num_len")][NativeType("unsigned long")] long Num_len, [MangledName("round")][NativeType("__llvm_libc_20_1_2_::internal::RoundDirection")] RoundDirection_b3pcwy Round)
	{
		int i = 0;
		Internal_HighPrecisionDecimal internal_HighPrecisionDecimal = default(Internal_HighPrecisionDecimal);
		Internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv = default(Internal_ExpandedFloat_k68bhv);
		Internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv2 = default(Internal_ExpandedFloat_k68bhv);
		Internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv3 = default(Internal_ExpandedFloat_k68bhv);
		int num = 0;
		int num2 = 0;
		Internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv4 = default(Internal_ExpandedFloat_k68bhv);
		long num3 = 0L;
		Internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv5 = default(Internal_ExpandedFloat_k68bhv);
		Llvm_lifetime_start_p0.Invoke(4L, &i);
		i = 0;
		Llvm_lifetime_start_p0.Invoke(812L, &internal_HighPrecisionDecimal);
		Llvm_memset_p0_i64.Invoke(&internal_HighPrecisionDecimal, -86, 812L, isVolatile: false);
		HighPrecisionDecimal_Constructor.Invoke(&internal_HighPrecisionDecimal, NumStart, Num_len);
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
			FloatConvertReturn_double_Constructor.Invoke(Agg_result);
		}
		if (HighPrecisionDecimal_get_num_digits.Invoke(&internal_HighPrecisionDecimal) == 0)
		{
			Llvm_lifetime_start_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv);
			internal_ExpandedFloat_k68bhv.Mantissa = 0L;
			internal_ExpandedFloat_k68bhv.Exponent = 0;
			Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Num, &internal_ExpandedFloat_k68bhv, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv);
		}
		else if (HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal) > 0 && Internal_exp10_to_exp2.Invoke(HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal) - 1) > 1023)
		{
			Llvm_lifetime_start_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv2);
			internal_ExpandedFloat_k68bhv2.Mantissa = 0L;
			internal_ExpandedFloat_k68bhv2.Exponent = 2047;
			Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Num, &internal_ExpandedFloat_k68bhv2, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv2);
			Agg_result->Error = 34;
		}
		else if (HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal) < 0 && Internal_exp10_to_exp2.Invoke(-HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal)) > 1075)
		{
			Llvm_lifetime_start_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv3);
			internal_ExpandedFloat_k68bhv3.Mantissa = 0L;
			internal_ExpandedFloat_k68bhv3.Exponent = 0;
			Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Num, &internal_ExpandedFloat_k68bhv3, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv3);
			Agg_result->Error = 34;
		}
		else
		{
			while (HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal) > 0)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = 0;
				if (HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal) >= 19)
				{
					num = 60;
				}
				else
				{
					long num4 = HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal);
					num = unchecked((byte)((sbyte*)Internal_POWERS_OF_TWO.Pointer)[num4]);
				}
				i += num;
				HighPrecisionDecimal_shift.Invoke(&internal_HighPrecisionDecimal, -num);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			while (HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal) < 0 || (HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal) == 0 && unchecked((byte)(*(sbyte*)HighPrecisionDecimal_get_digits.Invoke(&internal_HighPrecisionDecimal))) < 5))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = 0;
				if (-HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal) >= 19)
				{
					num2 = 60;
				}
				else if (HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal) != 0)
				{
					long num5 = -HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal);
					num2 = unchecked((byte)((sbyte*)Internal_POWERS_OF_TWO.Pointer)[num5]);
				}
				else
				{
					num2 = 1;
				}
				i -= num2;
				HighPrecisionDecimal_shift.Invoke(&internal_HighPrecisionDecimal, num2);
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			i += -1;
			HighPrecisionDecimal_shift.Invoke(&internal_HighPrecisionDecimal, 1);
			i += 1023;
			if (i >= 2047)
			{
				Llvm_lifetime_start_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv4);
				internal_ExpandedFloat_k68bhv4.Mantissa = 0L;
				internal_ExpandedFloat_k68bhv4.Exponent = 2047;
				Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Num, &internal_ExpandedFloat_k68bhv4, 16L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv4);
				Agg_result->Error = 34;
			}
			else
			{
				HighPrecisionDecimal_shift.Invoke(&internal_HighPrecisionDecimal, 52);
				Llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = HighPrecisionDecimal_round_to_integer_type_unsigned_long.Invoke(&internal_HighPrecisionDecimal, RoundDirection_b3pcwy.Nearest);
				if (i <= 0)
				{
					for (; i < 0; i++)
					{
						HighPrecisionDecimal_shift.Invoke(&internal_HighPrecisionDecimal, -1);
					}
					HighPrecisionDecimal_shift.Invoke(&internal_HighPrecisionDecimal, -1);
					num3 = HighPrecisionDecimal_round_to_integer_type_unsigned_long.Invoke(&internal_HighPrecisionDecimal, Round);
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
						Agg_result->Error = 34;
					}
				}
				if (i == 0)
				{
					Agg_result->Error = 34;
				}
				Llvm_lifetime_start_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv5);
				internal_ExpandedFloat_k68bhv5.Mantissa = num3;
				internal_ExpandedFloat_k68bhv5.Exponent = i;
				Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Num, &internal_ExpandedFloat_k68bhv5, 16L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv5);
				Llvm_lifetime_end_p0.Invoke(8L, &num3);
			}
		}
		Llvm_lifetime_end_p0.Invoke(812L, &internal_HighPrecisionDecimal);
		Llvm_lifetime_end_p0.Invoke(4L, &i);
	}
}
