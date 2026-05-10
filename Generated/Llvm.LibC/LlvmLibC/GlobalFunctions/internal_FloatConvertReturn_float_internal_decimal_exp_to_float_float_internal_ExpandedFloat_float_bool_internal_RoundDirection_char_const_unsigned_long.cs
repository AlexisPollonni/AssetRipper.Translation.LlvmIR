using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal20decimal_exp_to_floatIfEENS0_18FloatConvertReturnIT_EENS0_13ExpandedFloatIS3_EEbNS0_14RoundDirectionEPKcm")]
[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<float> __llvm_libc_20_1_2_::internal::decimal_exp_to_float<float>(__llvm_libc_20_1_2_::internal::ExpandedFloat<float>, bool, __llvm_libc_20_1_2_::internal::RoundDirection, char const*, unsigned long)")]
internal static partial class internal_FloatConvertReturn_float_internal_decimal_exp_to_float_float_internal_ExpandedFloat_float_bool_internal_RoundDirection_char_const_unsigned_long
{
	public unsafe static Struct_3driym Invoke([MangledName("init_num.coerce")] long init_num, bool truncated, int round, void* numStart, long num_len)
	{
		internal_FloatConvertReturn_a8f9er internal_FloatConvertReturn_a8f9er2 = default(internal_FloatConvertReturn_a8f9er);
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up2 = default(internal_ExpandedFloat_i7t5up);
		int num = 0;
		int num2 = 0;
		internal_FloatConvertReturn_a8f9er internal_FloatConvertReturn_a8f9er3 = default(internal_FloatConvertReturn_a8f9er);
		cpp_optional_6hseum cpp_optional_6hseum2 = default(cpp_optional_6hseum);
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up3 = default(internal_ExpandedFloat_i7t5up);
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up4 = default(internal_ExpandedFloat_i7t5up);
		cpp_optional_6hseum cpp_optional_6hseum3 = default(cpp_optional_6hseum);
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up5 = default(internal_ExpandedFloat_i7t5up);
		Struct_8myw6y struct_8myw6y = default(Struct_8myw6y);
		cpp_optional_6hseum cpp_optional_6hseum4 = default(cpp_optional_6hseum);
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up6 = default(internal_ExpandedFloat_i7t5up);
		Struct_8myw6y struct_8myw6y2 = default(Struct_8myw6y);
		cpp_optional_6hseum cpp_optional_6hseum5 = default(cpp_optional_6hseum);
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up7 = default(internal_ExpandedFloat_i7t5up);
		Struct_8myw6y struct_8myw6y3 = default(Struct_8myw6y);
		internal_FloatConvertReturn_a8f9er internal_FloatConvertReturn_a8f9er4 = default(internal_FloatConvertReturn_a8f9er);
		Struct_3driym struct_3driym = default(Struct_3driym);
		Struct_3driym result = default(Struct_3driym);
		unchecked
		{
			*(long*)(&internal_ExpandedFloat_i7t5up2) = init_num;
			sbyte b = (truncated ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = internal_ExpandedFloat_i7t5up2.mantissa;
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = internal_ExpandedFloat_i7t5up2.exponent;
			llvm_lifetime_start_p0.Invoke(12L, &internal_FloatConvertReturn_a8f9er3);
			sbyte* ptr = (sbyte*)(&internal_FloatConvertReturn_a8f9er3);
			*(int*)ptr = -1431655766;
			((int*)ptr)[1] = -1431655766;
			((int*)(&internal_FloatConvertReturn_a8f9er3))[2] = -1431655766;
			internal_FloatConvertReturn_float_FloatConvertReturn.Invoke(&internal_FloatConvertReturn_a8f9er3);
			llvm_lifetime_start_p0.Invoke(12L, &cpp_optional_6hseum2);
			sbyte* ptr2 = (sbyte*)(&cpp_optional_6hseum2);
			sbyte* ptr3 = ptr2;
			*(int*)ptr3 = -1431655766;
			((int*)ptr3)[1] = -1431655766;
			ptr2[8] = -86;
			sbyte* ptr4 = ptr2 + 9;
			*ptr4 = -86;
			ptr4[1] = -86;
			ptr4[2] = -86;
			cpp_optional_internal_ExpandedFloat_float_optional.Invoke(&cpp_optional_6hseum2);
			if (num2 > int_internal_get_upper_bound_float.Invoke())
			{
				llvm_lifetime_start_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up3);
				internal_ExpandedFloat_i7t5up3.mantissa = 0;
				internal_ExpandedFloat_i7t5up3.exponent = 255;
				llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er3.num, &internal_ExpandedFloat_i7t5up3, 8L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up3);
				internal_FloatConvertReturn_a8f9er3.error = 34;
				llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er2, &internal_FloatConvertReturn_a8f9er3, 12L, isVolatile: false);
			}
			else if (num2 < int_internal_get_lower_bound_float.Invoke())
			{
				llvm_lifetime_start_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up4);
				internal_ExpandedFloat_i7t5up4.mantissa = 0;
				internal_ExpandedFloat_i7t5up4.exponent = 0;
				llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er3.num, &internal_ExpandedFloat_i7t5up4, 8L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up4);
				internal_FloatConvertReturn_a8f9er3.error = 34;
				llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er2, &internal_FloatConvertReturn_a8f9er3, 12L, isVolatile: false);
			}
			else
			{
				if ((b & 1) != 1)
				{
					llvm_lifetime_start_p0.Invoke(12L, &cpp_optional_6hseum3);
					llvm_memcpy_p0_p0_i64.Invoke(&internal_ExpandedFloat_i7t5up5, &internal_ExpandedFloat_i7t5up2, 8L, isVolatile: false);
					Struct_8myw6y struct_8myw6y4 = cpp_optional_internal_ExpandedFloat_float_internal_clinger_fast_path_float_internal_ExpandedFloat_float_internal_RoundDirection.Invoke(*(long*)(&internal_ExpandedFloat_i7t5up5), round);
					cpp_optional_internal_ExpandedFloat_float_OptionalStorage* destination = &cpp_optional_6hseum3.storage;
					struct_8myw6y = struct_8myw6y4;
					llvm_memcpy_p0_p0_i64.Invoke(destination, &struct_8myw6y, 12L, isVolatile: false);
					llvm_memcpy_p0_p0_i64.Invoke(&cpp_optional_6hseum2, &cpp_optional_6hseum3, 12L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(12L, &cpp_optional_6hseum3);
					if (cpp_optional_internal_ExpandedFloat_float_has_value_const.Invoke(&cpp_optional_6hseum2))
					{
						llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er2.num, cpp_optional_internal_ExpandedFloat_float_value.Invoke(&cpp_optional_6hseum2), 8L, isVolatile: false);
						internal_FloatConvertReturn_a8f9er2.error = 0;
						goto IL_0564;
					}
				}
				llvm_lifetime_start_p0.Invoke(12L, &cpp_optional_6hseum4);
				llvm_memcpy_p0_p0_i64.Invoke(&internal_ExpandedFloat_i7t5up6, &internal_ExpandedFloat_i7t5up2, 8L, isVolatile: false);
				Struct_8myw6y struct_8myw6y5 = cpp_optional_internal_ExpandedFloat_float_internal_eisel_lemire_float_internal_ExpandedFloat_float_internal_RoundDirection.Invoke(*(long*)(&internal_ExpandedFloat_i7t5up6), round);
				cpp_optional_internal_ExpandedFloat_float_OptionalStorage* destination2 = &cpp_optional_6hseum4.storage;
				struct_8myw6y2 = struct_8myw6y5;
				llvm_memcpy_p0_p0_i64.Invoke(destination2, &struct_8myw6y2, 12L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_optional_6hseum2, &cpp_optional_6hseum4, 12L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(12L, &cpp_optional_6hseum4);
				if (cpp_optional_internal_ExpandedFloat_float_has_value_const.Invoke(&cpp_optional_6hseum2))
				{
					if ((b & 1) != 1)
					{
						llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er2.num, cpp_optional_internal_ExpandedFloat_float_value.Invoke(&cpp_optional_6hseum2), 8L, isVolatile: false);
						internal_FloatConvertReturn_a8f9er2.error = 0;
						goto IL_0564;
					}
					llvm_lifetime_start_p0.Invoke(12L, &cpp_optional_6hseum5);
					sbyte* ptr5 = (sbyte*)(&cpp_optional_6hseum5);
					sbyte* ptr6 = ptr5;
					*(int*)ptr6 = -1431655766;
					((int*)ptr6)[1] = -1431655766;
					ptr5[8] = -86;
					sbyte* ptr7 = ptr5 + 9;
					*ptr7 = -86;
					ptr7[1] = -86;
					ptr7[2] = -86;
					internal_ExpandedFloat_i7t5up7.mantissa = num + 1;
					internal_ExpandedFloat_i7t5up7.exponent = num2;
					Struct_8myw6y struct_8myw6y6 = cpp_optional_internal_ExpandedFloat_float_internal_eisel_lemire_float_internal_ExpandedFloat_float_internal_RoundDirection.Invoke(*(long*)(&internal_ExpandedFloat_i7t5up7), round);
					cpp_optional_internal_ExpandedFloat_float_OptionalStorage* destination3 = &cpp_optional_6hseum5.storage;
					struct_8myw6y3 = struct_8myw6y6;
					llvm_memcpy_p0_p0_i64.Invoke(destination3, &struct_8myw6y3, 12L, isVolatile: false);
					int num3;
					if (cpp_optional_internal_ExpandedFloat_float_has_value_const.Invoke(&cpp_optional_6hseum5) && ((internal_ExpandedFloat_i7t5up*)cpp_optional_internal_ExpandedFloat_float_operator.Invoke(&cpp_optional_6hseum2))->mantissa == ((internal_ExpandedFloat_i7t5up*)cpp_optional_internal_ExpandedFloat_float_operator.Invoke(&cpp_optional_6hseum5))->mantissa && ((internal_ExpandedFloat_i7t5up*)cpp_optional_internal_ExpandedFloat_float_operator.Invoke(&cpp_optional_6hseum2))->exponent == ((internal_ExpandedFloat_i7t5up*)cpp_optional_internal_ExpandedFloat_float_operator.Invoke(&cpp_optional_6hseum5))->exponent)
					{
						llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er2.num, cpp_optional_internal_ExpandedFloat_float_value.Invoke(&cpp_optional_6hseum2), 8L, isVolatile: false);
						internal_FloatConvertReturn_a8f9er2.error = 0;
						num3 = 1;
					}
					else
					{
						num3 = 0;
					}
					llvm_lifetime_end_p0.Invoke(12L, &cpp_optional_6hseum5);
					switch (num3)
					{
					case 0:
						break;
					default:
						goto IL_0564;
					}
				}
				llvm_lifetime_start_p0.Invoke(12L, &internal_FloatConvertReturn_a8f9er4);
				struct_3driym = internal_FloatConvertReturn_float_internal_simple_decimal_conversion_float_char_const_unsigned_long_internal_RoundDirection.Invoke(numStart, num_len, round);
				llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er4, &struct_3driym, 12L, isVolatile: false);
				llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er3, &internal_FloatConvertReturn_a8f9er4, 12L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(12L, &internal_FloatConvertReturn_a8f9er4);
				llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_a8f9er2, &internal_FloatConvertReturn_a8f9er3, 12L, isVolatile: false);
			}
			goto IL_0564;
		}
		IL_0564:
		llvm_lifetime_end_p0.Invoke(12L, &cpp_optional_6hseum2);
		llvm_lifetime_end_p0.Invoke(12L, &internal_FloatConvertReturn_a8f9er3);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_memcpy_p0_p0_i64.Invoke(&result, &internal_FloatConvertReturn_a8f9er2, 12L, isVolatile: false);
		return result;
	}
}
