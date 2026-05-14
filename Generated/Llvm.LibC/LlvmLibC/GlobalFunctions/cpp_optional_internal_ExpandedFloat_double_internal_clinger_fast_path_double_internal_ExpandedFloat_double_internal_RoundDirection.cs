using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal17clinger_fast_pathIdEENS_3cpp8optionalINS0_13ExpandedFloatIT_EEEES6_NS0_14RoundDirectionE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>> __llvm_libc_20_1_2_::internal::clinger_fast_path<double>(__llvm_libc_20_1_2_::internal::ExpandedFloat<double>, __llvm_libc_20_1_2_::internal::RoundDirection)")]
internal static partial class cpp_optional_internal_ExpandedFloat_double_internal_clinger_fast_path_double_internal_ExpandedFloat_double_internal_RoundDirection
{
	public unsafe static void Invoke([MangledName("agg.result")] cpp_optional_9m4esb* agg_result, [MangledName("init_num.coerce0")] long init_num, [MangledName("init_num.coerce1")] RoundDirection_b3pcwy round, [MangledName("round")] int mantissa)
	{
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv2 = default(internal_ExpandedFloat_k68bhv);
		long num = 0L;
		int num2 = 0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		double num3 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm7 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm8 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm9 = default(fputil_FPBits_wjhbrm);
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv3 = default(internal_ExpandedFloat_k68bhv);
		unchecked
		{
			*(long*)(&internal_ExpandedFloat_k68bhv2) = init_num;
			((int*)(&internal_ExpandedFloat_k68bhv2))[2] = (int)round;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = internal_ExpandedFloat_k68bhv2.mantissa;
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = internal_ExpandedFloat_k68bhv2.exponent;
			if ((ulong)(num >>> 52) > 0uL)
			{
				cpp_optional_internal_ExpandedFloat_double_optional_cpp_nullopt_t.Invoke(agg_result);
				goto IL_04ff;
			}
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits.Invoke(&fputil_FPBits_wjhbrm2);
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = double.NaN;
			num3 = num;
			if (num2 == 0)
			{
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm3, num3);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm3, 8L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			}
			if (num2 > 0)
			{
				if (num2 > 37)
				{
					cpp_optional_internal_ExpandedFloat_double_optional_cpp_nullopt_t.Invoke(agg_result);
				}
				else
				{
					if (num2 > 22)
					{
						double num4 = num3;
						long num5 = checked(num2 - 22);
						num3 = num4 * ((double*)internal_ClingerConsts_double_POWERS_OF_TEN_ARRAY.Pointer)[num5];
						num2 = 22;
					}
					if (!(num3 > 9007199254740991.0))
					{
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
						double num6 = num3;
						long num7 = num2;
						fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm4, num6 * ((double*)internal_ClingerConsts_double_POWERS_OF_TEN_ARRAY.Pointer)[num7]);
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm4, 8L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
						goto IL_0295;
					}
					cpp_optional_internal_ExpandedFloat_double_optional_cpp_nullopt_t.Invoke(agg_result);
				}
				goto IL_04dd;
			}
		}
		if (num2 < 0)
		{
			if (-num2 > 22)
			{
				cpp_optional_internal_ExpandedFloat_double_optional_cpp_nullopt_t.Invoke(agg_result);
				goto IL_04dd;
			}
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
			double num8 = num3;
			long num9 = -num2;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm5, num8 / unchecked((double*)internal_ClingerConsts_double_POWERS_OF_TEN_ARRAY.Pointer)[num9]);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm5, 8L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
		}
		goto IL_0295;
		IL_04dd:
		llvm_lifetime_end_p0.Invoke(8L, &num3);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		goto IL_04ff;
		IL_0295:
		unchecked
		{
			if (mantissa != 2)
			{
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
				*(long*)(&fputil_FPBits_wjhbrm6) = -6148914691236517206L;
				fputil_FPBits_double_FPBits.Invoke(&fputil_FPBits_wjhbrm6);
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
				double num10 = 0.0 - num3;
				long num11 = num2;
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm7, num10 * ((double*)internal_ClingerConsts_double_POWERS_OF_TEN_ARRAY.Pointer)[num11]);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm6, &fputil_FPBits_wjhbrm7, 8L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
				if (NumericHelper.IsUnorderedOrNotEquals(fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2), 0.0 - fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm6)))
				{
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
					*(long*)(&fputil_FPBits_wjhbrm8) = -6148914691236517206L;
					fputil_FPBits_double_FPBits.Invoke(&fputil_FPBits_wjhbrm8);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
					*(long*)(&fputil_FPBits_wjhbrm9) = -6148914691236517206L;
					fputil_FPBits_double_FPBits.Invoke(&fputil_FPBits_wjhbrm9);
					if (fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2) < 0.0 - fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm6))
					{
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm8, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm9, &fputil_FPBits_wjhbrm6, 8L, isVolatile: false);
					}
					else
					{
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm8, &fputil_FPBits_wjhbrm6, 8L, isVolatile: false);
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm9, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
					}
					if (mantissa == 0)
					{
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm9, 8L, isVolatile: false);
					}
					else
					{
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm8, 8L, isVolatile: false);
					}
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
				}
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
			}
			llvm_lifetime_start_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv3);
			*(long*)(&internal_ExpandedFloat_k68bhv3) = -6148914691236517206L;
			((int*)(&internal_ExpandedFloat_k68bhv3))[2] = -1431655766;
			sbyte* ptr = (sbyte*)(&internal_ExpandedFloat_k68bhv3) + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			internal_ExpandedFloat_k68bhv3.mantissa = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2));
			internal_ExpandedFloat_k68bhv3.exponent = (ushort)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			cpp_optional_internal_ExpandedFloat_double_optional_internal_ExpandedFloat_double.Invoke(agg_result, &internal_ExpandedFloat_k68bhv3);
			llvm_lifetime_end_p0.Invoke(16L, &internal_ExpandedFloat_k68bhv3);
			goto IL_04dd;
		}
		IL_04ff:
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
	}
}
