using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_clinger_fast_path_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal17clinger_fast_pathIdEENS_3cpp8optionalINS0_13ExpandedFloatIT_EEEES6_NS0_14RoundDirectionE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>> __llvm_libc_20_1_2_::internal::clinger_fast_path<double>(__llvm_libc_20_1_2_::internal::ExpandedFloat<double>, __llvm_libc_20_1_2_::internal::RoundDirection)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<double>>")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_cpp_optional_9m4esb* Agg_result, [MangledName("init_num.coerce0")] long Init_num, [MangledName("init_num.coerce1")] RoundDirection_b3pcwy Round, [MangledName("round")] int Mantissa)
	{
		Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv = default(Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv);
		long num = 0L;
		int num2 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		double num3 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm3 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm4 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm5 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm6 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm7 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm8 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv) = Init_num;
			((int*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv))[2] = (int)Round;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv.Mantissa;
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv.Exponent;
			if ((ulong)(num >>> 52) > 0uL)
			{
				Optional_internal_ExpandedFloat_double_Constructor_ws8gcn.Invoke(Agg_result);
				goto IL_04ff;
			}
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = double.NaN;
			num3 = num;
			if (num2 == 0)
			{
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
				FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, num3);
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
			}
			if (num2 > 0)
			{
				if (num2 > 37)
				{
					Optional_internal_ExpandedFloat_double_Constructor_ws8gcn.Invoke(Agg_result);
				}
				else
				{
					if (num2 > 22)
					{
						double num4 = num3;
						long num5 = checked(num2 - 22);
						num3 = num4 * ((double*)Llvm_libc_20_1_2_internal_ClingerConsts_double_POWERS_OF_TEN_ARRAY.Pointer)[num5];
						num2 = 22;
					}
					if (!(num3 > 9007199254740991.0))
					{
						Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
						double num6 = num3;
						long num7 = num2;
						FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3, num6 * ((double*)Llvm_libc_20_1_2_internal_ClingerConsts_double_POWERS_OF_TEN_ARRAY.Pointer)[num7]);
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3, 8L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
						goto IL_0295;
					}
					Optional_internal_ExpandedFloat_double_Constructor_ws8gcn.Invoke(Agg_result);
				}
				goto IL_04dd;
			}
		}
		if (num2 < 0)
		{
			if (-num2 > 22)
			{
				Optional_internal_ExpandedFloat_double_Constructor_ws8gcn.Invoke(Agg_result);
				goto IL_04dd;
			}
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
			double num8 = num3;
			long num9 = -num2;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm4, num8 / unchecked((double*)Llvm_libc_20_1_2_internal_ClingerConsts_double_POWERS_OF_TEN_ARRAY.Pointer)[num9]);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm4, 8L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
		}
		goto IL_0295;
		IL_04dd:
		Llvm_lifetime_end_p0.Invoke(8L, &num3);
		Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		goto IL_04ff;
		IL_0295:
		unchecked
		{
			if (Mantissa != 2)
			{
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm5);
				*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm5) = -6148914691236517206L;
				FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm5);
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm6);
				double num10 = 0.0 - num3;
				long num11 = num2;
				FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm6, num10 * ((double*)Llvm_libc_20_1_2_internal_ClingerConsts_double_POWERS_OF_TEN_ARRAY.Pointer)[num11]);
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm5, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm6, 8L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm6);
				if (NumericHelper.IsUnorderedOrNotEquals(FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm), 0.0 - FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm5)))
				{
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm7);
					*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm7) = -6148914691236517206L;
					FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm7);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm8);
					*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm8) = -6148914691236517206L;
					FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm8);
					if (FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) < 0.0 - FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm5))
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm7, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm, 8L, isVolatile: false);
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm8, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm5, 8L, isVolatile: false);
					}
					else
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm7, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm5, 8L, isVolatile: false);
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm8, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm, 8L, isVolatile: false);
					}
					if (Mantissa == 0)
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm8, 8L, isVolatile: false);
					}
					else
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm7, 8L, isVolatile: false);
					}
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm8);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm7);
				}
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm5);
			}
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2);
			*(long*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2) = -6148914691236517206L;
			((int*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2))[2] = -1431655766;
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2) + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2.Mantissa = FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
			llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2.Exponent = (ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
			Optional_internal_ExpandedFloat_double_Constructor_w43rtw.Invoke(Agg_result, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2);
			goto IL_04dd;
		}
		IL_04ff:
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
	}
}
