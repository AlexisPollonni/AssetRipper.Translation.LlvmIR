using System;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal17clinger_fast_pathIeEENS_3cpp8optionalINS0_13ExpandedFloatIT_EEEES6_NS0_14RoundDirectionE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>> __llvm_libc_20_1_2_::internal::clinger_fast_path<long double>(__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>, __llvm_libc_20_1_2_::internal::RoundDirection)")]
internal static partial class cpp_optional_internal_ExpandedFloat_long_double_internal_clinger_fast_path_long_double_internal_ExpandedFloat_long_double_internal_RoundDirection
{
	public unsafe static void Invoke([MangledName("agg.result")] cpp_optional_q5jaj8* agg_result, void* init_num, RoundDirection_b3pcwy round)
	{
		Int128 @int = default(Int128);
		int num = 0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		double num2 = 0.0;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi6 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi7 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi8 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi9 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi10 = default(fputil_FPBits_ubgsi2);
		internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq2 = default(internal_ExpandedFloat_9jummq);
		Int128 mantissa = default(Int128);
		llvm_lifetime_start_p0.Invoke(16L, &@int);
		unchecked
		{
			@int = ((internal_ExpandedFloat_9jummq*)init_num)->mantissa;
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = ((internal_ExpandedFloat_9jummq*)init_num)->exponent;
			if (NumericHelper.IntCmpUgt(NumericHelper.ShiftRightLogical(@int, 63L), 0L))
			{
				cpp_optional_internal_ExpandedFloat_long_double_optional_cpp_nullopt_t.Invoke(agg_result);
				goto IL_05c3;
			}
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_long_double_FPBits.Invoke(&fputil_FPBits_ubgsi3);
			llvm_lifetime_start_p0.Invoke(16L, &num2);
			num2 = double.NaN;
			num2 = llvm_fmuladd_f80.Invoke((long)NumericHelper.ShiftRightLogical(@int, 64L), 1.8446744073709552E+19, (long)@int);
			if (num == 0)
			{
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
				fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi4, num2);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi4, 16L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			}
			if (num > 0)
			{
				if (num > 48)
				{
					cpp_optional_internal_ExpandedFloat_long_double_optional_cpp_nullopt_t.Invoke(agg_result);
				}
				else
				{
					if (num > 27)
					{
						double num3 = num2;
						long num4 = checked(num - 27);
						num2 = num3 * ((double*)internal_ClingerConsts_long_double_POWERS_OF_TEN_ARRAY.Pointer)[num4];
						num = 27;
					}
					if (!(num2 > 1.8446744073709552E+19))
					{
						llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
						double num5 = num2;
						long num6 = num;
						fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi5, num5 * ((double*)internal_ClingerConsts_long_double_POWERS_OF_TEN_ARRAY.Pointer)[num6]);
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi5, 16L, isVolatile: false);
						llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
						goto IL_02cd;
					}
					cpp_optional_internal_ExpandedFloat_long_double_optional_cpp_nullopt_t.Invoke(agg_result);
				}
				goto IL_05a1;
			}
		}
		if (num < 0)
		{
			if (-num > 27)
			{
				cpp_optional_internal_ExpandedFloat_long_double_optional_cpp_nullopt_t.Invoke(agg_result);
				goto IL_05a1;
			}
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
			double num7 = num2;
			long num8 = -num;
			fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi6, num7 / unchecked((double*)internal_ClingerConsts_long_double_POWERS_OF_TEN_ARRAY.Pointer)[num8]);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi6, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
		}
		goto IL_02cd;
		IL_05a1:
		llvm_lifetime_end_p0.Invoke(16L, &num2);
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		goto IL_05c3;
		IL_02cd:
		unchecked
		{
			if (round != RoundDirection_b3pcwy.Nearest)
			{
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
				*(Int128*)(&fputil_FPBits_ubgsi7) = -6148914691236517206L;
				fputil_FPBits_long_double_FPBits.Invoke(&fputil_FPBits_ubgsi7);
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
				double num9 = 0.0 - num2;
				long num10 = num;
				fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi8, num9 * ((double*)internal_ClingerConsts_long_double_POWERS_OF_TEN_ARRAY.Pointer)[num10]);
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi7, &fputil_FPBits_ubgsi8, 16L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
				if (NumericHelper.IsUnorderedOrNotEquals(fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi3), 0.0 - fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi7)))
				{
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi9);
					*(Int128*)(&fputil_FPBits_ubgsi9) = -6148914691236517206L;
					fputil_FPBits_long_double_FPBits.Invoke(&fputil_FPBits_ubgsi9);
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi10);
					*(Int128*)(&fputil_FPBits_ubgsi10) = -6148914691236517206L;
					fputil_FPBits_long_double_FPBits.Invoke(&fputil_FPBits_ubgsi10);
					if (fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi3) < 0.0 - fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi7))
					{
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi9, &fputil_FPBits_ubgsi3, 16L, isVolatile: false);
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi10, &fputil_FPBits_ubgsi7, 16L, isVolatile: false);
					}
					else
					{
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi9, &fputil_FPBits_ubgsi7, 16L, isVolatile: false);
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi10, &fputil_FPBits_ubgsi3, 16L, isVolatile: false);
					}
					if (round == RoundDirection_b3pcwy.Up)
					{
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi10, 16L, isVolatile: false);
					}
					else
					{
						llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi9, 16L, isVolatile: false);
					}
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi10);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi9);
				}
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
			}
			llvm_lifetime_start_p0.Invoke(32L, &internal_ExpandedFloat_9jummq2);
			*(Int128*)(&internal_ExpandedFloat_9jummq2) = -6148914691236517206L;
			((int*)(&internal_ExpandedFloat_9jummq2))[4] = -1431655766;
			sbyte* ptr = (sbyte*)(&internal_ExpandedFloat_9jummq2) + 20;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			ptr[4] = -86;
			ptr[5] = -86;
			ptr[6] = -86;
			ptr[7] = -86;
			ptr[8] = -86;
			ptr[9] = -86;
			ptr[10] = -86;
			ptr[11] = -86;
			Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa_const.Invoke(&fputil_FPBits_ubgsi3);
			Int128* num11 = &mantissa;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num11 = struct_fiz2nb2.field_0;
			byte* num12 = (byte*)(&mantissa) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num12 = struct_fiz2nb3.field_1;
			internal_ExpandedFloat_9jummq2.mantissa = mantissa;
			internal_ExpandedFloat_9jummq2.exponent = (ushort)fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent_const.Invoke(&fputil_FPBits_ubgsi3);
			cpp_optional_internal_ExpandedFloat_long_double_optional_internal_ExpandedFloat_long_double.Invoke(agg_result, &internal_ExpandedFloat_9jummq2);
			llvm_lifetime_end_p0.Invoke(32L, &internal_ExpandedFloat_9jummq2);
			goto IL_05a1;
		}
		IL_05c3:
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(16L, &@int);
	}
}
