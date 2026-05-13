using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal31rounded_float_to_signed_integerIDF16_lTnNS_3cpp9enable_ifIXaasr3cppE19is_floating_point_vIT_Esr3cppE13is_integral_vIT0_EEiE4typeELi0EEES6_S5_")]
[DemangledName("long __llvm_libc_20_1_2_::fputil::internal::rounded_float_to_signed_integer<_Float16, long, 0>(_Float16)")]
internal static partial class long_fputil_internal_rounded_float_to_signed_integer_Float16_long_0_Float16
{
	public unsafe static long Invoke(Half x)
	{
		long num = 0L;
		long num2 = 0L;
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num3 = 0;
		int num4 = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = long.MinValue;
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = long.MaxValue;
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva2, x);
			llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
			*(sbyte*)(&anon_izyfb8) = -86;
			long result;
			if (fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)))
			{
				long_fputil_internal_rounded_float_to_signed_integer_Float16_long_0_Float16_lambda_operator_const.Invoke(&anon_izyfb8);
				result = InstructionHelper.Select(fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_neg_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)), long.MinValue, long.MaxValue);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_exponent_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2));
				llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = 63;
				if (num3 > 63)
				{
					long_fputil_internal_rounded_float_to_signed_integer_Float16_long_0_Float16_lambda_operator_const.Invoke(&anon_izyfb8);
					result = InstructionHelper.Select(fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_neg_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)), long.MinValue, long.MaxValue);
				}
				else if (num3 == 63 && (fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_pos_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)) || (ushort)fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)) != 0))
				{
					long_fputil_internal_rounded_float_to_signed_integer_Float16_long_0_Float16_lambda_operator_const.Invoke(&anon_izyfb8);
					result = InstructionHelper.Select(fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_neg_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)), long.MinValue, long.MaxValue);
				}
				else
				{
					result = (long)x;
				}
				llvm_lifetime_end_p0.Invoke(4L, &num4);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
			}
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
