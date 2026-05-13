using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal20decimal_exp_to_floatIeEENS0_18FloatConvertReturnIT_EENS0_13ExpandedFloatIS3_EEbNS0_14RoundDirectionEPKcm")]
[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<long double> __llvm_libc_20_1_2_::internal::decimal_exp_to_float<long double>(__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>, bool, __llvm_libc_20_1_2_::internal::RoundDirection, char const*, unsigned long)")]
internal static partial class internal_FloatConvertReturn_long_double_internal_decimal_exp_to_float_long_double_internal_ExpandedFloat_long_double_bool_internal_RoundDirection_char_const_unsigned_long
{
	public unsafe static void Invoke([MangledName("agg.result")] internal_FloatConvertReturn_hgyipa* agg_result, void* init_num, bool truncated, RoundDirection_b3pcwy round, void* numStart, long num_len)
	{
		Int128 x = default(Int128);
		int num = 0;
		internal_FloatConvertReturn_hgyipa internal_FloatConvertReturn_hgyipa2 = default(internal_FloatConvertReturn_hgyipa);
		cpp_optional_q5jaj8 cpp_optional_q5jaj9 = default(cpp_optional_q5jaj8);
		internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq2 = default(internal_ExpandedFloat_9jummq);
		internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq3 = default(internal_ExpandedFloat_9jummq);
		cpp_optional_q5jaj8 cpp_optional_q5jaj10 = default(cpp_optional_q5jaj8);
		internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq4 = default(internal_ExpandedFloat_9jummq);
		cpp_optional_q5jaj8 cpp_optional_q5jaj11 = default(cpp_optional_q5jaj8);
		internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq5 = default(internal_ExpandedFloat_9jummq);
		cpp_optional_q5jaj8 cpp_optional_q5jaj12 = default(cpp_optional_q5jaj8);
		internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq6 = default(internal_ExpandedFloat_9jummq);
		internal_FloatConvertReturn_hgyipa internal_FloatConvertReturn_hgyipa3 = default(internal_FloatConvertReturn_hgyipa);
		sbyte b = (truncated ? ((sbyte)1) : ((sbyte)0));
		llvm_lifetime_start_p0.Invoke(16L, &x);
		unchecked
		{
			x = ((internal_ExpandedFloat_9jummq*)init_num)->mantissa;
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = ((internal_ExpandedFloat_9jummq*)init_num)->exponent;
			llvm_lifetime_start_p0.Invoke(48L, &internal_FloatConvertReturn_hgyipa2);
			llvm_memset_p0_i64.Invoke(&internal_FloatConvertReturn_hgyipa2, -86, 48L, isVolatile: false);
			internal_FloatConvertReturn_long_double_FloatConvertReturn.Invoke(&internal_FloatConvertReturn_hgyipa2);
			llvm_lifetime_start_p0.Invoke(48L, &cpp_optional_q5jaj9);
			llvm_memset_p0_i64.Invoke(&cpp_optional_q5jaj9, -86, 48L, isVolatile: false);
			cpp_optional_internal_ExpandedFloat_long_double_optional.Invoke(&cpp_optional_q5jaj9);
			if (num > int_internal_get_upper_bound_long_double.Invoke())
			{
				llvm_lifetime_start_p0.Invoke(32L, &internal_ExpandedFloat_9jummq2);
				llvm_memset_p0_i64.Invoke(&internal_ExpandedFloat_9jummq2, 0, 32L, isVolatile: false);
				_ = ref internal_ExpandedFloat_9jummq2.mantissa;
				internal_ExpandedFloat_9jummq2.exponent = 32767;
				llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_hgyipa2.num, &internal_ExpandedFloat_9jummq2, 32L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(32L, &internal_ExpandedFloat_9jummq2);
				internal_FloatConvertReturn_hgyipa2.error = 34;
				llvm_memcpy_p0_p0_i64.Invoke(agg_result, &internal_FloatConvertReturn_hgyipa2, 48L, isVolatile: false);
			}
			else if (num < int_internal_get_lower_bound_long_double.Invoke())
			{
				llvm_lifetime_start_p0.Invoke(32L, &internal_ExpandedFloat_9jummq3);
				llvm_memset_p0_i64.Invoke(&internal_ExpandedFloat_9jummq3, 0, 32L, isVolatile: false);
				_ = ref internal_ExpandedFloat_9jummq3.mantissa;
				_ = ref internal_ExpandedFloat_9jummq3.exponent;
				llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_hgyipa2.num, &internal_ExpandedFloat_9jummq3, 32L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(32L, &internal_ExpandedFloat_9jummq3);
				internal_FloatConvertReturn_hgyipa2.error = 34;
				llvm_memcpy_p0_p0_i64.Invoke(agg_result, &internal_FloatConvertReturn_hgyipa2, 48L, isVolatile: false);
			}
			else
			{
				if ((b & 1) != 1)
				{
					llvm_lifetime_start_p0.Invoke(48L, &cpp_optional_q5jaj10);
					llvm_memcpy_p0_p0_i64.Invoke(&internal_ExpandedFloat_9jummq4, init_num, 32L, isVolatile: false);
					cpp_optional_internal_ExpandedFloat_long_double_internal_clinger_fast_path_long_double_internal_ExpandedFloat_long_double_internal_RoundDirection.Invoke(&cpp_optional_q5jaj10, &internal_ExpandedFloat_9jummq4, round);
					llvm_memcpy_p0_p0_i64.Invoke(&cpp_optional_q5jaj9, &cpp_optional_q5jaj10, 48L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(48L, &cpp_optional_q5jaj10);
					if (cpp_optional_internal_ExpandedFloat_long_double_has_value_const.Invoke(&cpp_optional_q5jaj9))
					{
						llvm_memcpy_p0_p0_i64.Invoke(&agg_result->num, cpp_optional_internal_ExpandedFloat_long_double_value.Invoke(&cpp_optional_q5jaj9), 32L, isVolatile: false);
						agg_result->error = 0;
						goto IL_0492;
					}
				}
				llvm_lifetime_start_p0.Invoke(48L, &cpp_optional_q5jaj11);
				llvm_memcpy_p0_p0_i64.Invoke(&internal_ExpandedFloat_9jummq5, init_num, 32L, isVolatile: false);
				cpp_optional_internal_ExpandedFloat_long_double_internal_eisel_lemire_long_double_internal_ExpandedFloat_long_double_internal_RoundDirection.Invoke(&cpp_optional_q5jaj11, &internal_ExpandedFloat_9jummq5, round);
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_optional_q5jaj9, &cpp_optional_q5jaj11, 48L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(48L, &cpp_optional_q5jaj11);
				if (cpp_optional_internal_ExpandedFloat_long_double_has_value_const.Invoke(&cpp_optional_q5jaj9))
				{
					if ((b & 1) != 1)
					{
						llvm_memcpy_p0_p0_i64.Invoke(&agg_result->num, cpp_optional_internal_ExpandedFloat_long_double_value.Invoke(&cpp_optional_q5jaj9), 32L, isVolatile: false);
						agg_result->error = 0;
						goto IL_0492;
					}
					llvm_lifetime_start_p0.Invoke(48L, &cpp_optional_q5jaj12);
					llvm_memset_p0_i64.Invoke(&cpp_optional_q5jaj12, -86, 48L, isVolatile: false);
					internal_ExpandedFloat_9jummq6.mantissa = NumericHelper.Add(x, 1L);
					internal_ExpandedFloat_9jummq6.exponent = num;
					cpp_optional_internal_ExpandedFloat_long_double_internal_eisel_lemire_long_double_internal_ExpandedFloat_long_double_internal_RoundDirection.Invoke(&cpp_optional_q5jaj12, &internal_ExpandedFloat_9jummq6, round);
					int num2;
					if (cpp_optional_internal_ExpandedFloat_long_double_has_value_const.Invoke(&cpp_optional_q5jaj12) && NumericHelper.IntCmpEq(cpp_optional_internal_ExpandedFloat_long_double_operator.Invoke(&cpp_optional_q5jaj9)->mantissa, cpp_optional_internal_ExpandedFloat_long_double_operator.Invoke(&cpp_optional_q5jaj12)->mantissa) && cpp_optional_internal_ExpandedFloat_long_double_operator.Invoke(&cpp_optional_q5jaj9)->exponent == cpp_optional_internal_ExpandedFloat_long_double_operator.Invoke(&cpp_optional_q5jaj12)->exponent)
					{
						llvm_memcpy_p0_p0_i64.Invoke(&agg_result->num, cpp_optional_internal_ExpandedFloat_long_double_value.Invoke(&cpp_optional_q5jaj9), 32L, isVolatile: false);
						agg_result->error = 0;
						num2 = 1;
					}
					else
					{
						num2 = 0;
					}
					llvm_lifetime_end_p0.Invoke(48L, &cpp_optional_q5jaj12);
					switch (num2)
					{
					case 0:
						break;
					default:
						goto IL_0492;
					}
				}
				llvm_lifetime_start_p0.Invoke(48L, &internal_FloatConvertReturn_hgyipa3);
				internal_FloatConvertReturn_long_double_internal_simple_decimal_conversion_long_double_char_const_unsigned_long_internal_RoundDirection.Invoke(&internal_FloatConvertReturn_hgyipa3, numStart, num_len, round);
				llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_hgyipa2, &internal_FloatConvertReturn_hgyipa3, 36L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(48L, &internal_FloatConvertReturn_hgyipa3);
				llvm_memcpy_p0_p0_i64.Invoke(agg_result, &internal_FloatConvertReturn_hgyipa2, 48L, isVolatile: false);
			}
			goto IL_0492;
		}
		IL_0492:
		llvm_lifetime_end_p0.Invoke(48L, &cpp_optional_q5jaj9);
		llvm_lifetime_end_p0.Invoke(48L, &internal_FloatConvertReturn_hgyipa2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(16L, &x);
	}
}
