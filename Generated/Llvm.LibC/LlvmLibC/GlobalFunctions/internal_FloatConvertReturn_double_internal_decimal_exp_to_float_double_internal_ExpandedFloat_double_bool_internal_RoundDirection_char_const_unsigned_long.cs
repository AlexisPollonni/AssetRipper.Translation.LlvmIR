using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal20decimal_exp_to_floatIdEENS0_18FloatConvertReturnIT_EENS0_13ExpandedFloatIS3_EEbNS0_14RoundDirectionEPKcm")]
[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<double> __llvm_libc_20_1_2_::internal::decimal_exp_to_float<double>(__llvm_libc_20_1_2_::internal::ExpandedFloat<double>, bool, __llvm_libc_20_1_2_::internal::RoundDirection, char const*, unsigned long)")]
internal static partial class internal_FloatConvertReturn_double_internal_decimal_exp_to_float_double_internal_ExpandedFloat_double_bool_internal_RoundDirection_char_const_unsigned_long
{
	public unsafe static void Invoke([MangledName("agg.result")] internal_FloatConvertReturn_g92bm8* agg_result, [MangledName("init_num.coerce0")] long init_num, [MangledName("init_num.coerce1")] int truncated, [MangledName("truncated")] bool round, [MangledName("round")] int numStart, [MangledName("numStart")] void* num_len, [MangledName("num_len")] long mantissa)
	{
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv2 = default(internal_ExpandedFloat_k68bhv);
		long num = 0L;
		int num2 = 0;
		internal_FloatConvertReturn_g92bm8 internal_FloatConvertReturn_g92bm9 = default(internal_FloatConvertReturn_g92bm8);
		cpp_optional_vqqfu4 cpp_optional_vqqfu5 = default(cpp_optional_vqqfu4);
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv3 = default(internal_ExpandedFloat_k68bhv);
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv4 = default(internal_ExpandedFloat_k68bhv);
		cpp_optional_vqqfu4 cpp_optional_vqqfu6 = default(cpp_optional_vqqfu4);
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv5 = default(internal_ExpandedFloat_k68bhv);
		cpp_optional_vqqfu4 cpp_optional_vqqfu7 = default(cpp_optional_vqqfu4);
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv6 = default(internal_ExpandedFloat_k68bhv);
		cpp_optional_vqqfu4 cpp_optional_vqqfu8 = default(cpp_optional_vqqfu4);
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv7 = default(internal_ExpandedFloat_k68bhv);
		internal_FloatConvertReturn_g92bm8 internal_FloatConvertReturn_g92bm10 = default(internal_FloatConvertReturn_g92bm8);
		unchecked
		{
			*(long*)(&internal_ExpandedFloat_k68bhv2) = init_num;
			((int*)(&internal_ExpandedFloat_k68bhv2))[2] = truncated;
			sbyte b = (round ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = internal_ExpandedFloat_k68bhv2.mantissa;
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = internal_ExpandedFloat_k68bhv2.exponent;
			llvm_lifetime_start_p0.Invoke(24L, &internal_FloatConvertReturn_g92bm9);
			sbyte* ptr = (sbyte*)(&internal_FloatConvertReturn_g92bm9);
			*(long*)ptr = -6148914691236517206L;
			((int*)ptr)[2] = -1431655766;
			sbyte* ptr2 = ptr + 12;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			ptr2[3] = -86;
			((int*)(&internal_FloatConvertReturn_g92bm9))[4] = -1431655766;
			sbyte* ptr3 = (sbyte*)(&internal_FloatConvertReturn_g92bm9) + 20;
			*ptr3 = -86;
			ptr3[1] = -86;
			ptr3[2] = -86;
			ptr3[3] = -86;
			internal_FloatConvertReturn_double_FloatConvertReturn.Invoke(&internal_FloatConvertReturn_g92bm9);
			llvm_lifetime_start_p0.Invoke(24L, &cpp_optional_vqqfu5);
			sbyte* ptr4 = (sbyte*)(&cpp_optional_vqqfu5);
			sbyte* ptr5 = ptr4;
			*(long*)ptr5 = -6148914691236517206L;
			((int*)ptr5)[2] = -1431655766;
			sbyte* ptr6 = ptr5 + 12;
			*ptr6 = -86;
			ptr6[1] = -86;
			ptr6[2] = -86;
			ptr6[3] = -86;
			ptr4[16] = -86;
			sbyte* ptr7 = ptr4 + 17;
			*ptr7 = -86;
			ptr7[1] = -86;
			ptr7[2] = -86;
			ptr7[3] = -86;
			ptr7[4] = -86;
			ptr7[5] = -86;
			ptr7[6] = -86;
			cpp_optional_internal_ExpandedFloat_double_optional.Invoke(&cpp_optional_vqqfu5);
			if (num2 > int_internal_get_upper_bound_double.Invoke())
			{
				llvm_lifetime_start_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv3);
				internal_ExpandedFloat_k68bhv3.mantissa = 0L;
				internal_ExpandedFloat_k68bhv3.exponent = 2047;
				llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_g92bm9.num, &internal_ExpandedFloat_k68bhv3, 16L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv3);
				internal_FloatConvertReturn_g92bm9.error = 34;
				llvm_memcpy_p0_p0_i64.Invoke(agg_result, &internal_FloatConvertReturn_g92bm9, 24L, isVolatile: false);
			}
			else if (num2 < int_internal_get_lower_bound_double.Invoke())
			{
				llvm_lifetime_start_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv4);
				internal_ExpandedFloat_k68bhv4.mantissa = 0L;
				internal_ExpandedFloat_k68bhv4.exponent = 0;
				llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_g92bm9.num, &internal_ExpandedFloat_k68bhv4, 16L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv4);
				internal_FloatConvertReturn_g92bm9.error = 34;
				llvm_memcpy_p0_p0_i64.Invoke(agg_result, &internal_FloatConvertReturn_g92bm9, 24L, isVolatile: false);
			}
			else
			{
				if ((b & 1) != 1)
				{
					llvm_lifetime_start_p0.Invoke(24L, &cpp_optional_vqqfu6);
					llvm_memcpy_p0_p0_i64.Invoke(&internal_ExpandedFloat_k68bhv5, &internal_ExpandedFloat_k68bhv2, 16L, isVolatile: false);
					cpp_optional_internal_ExpandedFloat_double_internal_clinger_fast_path_double_internal_ExpandedFloat_double_internal_RoundDirection.Invoke(&cpp_optional_vqqfu6, *(long*)(&internal_ExpandedFloat_k68bhv5), ((int*)(&internal_ExpandedFloat_k68bhv5))[2], numStart);
					llvm_memcpy_p0_p0_i64.Invoke(&cpp_optional_vqqfu5, &cpp_optional_vqqfu6, 24L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(24L, &cpp_optional_vqqfu6);
					if (cpp_optional_internal_ExpandedFloat_double_has_value_const.Invoke(&cpp_optional_vqqfu5))
					{
						llvm_memcpy_p0_p0_i64.Invoke(&agg_result->num, cpp_optional_internal_ExpandedFloat_double_value.Invoke(&cpp_optional_vqqfu5), 16L, isVolatile: false);
						agg_result->error = 0;
						goto IL_0608;
					}
				}
				llvm_lifetime_start_p0.Invoke(24L, &cpp_optional_vqqfu7);
				llvm_memcpy_p0_p0_i64.Invoke(&internal_ExpandedFloat_k68bhv6, &internal_ExpandedFloat_k68bhv2, 16L, isVolatile: false);
				cpp_optional_internal_ExpandedFloat_double_internal_eisel_lemire_double_internal_ExpandedFloat_double_internal_RoundDirection.Invoke(&cpp_optional_vqqfu7, *(long*)(&internal_ExpandedFloat_k68bhv6), ((int*)(&internal_ExpandedFloat_k68bhv6))[2], numStart);
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_optional_vqqfu5, &cpp_optional_vqqfu7, 24L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(24L, &cpp_optional_vqqfu7);
				if (cpp_optional_internal_ExpandedFloat_double_has_value_const.Invoke(&cpp_optional_vqqfu5))
				{
					if ((b & 1) != 1)
					{
						llvm_memcpy_p0_p0_i64.Invoke(&agg_result->num, cpp_optional_internal_ExpandedFloat_double_value.Invoke(&cpp_optional_vqqfu5), 16L, isVolatile: false);
						agg_result->error = 0;
						goto IL_0608;
					}
					llvm_lifetime_start_p0.Invoke(24L, &cpp_optional_vqqfu8);
					sbyte* ptr8 = (sbyte*)(&cpp_optional_vqqfu8);
					sbyte* ptr9 = ptr8;
					*(long*)ptr9 = -6148914691236517206L;
					((int*)ptr9)[2] = -1431655766;
					sbyte* ptr10 = ptr9 + 12;
					*ptr10 = -86;
					ptr10[1] = -86;
					ptr10[2] = -86;
					ptr10[3] = -86;
					ptr8[16] = -86;
					sbyte* ptr11 = ptr8 + 17;
					*ptr11 = -86;
					ptr11[1] = -86;
					ptr11[2] = -86;
					ptr11[3] = -86;
					ptr11[4] = -86;
					ptr11[5] = -86;
					ptr11[6] = -86;
					internal_ExpandedFloat_k68bhv7.mantissa = num + 1L;
					internal_ExpandedFloat_k68bhv7.exponent = num2;
					cpp_optional_internal_ExpandedFloat_double_internal_eisel_lemire_double_internal_ExpandedFloat_double_internal_RoundDirection.Invoke(&cpp_optional_vqqfu8, *(long*)(&internal_ExpandedFloat_k68bhv7), ((int*)(&internal_ExpandedFloat_k68bhv7))[2], numStart);
					int num3;
					if (cpp_optional_internal_ExpandedFloat_double_has_value_const.Invoke(&cpp_optional_vqqfu8) && ((internal_ExpandedFloat_k68bhv*)cpp_optional_internal_ExpandedFloat_double_operator.Invoke(&cpp_optional_vqqfu5))->mantissa == ((internal_ExpandedFloat_k68bhv*)cpp_optional_internal_ExpandedFloat_double_operator.Invoke(&cpp_optional_vqqfu8))->mantissa && ((internal_ExpandedFloat_k68bhv*)cpp_optional_internal_ExpandedFloat_double_operator.Invoke(&cpp_optional_vqqfu5))->exponent == ((internal_ExpandedFloat_k68bhv*)cpp_optional_internal_ExpandedFloat_double_operator.Invoke(&cpp_optional_vqqfu8))->exponent)
					{
						llvm_memcpy_p0_p0_i64.Invoke(&agg_result->num, cpp_optional_internal_ExpandedFloat_double_value.Invoke(&cpp_optional_vqqfu5), 16L, isVolatile: false);
						agg_result->error = 0;
						num3 = 1;
					}
					else
					{
						num3 = 0;
					}
					llvm_lifetime_end_p0.Invoke(24L, &cpp_optional_vqqfu8);
					switch (num3)
					{
					case 0:
						break;
					default:
						goto IL_0608;
					}
				}
				llvm_lifetime_start_p0.Invoke(24L, &internal_FloatConvertReturn_g92bm10);
				internal_FloatConvertReturn_double_internal_simple_decimal_conversion_double_char_const_unsigned_long_internal_RoundDirection.Invoke(&internal_FloatConvertReturn_g92bm10, num_len, mantissa, numStart);
				llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_g92bm9, &internal_FloatConvertReturn_g92bm10, 20L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(24L, &internal_FloatConvertReturn_g92bm10);
				llvm_memcpy_p0_p0_i64.Invoke(agg_result, &internal_FloatConvertReturn_g92bm9, 24L, isVolatile: false);
			}
			goto IL_0608;
		}
		IL_0608:
		llvm_lifetime_end_p0.Invoke(24L, &cpp_optional_vqqfu5);
		llvm_lifetime_end_p0.Invoke(24L, &internal_FloatConvertReturn_g92bm9);
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
	}
}
