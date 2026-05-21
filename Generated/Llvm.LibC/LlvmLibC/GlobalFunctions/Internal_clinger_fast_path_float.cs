using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_clinger_fast_path_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal17clinger_fast_pathIfEENS_3cpp8optionalINS0_13ExpandedFloatIT_EEEES6_NS0_14RoundDirectionE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>> __llvm_libc_20_1_2_::internal::clinger_fast_path<float>(__llvm_libc_20_1_2_::internal::ExpandedFloat<float>, __llvm_libc_20_1_2_::internal::RoundDirection)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>")]
	public unsafe static Struct_8myw6y Invoke([MangledName("init_num.coerce")][NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<float>")] long Init_num, [MangledName("round")][NativeType("__llvm_libc_20_1_2_::internal::RoundDirection")] RoundDirection_b3pcwy Round)
	{
		Llvm_libc_20_1_2_cpp_optional_6hseum llvm_libc_20_1_2_cpp_optional_6hseum = default(Llvm_libc_20_1_2_cpp_optional_6hseum);
		Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up = default(Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up);
		int num = 0;
		int num2 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		float num3 = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs3 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs4 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs5 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs6 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs7 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs8 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up);
		Struct_8myw6y result = default(Struct_8myw6y);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up) = Init_num;
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up.Mantissa;
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up.Exponent;
			if ((uint)num >> 23 != 0)
			{
				Optional_internal_ExpandedFloat_float_Constructor_h2idu8.Invoke(&llvm_libc_20_1_2_cpp_optional_6hseum);
				goto IL_04b5;
			}
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = float.NaN;
			num3 = num;
			if (num2 == 0)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
				FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, num3);
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, 4L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			}
			if (num2 > 0)
			{
				if (num2 > 17)
				{
					Optional_internal_ExpandedFloat_float_Constructor_h2idu8.Invoke(&llvm_libc_20_1_2_cpp_optional_6hseum);
				}
				else
				{
					if (num2 > 10)
					{
						float num4 = num3;
						long num5 = checked(num2 - 10);
						num3 = num4 * ((float*)Llvm_libc_20_1_2_internal_ClingerConsts_float_POWERS_OF_TEN_ARRAY.Pointer)[num5];
						num2 = 10;
					}
					if (!(num3 > 16777215f))
					{
						Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
						float num6 = num3;
						long num7 = num2;
						FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3, num6 * ((float*)Llvm_libc_20_1_2_internal_ClingerConsts_float_POWERS_OF_TEN_ARRAY.Pointer)[num7]);
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3, 4L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
						goto IL_0280;
					}
					Optional_internal_ExpandedFloat_float_Constructor_h2idu8.Invoke(&llvm_libc_20_1_2_cpp_optional_6hseum);
				}
				goto IL_0493;
			}
		}
		if (num2 < 0)
		{
			if (-num2 > 10)
			{
				Optional_internal_ExpandedFloat_float_Constructor_h2idu8.Invoke(&llvm_libc_20_1_2_cpp_optional_6hseum);
				goto IL_0493;
			}
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
			float num8 = num3;
			long num9 = -num2;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs4, num8 / unchecked((float*)Llvm_libc_20_1_2_internal_ClingerConsts_float_POWERS_OF_TEN_ARRAY.Pointer)[num9]);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4, 4L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
		}
		goto IL_0280;
		IL_0493:
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		goto IL_04b5;
		IL_0280:
		unchecked
		{
			if (Round != RoundDirection_b3pcwy.Nearest)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
				*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5) = -1431655766;
				FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs6);
				float num10 = 0f - num3;
				long num11 = num2;
				FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs6, num10 * ((float*)Llvm_libc_20_1_2_internal_ClingerConsts_float_POWERS_OF_TEN_ARRAY.Pointer)[num11]);
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs6, 4L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs6);
				if (NumericHelper.IsUnorderedOrNotEquals(FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs), 0f - FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5)))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs7);
					*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs7) = -1431655766;
					FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs7);
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs8);
					*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs8) = -1431655766;
					FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs8);
					if (FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) < 0f - FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5))
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs7, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs, 4L, isVolatile: false);
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs8, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs5, 4L, isVolatile: false);
					}
					else
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs7, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs5, 4L, isVolatile: false);
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs8, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs, 4L, isVolatile: false);
					}
					if (Round == RoundDirection_b3pcwy.Up)
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs8, 4L, isVolatile: false);
					}
					else
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs7, 4L, isVolatile: false);
					}
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs8);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs7);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
			}
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2);
			*(int*)(&llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2) = -1431655766;
			((int*)(&llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2))[1] = -1431655766;
			llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2.Mantissa = FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2.Exponent = (ushort)FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
			Optional_internal_ExpandedFloat_float_Constructor_cm37bp.Invoke(&llvm_libc_20_1_2_cpp_optional_6hseum, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up2);
			goto IL_0493;
		}
		IL_04b5:
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_memcpy_p0_p0_i64.Invoke(&result, &llvm_libc_20_1_2_cpp_optional_6hseum.Storage, 12L, isVolatile: false);
		return result;
	}
}
