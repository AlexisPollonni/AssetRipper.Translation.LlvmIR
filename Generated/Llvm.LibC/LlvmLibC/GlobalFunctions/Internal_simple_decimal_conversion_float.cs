using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_simple_decimal_conversion_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal25simple_decimal_conversionIfEENS0_18FloatConvertReturnIT_EEPKcmNS0_14RoundDirectionE")]
	[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<float> __llvm_libc_20_1_2_::internal::simple_decimal_conversion<float>(char const*, unsigned long, __llvm_libc_20_1_2_::internal::RoundDirection)")]
	[return: NativeType("__llvm_libc_20_1_2_::internal::FloatConvertReturn<float>")]
	public unsafe static Struct_3driym Invoke([MangledName("numStart")][NativeType("char const*")] void* NumStart, [MangledName("num_len")][NativeType("unsigned long")] long Num_len, [MangledName("round")][NativeType("__llvm_libc_20_1_2_::internal::RoundDirection")] RoundDirection_b3pcwy Round)
	{
		Llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er = default(Llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er);
		int i = 0;
		Llvm_libc_20_1_2_internal_HighPrecisionDecimal llvm_libc_20_1_2_internal_HighPrecisionDecimal = default(Llvm_libc_20_1_2_internal_HighPrecisionDecimal);
		Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up = default(Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up);
		Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up);
		Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up3 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up);
		int num = 0;
		int num2 = 0;
		Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up4 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up);
		int num3 = 0;
		Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up5 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up);
		Struct_3driym result = default(Struct_3driym);
		Llvm_lifetime_start_p0.Invoke(4L, &i);
		i = 0;
		Llvm_lifetime_start_p0.Invoke(812L, &llvm_libc_20_1_2_internal_HighPrecisionDecimal);
		Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal, -86, 812L, isVolatile: false);
		HighPrecisionDecimal_Constructor.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal, NumStart, Num_len);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er);
			*(int*)ptr = -1431655766;
			((int*)ptr)[1] = -1431655766;
			((int*)(&llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er))[2] = -1431655766;
			FloatConvertReturn_float_Constructor.Invoke(&llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er);
		}
		if (HighPrecisionDecimal_get_num_digits.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal) == 0)
		{
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up);
			llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up.Mantissa = 0;
			llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up.Exponent = 0;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er.Num, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up, 8L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up);
		}
		else if (HighPrecisionDecimal_get_decimal_point.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal) > 0 && Internal_exp10_to_exp2.Invoke(HighPrecisionDecimal_get_decimal_point.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal) - 1) > 127)
		{
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2);
			llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2.Mantissa = 0;
			llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2.Exponent = 255;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er.Num, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2, 8L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2);
			llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er.Error = 34;
		}
		else if (HighPrecisionDecimal_get_decimal_point.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal) < 0 && Internal_exp10_to_exp2.Invoke(-HighPrecisionDecimal_get_decimal_point.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal)) > 150)
		{
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up3);
			llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up3.Mantissa = 0;
			llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up3.Exponent = 0;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er.Num, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up3, 8L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up3);
			llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er.Error = 34;
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
					long num4 = HighPrecisionDecimal_get_decimal_point.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal);
					num = unchecked((byte)((sbyte*)Llvm_libc_20_1_2_internal_POWERS_OF_TWO.Pointer)[num4]);
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
					long num5 = -HighPrecisionDecimal_get_decimal_point.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal);
					num2 = unchecked((byte)((sbyte*)Llvm_libc_20_1_2_internal_POWERS_OF_TWO.Pointer)[num5]);
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
			i += 127;
			if (i >= 255)
			{
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up4);
				llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up4.Mantissa = 0;
				llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up4.Exponent = 255;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er.Num, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up4, 8L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up4);
				llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er.Error = 34;
			}
			else
			{
				HighPrecisionDecimal_shift.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal, 23);
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = HighPrecisionDecimal_round_to_integer_type_unsigned_int.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal, RoundDirection_b3pcwy.Nearest);
				if (i <= 0)
				{
					for (; i < 0; i++)
					{
						HighPrecisionDecimal_shift.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal, -1);
					}
					HighPrecisionDecimal_shift.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal, -1);
					num3 = HighPrecisionDecimal_round_to_integer_type_unsigned_int.Invoke(&llvm_libc_20_1_2_internal_HighPrecisionDecimal, Round);
					if (unchecked((uint)num3) >> 23 != 0)
					{
						i++;
					}
				}
				if (num3 == 16777216)
				{
					num3 >>>= 1;
					i++;
					if (i >= 255)
					{
						llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er.Error = 34;
					}
				}
				if (i == 0)
				{
					llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er.Error = 34;
				}
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up5);
				llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up5.Mantissa = num3;
				llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up5.Exponent = i;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er.Num, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up5, 8L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up5);
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
			}
		}
		Llvm_lifetime_end_p0.Invoke(812L, &llvm_libc_20_1_2_internal_HighPrecisionDecimal);
		Llvm_lifetime_end_p0.Invoke(4L, &i);
		Llvm_memcpy_p0_p0_i64.Invoke(&result, &llvm_libc_20_1_2_internal_FloatConvertReturn_a8f9er, 12L, isVolatile: false);
		return result;
	}
}
