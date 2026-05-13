using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal17clinger_fast_pathIfEENS_3cpp8optionalINS0_13ExpandedFloatIT_EEEES6_NS0_14RoundDirectionE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>> __llvm_libc_20_1_2_::internal::clinger_fast_path<float>(__llvm_libc_20_1_2_::internal::ExpandedFloat<float>, __llvm_libc_20_1_2_::internal::RoundDirection)")]
internal static partial class cpp_optional_internal_ExpandedFloat_float_internal_clinger_fast_path_float_internal_ExpandedFloat_float_internal_RoundDirection
{
	public unsafe static Struct_8myw6y Invoke([MangledName("init_num.coerce")] long init_num, RoundDirection_b3pcwy round)
	{
		cpp_optional_6hseum cpp_optional_6hseum2 = default(cpp_optional_6hseum);
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up2 = default(internal_ExpandedFloat_i7t5up);
		int num = 0;
		int num2 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		float num3 = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs6 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs7 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs8 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs9 = default(fputil_FPBits_5nkvcs);
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up3 = default(internal_ExpandedFloat_i7t5up);
		Struct_8myw6y result = default(Struct_8myw6y);
		unchecked
		{
			*(long*)(&internal_ExpandedFloat_i7t5up2) = init_num;
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = internal_ExpandedFloat_i7t5up2.mantissa;
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = internal_ExpandedFloat_i7t5up2.exponent;
			if ((uint)num >> 23 != 0)
			{
				cpp_optional_internal_ExpandedFloat_float_optional_cpp_nullopt_t.Invoke(&cpp_optional_6hseum2);
				goto IL_04b5;
			}
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits.Invoke(&fputil_FPBits_5nkvcs2);
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = float.NaN;
			num3 = num;
			if (num2 == 0)
			{
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs3, num3);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, &fputil_FPBits_5nkvcs3, 4L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			}
			if (num2 > 0)
			{
				if (num2 > 17)
				{
					cpp_optional_internal_ExpandedFloat_float_optional_cpp_nullopt_t.Invoke(&cpp_optional_6hseum2);
				}
				else
				{
					if (num2 > 10)
					{
						float num4 = num3;
						long num5 = checked(num2 - 10);
						num3 = num4 * ((float*)internal_ClingerConsts_float_POWERS_OF_TEN_ARRAY.Pointer)[num5];
						num2 = 10;
					}
					if (!(num3 > 16777215f))
					{
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
						float num6 = num3;
						long num7 = num2;
						fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs4, num6 * ((float*)internal_ClingerConsts_float_POWERS_OF_TEN_ARRAY.Pointer)[num7]);
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, &fputil_FPBits_5nkvcs4, 4L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
						goto IL_0280;
					}
					cpp_optional_internal_ExpandedFloat_float_optional_cpp_nullopt_t.Invoke(&cpp_optional_6hseum2);
				}
				goto IL_0493;
			}
		}
		if (num2 < 0)
		{
			if (-num2 > 10)
			{
				cpp_optional_internal_ExpandedFloat_float_optional_cpp_nullopt_t.Invoke(&cpp_optional_6hseum2);
				goto IL_0493;
			}
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
			float num8 = num3;
			long num9 = -num2;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs5, num8 / unchecked((float*)internal_ClingerConsts_float_POWERS_OF_TEN_ARRAY.Pointer)[num9]);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, &fputil_FPBits_5nkvcs5, 4L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
		}
		goto IL_0280;
		IL_0493:
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		goto IL_04b5;
		IL_0280:
		unchecked
		{
			if (round != RoundDirection_b3pcwy.Nearest)
			{
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
				*(int*)(&fputil_FPBits_5nkvcs6) = -1431655766;
				fputil_FPBits_float_FPBits.Invoke(&fputil_FPBits_5nkvcs6);
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
				float num10 = 0f - num3;
				long num11 = num2;
				fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs7, num10 * ((float*)internal_ClingerConsts_float_POWERS_OF_TEN_ARRAY.Pointer)[num11]);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs6, &fputil_FPBits_5nkvcs7, 4L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs7);
				if (NumericHelper.IsUnorderedOrNotEquals(fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2), 0f - fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs6)))
				{
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs8);
					*(int*)(&fputil_FPBits_5nkvcs8) = -1431655766;
					fputil_FPBits_float_FPBits.Invoke(&fputil_FPBits_5nkvcs8);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs9);
					*(int*)(&fputil_FPBits_5nkvcs9) = -1431655766;
					fputil_FPBits_float_FPBits.Invoke(&fputil_FPBits_5nkvcs9);
					if (fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2) < 0f - fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs6))
					{
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs8, &fputil_FPBits_5nkvcs2, 4L, isVolatile: false);
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs9, &fputil_FPBits_5nkvcs6, 4L, isVolatile: false);
					}
					else
					{
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs8, &fputil_FPBits_5nkvcs6, 4L, isVolatile: false);
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs9, &fputil_FPBits_5nkvcs2, 4L, isVolatile: false);
					}
					if (round == RoundDirection_b3pcwy.Up)
					{
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, &fputil_FPBits_5nkvcs9, 4L, isVolatile: false);
					}
					else
					{
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, &fputil_FPBits_5nkvcs8, 4L, isVolatile: false);
					}
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs9);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs8);
				}
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs6);
			}
			llvm_lifetime_start_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up3);
			*(int*)(&internal_ExpandedFloat_i7t5up3) = -1431655766;
			((int*)(&internal_ExpandedFloat_i7t5up3))[1] = -1431655766;
			internal_ExpandedFloat_i7t5up3.mantissa = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa_const.Invoke(&fputil_FPBits_5nkvcs2);
			internal_ExpandedFloat_i7t5up3.exponent = (ushort)fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_biased_exponent_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			cpp_optional_internal_ExpandedFloat_float_optional_internal_ExpandedFloat_float.Invoke(&cpp_optional_6hseum2, &internal_ExpandedFloat_i7t5up3);
			llvm_lifetime_end_p0.Invoke(8L, &internal_ExpandedFloat_i7t5up3);
			goto IL_0493;
		}
		IL_04b5:
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_memcpy_p0_p0_i64.Invoke(&result, &cpp_optional_6hseum2.storage, 12L, isVolatile: false);
		return result;
	}
}
