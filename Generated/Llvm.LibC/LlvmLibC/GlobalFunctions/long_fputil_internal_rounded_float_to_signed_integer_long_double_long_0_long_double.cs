using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal31rounded_float_to_signed_integerIelTnNS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EEiE4typeELi0EEES6_S5_")]
[DemangledName("long __llvm_libc_20_1_2_::fputil::internal::rounded_float_to_signed_integer<long double, long, 0>(long double)")]
internal static partial class long_fputil_internal_rounded_float_to_signed_integer_long_double_long_0_long_double
{
	public unsafe static long Invoke(double x)
	{
		long num = 0L;
		long num2 = 0L;
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num3 = 0;
		int num4 = 0;
		Int128 x2 = default(Int128);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = long.MinValue;
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = long.MaxValue;
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		long result;
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi3, x);
			llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
			*(sbyte*)(&anon_izyfb8) = -86;
			if (fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan_const.Invoke(&fputil_FPBits_ubgsi3))
			{
				long_fputil_internal_rounded_float_to_signed_integer_long_double_long_0_long_double_lambda_operator_const.Invoke(&anon_izyfb8);
				result = InstructionHelper.Select(fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_neg_const.Invoke(&fputil_FPBits_ubgsi3), long.MinValue, long.MaxValue);
				goto IL_0209;
			}
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_exponent_const.Invoke(&fputil_FPBits_ubgsi3);
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = 63;
			if (num3 > 63)
			{
				long_fputil_internal_rounded_float_to_signed_integer_long_double_long_0_long_double_lambda_operator_const.Invoke(&anon_izyfb8);
				result = InstructionHelper.Select(fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_neg_const.Invoke(&fputil_FPBits_ubgsi3), long.MinValue, long.MaxValue);
			}
			else
			{
				if (num3 != 63)
				{
					goto IL_01e1;
				}
				if (!fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_pos_const.Invoke(&fputil_FPBits_ubgsi3))
				{
					Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_get_mantissa_const.Invoke(&fputil_FPBits_ubgsi3);
					Int128* num5 = &x2;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num5 = struct_fiz2nb2.field_0;
					byte* num6 = (byte*)(&x2) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num6 = struct_fiz2nb3.field_1;
					if (!NumericHelper.IntCmpNe(x2, 0L))
					{
						goto IL_01e1;
					}
				}
				long_fputil_internal_rounded_float_to_signed_integer_long_double_long_0_long_double_lambda_operator_const.Invoke(&anon_izyfb8);
				result = InstructionHelper.Select(fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_neg_const.Invoke(&fputil_FPBits_ubgsi3), long.MinValue, long.MaxValue);
			}
			goto IL_01e7;
		}
		IL_01e1:
		result = unchecked((long)x);
		goto IL_01e7;
		IL_0209:
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		llvm_lifetime_end_p0.Invoke(8L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		return result;
		IL_01e7:
		llvm_lifetime_end_p0.Invoke(4L, &num4);
		llvm_lifetime_end_p0.Invoke(4L, &num3);
		goto IL_0209;
	}
}
