using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_decimal_exp_to_float_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20decimal_exp_to_floatIeEENS0_18FloatConvertReturnIT_EENS0_13ExpandedFloatIS3_EEbNS0_14RoundDirectionEPKcm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<long double> __llvm_libc_20_1_2_::internal::decimal_exp_to_float<long double>(__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>, bool, __llvm_libc_20_1_2_::internal::RoundDirection, char const*, unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::internal::FloatConvertReturn<long double>")]
	public unsafe static void Invoke([MangledName("agg.result")] Internal_FloatConvertReturn_hgyipa* Agg_result, [MangledName("init_num")][NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>")] void* Init_num, [MangledName("truncated")][NativeType("bool")] bool Truncated, [MangledName("round")][NativeType("__llvm_libc_20_1_2_::internal::RoundDirection")] RoundDirection_b3pcwy Round, [MangledName("numStart")][NativeType("char const*")] void* NumStart, [MangledName("num_len")][NativeType("unsigned long")] long Num_len)
	{
		Int128 x = default(Int128);
		int num = 0;
		Internal_FloatConvertReturn_hgyipa internal_FloatConvertReturn_hgyipa = default(Internal_FloatConvertReturn_hgyipa);
		Cpp_optional_q5jaj8 cpp_optional_q5jaj = default(Cpp_optional_q5jaj8);
		Internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq = default(Internal_ExpandedFloat_9jummq);
		Internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq2 = default(Internal_ExpandedFloat_9jummq);
		Cpp_optional_q5jaj8 cpp_optional_q5jaj2 = default(Cpp_optional_q5jaj8);
		Internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq3 = default(Internal_ExpandedFloat_9jummq);
		Cpp_optional_q5jaj8 cpp_optional_q5jaj3 = default(Cpp_optional_q5jaj8);
		Internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq4 = default(Internal_ExpandedFloat_9jummq);
		Cpp_optional_q5jaj8 cpp_optional_q5jaj4 = default(Cpp_optional_q5jaj8);
		Internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq5 = default(Internal_ExpandedFloat_9jummq);
		Internal_FloatConvertReturn_hgyipa internal_FloatConvertReturn_hgyipa2 = default(Internal_FloatConvertReturn_hgyipa);
		sbyte b = (Truncated ? ((sbyte)1) : ((sbyte)0));
		Llvm_lifetime_start_p0.Invoke(16L, &x);
		unchecked
		{
			x = ((Internal_ExpandedFloat_9jummq*)Init_num)->Mantissa;
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = ((Internal_ExpandedFloat_9jummq*)Init_num)->Exponent;
			Llvm_lifetime_start_p0.Invoke(48L, &internal_FloatConvertReturn_hgyipa);
			Llvm_memset_p0_i64.Invoke(&internal_FloatConvertReturn_hgyipa, -86, 48L, isVolatile: false);
			FloatConvertReturn_long_double_Constructor.Invoke(&internal_FloatConvertReturn_hgyipa);
			Llvm_lifetime_start_p0.Invoke(48L, &cpp_optional_q5jaj);
			Llvm_memset_p0_i64.Invoke(&cpp_optional_q5jaj, -86, 48L, isVolatile: false);
			Optional_internal_ExpandedFloat_long_double_Constructor_jkh8ki.Invoke(&cpp_optional_q5jaj);
			if (num > Internal_get_upper_bound_long_double.Invoke())
			{
				Llvm_lifetime_start_p0.Invoke(32L, &internal_ExpandedFloat_9jummq);
				Llvm_memset_p0_i64.Invoke(&internal_ExpandedFloat_9jummq, 0, 32L, isVolatile: false);
				_ = ref internal_ExpandedFloat_9jummq.Mantissa;
				internal_ExpandedFloat_9jummq.Exponent = 32767;
				Llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_hgyipa.Num, &internal_ExpandedFloat_9jummq, 32L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(32L, &internal_ExpandedFloat_9jummq);
				internal_FloatConvertReturn_hgyipa.Error = 34;
				Llvm_memcpy_p0_p0_i64.Invoke(Agg_result, &internal_FloatConvertReturn_hgyipa, 48L, isVolatile: false);
			}
			else if (num < Internal_get_lower_bound_long_double.Invoke())
			{
				Llvm_lifetime_start_p0.Invoke(32L, &internal_ExpandedFloat_9jummq2);
				Llvm_memset_p0_i64.Invoke(&internal_ExpandedFloat_9jummq2, 0, 32L, isVolatile: false);
				_ = ref internal_ExpandedFloat_9jummq2.Mantissa;
				_ = ref internal_ExpandedFloat_9jummq2.Exponent;
				Llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_hgyipa.Num, &internal_ExpandedFloat_9jummq2, 32L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(32L, &internal_ExpandedFloat_9jummq2);
				internal_FloatConvertReturn_hgyipa.Error = 34;
				Llvm_memcpy_p0_p0_i64.Invoke(Agg_result, &internal_FloatConvertReturn_hgyipa, 48L, isVolatile: false);
			}
			else
			{
				if ((b & 1) != 1)
				{
					Llvm_lifetime_start_p0.Invoke(48L, &cpp_optional_q5jaj2);
					Llvm_memcpy_p0_p0_i64.Invoke(&internal_ExpandedFloat_9jummq3, Init_num, 32L, isVolatile: false);
					Internal_clinger_fast_path_long_double.Invoke(&cpp_optional_q5jaj2, &internal_ExpandedFloat_9jummq3, Round);
					Llvm_memcpy_p0_p0_i64.Invoke(&cpp_optional_q5jaj, &cpp_optional_q5jaj2, 48L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(48L, &cpp_optional_q5jaj2);
					if (Optional_internal_ExpandedFloat_long_double_has_value.Invoke(&cpp_optional_q5jaj))
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Num, Optional_internal_ExpandedFloat_long_double_value.Invoke(&cpp_optional_q5jaj), 32L, isVolatile: false);
						Agg_result->Error = 0;
						goto IL_0492;
					}
				}
				Llvm_lifetime_start_p0.Invoke(48L, &cpp_optional_q5jaj3);
				Llvm_memcpy_p0_p0_i64.Invoke(&internal_ExpandedFloat_9jummq4, Init_num, 32L, isVolatile: false);
				Internal_eisel_lemire_long_double.Invoke(&cpp_optional_q5jaj3, &internal_ExpandedFloat_9jummq4, Round);
				Llvm_memcpy_p0_p0_i64.Invoke(&cpp_optional_q5jaj, &cpp_optional_q5jaj3, 48L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(48L, &cpp_optional_q5jaj3);
				if (Optional_internal_ExpandedFloat_long_double_has_value.Invoke(&cpp_optional_q5jaj))
				{
					if ((b & 1) != 1)
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Num, Optional_internal_ExpandedFloat_long_double_value.Invoke(&cpp_optional_q5jaj), 32L, isVolatile: false);
						Agg_result->Error = 0;
						goto IL_0492;
					}
					Llvm_lifetime_start_p0.Invoke(48L, &cpp_optional_q5jaj4);
					Llvm_memset_p0_i64.Invoke(&cpp_optional_q5jaj4, -86, 48L, isVolatile: false);
					internal_ExpandedFloat_9jummq5.Mantissa = NumericHelper.Add(x, 1L);
					internal_ExpandedFloat_9jummq5.Exponent = num;
					Internal_eisel_lemire_long_double.Invoke(&cpp_optional_q5jaj4, &internal_ExpandedFloat_9jummq5, Round);
					int num2;
					if (Optional_internal_ExpandedFloat_long_double_has_value.Invoke(&cpp_optional_q5jaj4) && NumericHelper.IntCmpEq(Optional_internal_ExpandedFloat_long_double_PointerDereference.Invoke(&cpp_optional_q5jaj)->Mantissa, Optional_internal_ExpandedFloat_long_double_PointerDereference.Invoke(&cpp_optional_q5jaj4)->Mantissa) && Optional_internal_ExpandedFloat_long_double_PointerDereference.Invoke(&cpp_optional_q5jaj)->Exponent == Optional_internal_ExpandedFloat_long_double_PointerDereference.Invoke(&cpp_optional_q5jaj4)->Exponent)
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Num, Optional_internal_ExpandedFloat_long_double_value.Invoke(&cpp_optional_q5jaj), 32L, isVolatile: false);
						Agg_result->Error = 0;
						num2 = 1;
					}
					else
					{
						num2 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(48L, &cpp_optional_q5jaj4);
					switch (num2)
					{
					case 0:
						break;
					default:
						goto IL_0492;
					}
				}
				Llvm_lifetime_start_p0.Invoke(48L, &internal_FloatConvertReturn_hgyipa2);
				Internal_simple_decimal_conversion_long_double.Invoke(&internal_FloatConvertReturn_hgyipa2, NumStart, Num_len, Round);
				Llvm_memcpy_p0_p0_i64.Invoke(&internal_FloatConvertReturn_hgyipa, &internal_FloatConvertReturn_hgyipa2, 36L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(48L, &internal_FloatConvertReturn_hgyipa2);
				Llvm_memcpy_p0_p0_i64.Invoke(Agg_result, &internal_FloatConvertReturn_hgyipa, 48L, isVolatile: false);
			}
			goto IL_0492;
		}
		IL_0492:
		Llvm_lifetime_end_p0.Invoke(48L, &cpp_optional_q5jaj);
		Llvm_lifetime_end_p0.Invoke(48L, &internal_FloatConvertReturn_hgyipa);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(16L, &x);
	}
}
