using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal25simple_decimal_conversionIfEENS0_18FloatConvertReturnIT_EEPKcmNS0_14RoundDirectionE")]
[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<float> __llvm_libc_20_1_2_::internal::simple_decimal_conversion<float>(char const*, unsigned long, __llvm_libc_20_1_2_::internal::RoundDirection)")]
internal static partial class internal_FloatConvertReturn_float_internal_simple_decimal_conversion_float_char_const_unsigned_long_internal_RoundDirection
{
	public unsafe static Struct_3driym Invoke(void* numStart, long num_len, int round)
	{
		internal_FloatConvertReturn_a8f9er internal_FloatConvertReturn_a8f9er2 = default(internal_FloatConvertReturn_a8f9er);
		int i = 0;
		internal_HighPrecisionDecimal internal_HighPrecisionDecimal2 = default(internal_HighPrecisionDecimal);
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up2 = default(internal_ExpandedFloat_i7t5up);
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up3 = default(internal_ExpandedFloat_i7t5up);
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up4 = default(internal_ExpandedFloat_i7t5up);
		int num = 0;
		int num2 = 0;
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up5 = default(internal_ExpandedFloat_i7t5up);
		int num3 = 0;
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up6 = default(internal_ExpandedFloat_i7t5up);
		Struct_3driym result = default(Struct_3driym);
		llvm_lifetime_start_p0.Invoke(4L, &i);
		i = 0;
		llvm_lifetime_start_p0.Invoke(812L, &internal_HighPrecisionDecimal2);
		llvm_memset_p0_i64.Invoke(&internal_HighPrecisionDecimal2, -86, 812L, isVolatile: false);
		internal_HighPrecisionDecimal_HighPrecisionDecimal_char_const_unsigned_long.Invoke(&internal_HighPrecisionDecimal2, numStart, num_len);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&internal_FloatConvertReturn_a8f9er2);
			*(int*)ptr = -1431655766;
			((int*)ptr)[1] = -1431655766;
			((int*)(&internal_FloatConvertReturn_a8f9er2))[2] = -1431655766;
			internal_FloatConvertReturn_float_FloatConvertReturn.Invoke(&internal_FloatConvertReturn_a8f9er2);
		}
		if (internal_HighPrecisionDecimal_get_num_digits.Invoke(&internal_HighPrecisionDecimal2) == 0)
		{
			llvm_lifetime_start_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up2);
			internal_ExpandedFloat_i7t5up2.mantissa = 0;
			internal_ExpandedFloat_i7t5up2.exponent = 0;
			llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er2.num, &internal_ExpandedFloat_i7t5up2, 8L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up2);
		}
		else if (internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) > 0 && internal_exp10_to_exp2_int.Invoke(internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) - 1) > 127)
		{
			llvm_lifetime_start_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up3);
			internal_ExpandedFloat_i7t5up3.mantissa = 0;
			internal_ExpandedFloat_i7t5up3.exponent = 255;
			llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er2.num, &internal_ExpandedFloat_i7t5up3, 8L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up3);
			internal_FloatConvertReturn_a8f9er2.error = 34;
		}
		else if (internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) < 0 && internal_exp10_to_exp2_int.Invoke(-internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2)) > 150)
		{
			llvm_lifetime_start_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up4);
			internal_ExpandedFloat_i7t5up4.mantissa = 0;
			internal_ExpandedFloat_i7t5up4.exponent = 0;
			llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er2.num, &internal_ExpandedFloat_i7t5up4, 8L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up4);
			internal_FloatConvertReturn_a8f9er2.error = 34;
		}
		else
		{
			while (internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) > 0)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = 0;
				if (internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) >= 19)
				{
					num = 60;
				}
				else
				{
					long num4 = internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2);
					num = unchecked((byte)((sbyte*)internal_POWERS_OF_TWO.Pointer)[num4]);
				}
				i += num;
				internal_HighPrecisionDecimal_shift_int.Invoke(&internal_HighPrecisionDecimal2, -num);
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			while (true)
			{
				int num5;
				if (internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) < 0)
				{
					num5 = -1;
				}
				else
				{
					if (internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) != 0)
					{
						break;
					}
					num5 = ((unchecked((byte)(*(sbyte*)internal_HighPrecisionDecimal_get_digits.Invoke(&internal_HighPrecisionDecimal2))) < 5) ? 1 : 0);
				}
				if (num5 == 0)
				{
					break;
				}
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = 0;
				if (-internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) >= 19)
				{
					num2 = 60;
				}
				else if (internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2) != 0)
				{
					long num6 = -internal_HighPrecisionDecimal_get_decimal_point.Invoke(&internal_HighPrecisionDecimal2);
					num2 = unchecked((byte)((sbyte*)internal_POWERS_OF_TWO.Pointer)[num6]);
				}
				else
				{
					num2 = 1;
				}
				i -= num2;
				internal_HighPrecisionDecimal_shift_int.Invoke(&internal_HighPrecisionDecimal2, num2);
				llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			i += -1;
			internal_HighPrecisionDecimal_shift_int.Invoke(&internal_HighPrecisionDecimal2, 1);
			i += 127;
			if (i >= 255)
			{
				llvm_lifetime_start_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up5);
				internal_ExpandedFloat_i7t5up5.mantissa = 0;
				internal_ExpandedFloat_i7t5up5.exponent = 255;
				llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er2.num, &internal_ExpandedFloat_i7t5up5, 8L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up5);
				internal_FloatConvertReturn_a8f9er2.error = 34;
			}
			else
			{
				internal_HighPrecisionDecimal_shift_int.Invoke(&internal_HighPrecisionDecimal2, 23);
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = unsigned_int_internal_HighPrecisionDecimal_round_to_integer_type_unsigned_int_internal_RoundDirection.Invoke(&internal_HighPrecisionDecimal2, 2);
				if (i <= 0)
				{
					for (; i < 0; i++)
					{
						internal_HighPrecisionDecimal_shift_int.Invoke(&internal_HighPrecisionDecimal2, -1);
					}
					internal_HighPrecisionDecimal_shift_int.Invoke(&internal_HighPrecisionDecimal2, -1);
					num3 = unsigned_int_internal_HighPrecisionDecimal_round_to_integer_type_unsigned_int_internal_RoundDirection.Invoke(&internal_HighPrecisionDecimal2, round);
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
						internal_FloatConvertReturn_a8f9er2.error = 34;
					}
				}
				if (i == 0)
				{
					internal_FloatConvertReturn_a8f9er2.error = 34;
				}
				llvm_lifetime_start_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up6);
				internal_ExpandedFloat_i7t5up6.mantissa = num3;
				internal_ExpandedFloat_i7t5up6.exponent = i;
				llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er2.num, &internal_ExpandedFloat_i7t5up6, 8L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up6);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
			}
		}
		llvm_lifetime_end_p0.Invoke(812L, &internal_HighPrecisionDecimal2);
		llvm_lifetime_end_p0.Invoke(4L, &i);
		llvm_memcpy_p0_p0_i64.Invoke(&result, &internal_FloatConvertReturn_a8f9er2, 12L, isVolatile: false);
		return result;
	}
}
