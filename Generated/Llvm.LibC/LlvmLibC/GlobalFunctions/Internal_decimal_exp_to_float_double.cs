using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_decimal_exp_to_float_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20decimal_exp_to_floatIdEENS0_18FloatConvertReturnIT_EENS0_13ExpandedFloatIS3_EEbNS0_14RoundDirectionEPKcm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<double> __llvm_libc_20_1_2_::internal::decimal_exp_to_float<double>(__llvm_libc_20_1_2_::internal::ExpandedFloat<double>, bool, __llvm_libc_20_1_2_::internal::RoundDirection, char const*, unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::internal::FloatConvertReturn<double>")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm8* Agg_result, [MangledName("init_num.coerce0")] long Init_num, [MangledName("init_num.coerce1")] int Truncated, [MangledName("truncated")] bool Round, [MangledName("round")] int NumStart, [MangledName("numStart")] void* Num_len, [MangledName("num_len")] long Mantissa)
	{
		Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv = default(Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv);
		long num = 0L;
		int num2 = 0;
		Llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm8 llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm = default(Llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm8);
		Llvm_libc_20_1_2_cpp_optional_9m4esb llvm_libc_20_1_2_cpp_optional_9m4esb = default(Llvm_libc_20_1_2_cpp_optional_9m4esb);
		Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv);
		Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv3 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv);
		Llvm_libc_20_1_2_cpp_optional_9m4esb llvm_libc_20_1_2_cpp_optional_9m4esb2 = default(Llvm_libc_20_1_2_cpp_optional_9m4esb);
		Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv4 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv);
		Llvm_libc_20_1_2_cpp_optional_9m4esb llvm_libc_20_1_2_cpp_optional_9m4esb3 = default(Llvm_libc_20_1_2_cpp_optional_9m4esb);
		Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv5 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv);
		Llvm_libc_20_1_2_cpp_optional_9m4esb llvm_libc_20_1_2_cpp_optional_9m4esb4 = default(Llvm_libc_20_1_2_cpp_optional_9m4esb);
		Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv6 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv);
		Llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm8 llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm2 = default(Llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm8);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv) = Init_num;
			((int*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv))[2] = Truncated;
			sbyte b = (Round ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv.Mantissa;
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv.Exponent;
			Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm);
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm);
			*(long*)ptr = -6148914691236517206L;
			((int*)ptr)[2] = -1431655766;
			sbyte* ptr2 = ptr + 12;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			ptr2[3] = -86;
			((int*)(&llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm))[4] = -1431655766;
			sbyte* ptr3 = (sbyte*)(&llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm) + 20;
			*ptr3 = -86;
			ptr3[1] = -86;
			ptr3[2] = -86;
			ptr3[3] = -86;
			FloatConvertReturn_double_Constructor.Invoke(&llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm);
			Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_cpp_optional_9m4esb);
			sbyte* ptr4 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_9m4esb);
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
			Optional_internal_ExpandedFloat_double_Constructor_6vskuc.Invoke(&llvm_libc_20_1_2_cpp_optional_9m4esb);
			if (num2 > Internal_get_upper_bound_double.Invoke())
			{
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2);
				llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2.Mantissa = 0L;
				llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2.Exponent = 2047;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm.Num, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2, 16L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2);
				llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm.Error = 34;
				Llvm_memcpy_p0_p0_i64.Invoke(Agg_result, &llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm, 24L, isVolatile: false);
			}
			else if (num2 < Internal_get_lower_bound_double.Invoke())
			{
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv3);
				llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv3.Mantissa = 0L;
				llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv3.Exponent = 0;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm.Num, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv3, 16L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv3);
				llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm.Error = 34;
				Llvm_memcpy_p0_p0_i64.Invoke(Agg_result, &llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm, 24L, isVolatile: false);
			}
			else
			{
				if ((b & 1) != 1)
				{
					Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_cpp_optional_9m4esb2);
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv4, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv, 16L, isVolatile: false);
					Internal_clinger_fast_path_double.Invoke(&llvm_libc_20_1_2_cpp_optional_9m4esb2, *(long*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv4), ((RoundDirection_b3pcwy*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv4))[2], NumStart);
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_optional_9m4esb, &llvm_libc_20_1_2_cpp_optional_9m4esb2, 24L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_cpp_optional_9m4esb2);
					if (Optional_internal_ExpandedFloat_double_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_9m4esb))
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Num, Optional_internal_ExpandedFloat_double_value.Invoke(&llvm_libc_20_1_2_cpp_optional_9m4esb), 16L, isVolatile: false);
						Agg_result->Error = 0;
						goto IL_0608;
					}
				}
				Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_cpp_optional_9m4esb3);
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv5, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv, 16L, isVolatile: false);
				Internal_eisel_lemire_double.Invoke(&llvm_libc_20_1_2_cpp_optional_9m4esb3, *(long*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv5), ((RoundDirection_b3pcwy*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv5))[2], NumStart);
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_optional_9m4esb, &llvm_libc_20_1_2_cpp_optional_9m4esb3, 24L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_cpp_optional_9m4esb3);
				if (Optional_internal_ExpandedFloat_double_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_9m4esb))
				{
					if ((b & 1) != 1)
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Num, Optional_internal_ExpandedFloat_double_value.Invoke(&llvm_libc_20_1_2_cpp_optional_9m4esb), 16L, isVolatile: false);
						Agg_result->Error = 0;
						goto IL_0608;
					}
					Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_cpp_optional_9m4esb4);
					sbyte* ptr8 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_9m4esb4);
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
					llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv6.Mantissa = num + 1L;
					llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv6.Exponent = num2;
					Internal_eisel_lemire_double.Invoke(&llvm_libc_20_1_2_cpp_optional_9m4esb4, *(long*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv6), ((RoundDirection_b3pcwy*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv6))[2], NumStart);
					int num3;
					if (Optional_internal_ExpandedFloat_double_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_9m4esb4) && Optional_internal_ExpandedFloat_double_PointerDereference.Invoke(&llvm_libc_20_1_2_cpp_optional_9m4esb)->Mantissa == Optional_internal_ExpandedFloat_double_PointerDereference.Invoke(&llvm_libc_20_1_2_cpp_optional_9m4esb4)->Mantissa && Optional_internal_ExpandedFloat_double_PointerDereference.Invoke(&llvm_libc_20_1_2_cpp_optional_9m4esb)->Exponent == Optional_internal_ExpandedFloat_double_PointerDereference.Invoke(&llvm_libc_20_1_2_cpp_optional_9m4esb4)->Exponent)
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Num, Optional_internal_ExpandedFloat_double_value.Invoke(&llvm_libc_20_1_2_cpp_optional_9m4esb), 16L, isVolatile: false);
						Agg_result->Error = 0;
						num3 = 1;
					}
					else
					{
						num3 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_cpp_optional_9m4esb4);
					switch (num3)
					{
					case 0:
						break;
					default:
						goto IL_0608;
					}
				}
				Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm2);
				Internal_simple_decimal_conversion_double.Invoke(&llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm2, Num_len, Mantissa, (RoundDirection_b3pcwy)NumStart);
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm, &llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm2, 20L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm2);
				Llvm_memcpy_p0_p0_i64.Invoke(Agg_result, &llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm, 24L, isVolatile: false);
			}
			goto IL_0608;
		}
		IL_0608:
		Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_cpp_optional_9m4esb);
		Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
	}
}
