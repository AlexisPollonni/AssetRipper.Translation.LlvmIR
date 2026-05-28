using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_clinger_fast_path_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal17clinger_fast_pathIeEENS_3cpp8optionalINS0_13ExpandedFloatIT_EEEES6_NS0_14RoundDirectionE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>> __llvm_libc_20_1_2_::internal::clinger_fast_path<long double>(__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>, __llvm_libc_20_1_2_::internal::RoundDirection)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>")]
	public unsafe static void Invoke([MangledName("agg.result")] Cpp_optional_q5jaj8* Agg_result, [MangledName("init_num")][NativeType("__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>")] void* Init_num, [MangledName("round")][NativeType("__llvm_libc_20_1_2_::internal::RoundDirection")] RoundDirection_b3pcwy Round)
	{
		Int128 @int = default(Int128);
		int num = 0;
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		double num2 = 0.0;
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi2 = default(Fputil_FPBits_ubgsi2);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(Fputil_FPBits_ubgsi2);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(Fputil_FPBits_ubgsi2);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(Fputil_FPBits_ubgsi2);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi6 = default(Fputil_FPBits_ubgsi2);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi7 = default(Fputil_FPBits_ubgsi2);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi8 = default(Fputil_FPBits_ubgsi2);
		Internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq = default(Internal_ExpandedFloat_9jummq);
		Int128 mantissa = default(Int128);
		Llvm_lifetime_start_p0.Invoke(16L, &@int);
		unchecked
		{
			@int = ((Internal_ExpandedFloat_9jummq*)Init_num)->Mantissa;
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = ((Internal_ExpandedFloat_9jummq*)Init_num)->Exponent;
			if (NumericHelper.IntCmpUgt(NumericHelper.ShiftRightLogical(@int, 63L), 0L))
			{
				Optional_internal_ExpandedFloat_long_double_Constructor_bp9437.Invoke(Agg_result);
				goto IL_05c3;
			}
			Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi);
			*(Int128*)(&fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi);
			Llvm_lifetime_start_p0.Invoke(16L, &num2);
			num2 = double.NaN;
			num2 = Llvm_fmuladd_f80.Invoke((long)NumericHelper.ShiftRightLogical(@int, 64L), 1.8446744073709552E+19, (long)@int);
			if (num == 0)
			{
				Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
				FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi2, num2);
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi, &fputil_FPBits_ubgsi2, 16L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
			}
			if (num > 0)
			{
				if (num > 48)
				{
					Optional_internal_ExpandedFloat_long_double_Constructor_bp9437.Invoke(Agg_result);
				}
				else
				{
					if (num > 27)
					{
						double num3 = num2;
						long num4 = checked(num - 27);
						num2 = num3 * ((double*)Internal_ClingerConsts_long_double_POWERS_OF_TEN_ARRAY.Pointer)[num4];
						num = 27;
					}
					if (!(num2 > 1.8446744073709552E+19))
					{
						Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
						double num5 = num2;
						long num6 = num;
						FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi3, num5 * ((double*)Internal_ClingerConsts_long_double_POWERS_OF_TEN_ARRAY.Pointer)[num6]);
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi, &fputil_FPBits_ubgsi3, 16L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
						goto IL_02cd;
					}
					Optional_internal_ExpandedFloat_long_double_Constructor_bp9437.Invoke(Agg_result);
				}
				goto IL_05a1;
			}
		}
		if (num < 0)
		{
			if (-num > 27)
			{
				Optional_internal_ExpandedFloat_long_double_Constructor_bp9437.Invoke(Agg_result);
				goto IL_05a1;
			}
			Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			double num7 = num2;
			long num8 = -num;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi4, num7 / unchecked((double*)Internal_ClingerConsts_long_double_POWERS_OF_TEN_ARRAY.Pointer)[num8]);
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi, &fputil_FPBits_ubgsi4, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
		}
		goto IL_02cd;
		IL_05a1:
		Llvm_lifetime_end_p0.Invoke(16L, &num2);
		Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		goto IL_05c3;
		IL_02cd:
		unchecked
		{
			if (Round != RoundDirection_b3pcwy.Nearest)
			{
				Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
				*(Int128*)(&fputil_FPBits_ubgsi5) = -6148914691236517206L;
				FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi5);
				Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
				double num9 = 0.0 - num2;
				long num10 = num;
				FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi6, num9 * ((double*)Internal_ClingerConsts_long_double_POWERS_OF_TEN_ARRAY.Pointer)[num10]);
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi5, &fputil_FPBits_ubgsi6, 16L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi6);
				if (NumericHelper.IsUnorderedOrNotEquals(FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi), 0.0 - FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi5)))
				{
					Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
					*(Int128*)(&fputil_FPBits_ubgsi7) = -6148914691236517206L;
					FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi7);
					Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
					*(Int128*)(&fputil_FPBits_ubgsi8) = -6148914691236517206L;
					FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi8);
					if (FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi) < 0.0 - FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi5))
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi7, &fputil_FPBits_ubgsi, 16L, isVolatile: false);
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi8, &fputil_FPBits_ubgsi5, 16L, isVolatile: false);
					}
					else
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi7, &fputil_FPBits_ubgsi5, 16L, isVolatile: false);
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi8, &fputil_FPBits_ubgsi, 16L, isVolatile: false);
					}
					if (Round == RoundDirection_b3pcwy.Up)
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi, &fputil_FPBits_ubgsi8, 16L, isVolatile: false);
					}
					else
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi, &fputil_FPBits_ubgsi7, 16L, isVolatile: false);
					}
					Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi8);
					Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi7);
				}
				Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
			}
			Llvm_lifetime_start_p0.Invoke(32L, &internal_ExpandedFloat_9jummq);
			*(Int128*)(&internal_ExpandedFloat_9jummq) = -6148914691236517206L;
			((int*)(&internal_ExpandedFloat_9jummq))[4] = -1431655766;
			sbyte* ptr = (sbyte*)(&internal_ExpandedFloat_9jummq) + 20;
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
			Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_get_explicit_mantissa.Invoke(&fputil_FPBits_ubgsi);
			Int128* num11 = &mantissa;
			Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
			*(long*)num11 = struct_fiz2nb2.field_0;
			byte* num12 = (byte*)(&mantissa) + 8u;
			Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
			*(long*)num12 = struct_fiz2nb3.field_1;
			internal_ExpandedFloat_9jummq.Mantissa = mantissa;
			internal_ExpandedFloat_9jummq.Exponent = (ushort)FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_biased_exponent.Invoke(&fputil_FPBits_ubgsi);
			Optional_internal_ExpandedFloat_long_double_Constructor_crcz7y.Invoke(Agg_result, &internal_ExpandedFloat_9jummq);
			Llvm_lifetime_end_p0.Invoke(32L, &internal_ExpandedFloat_9jummq);
			goto IL_05a1;
		}
		IL_05c3:
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(16L, &@int);
	}
}
