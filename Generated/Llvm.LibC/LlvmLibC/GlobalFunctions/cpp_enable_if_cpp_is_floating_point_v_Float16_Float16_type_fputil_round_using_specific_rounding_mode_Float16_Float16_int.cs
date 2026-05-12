using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil34round_using_specific_rounding_modeIDF16_EENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EES4_E4typeES4_i")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16>, _Float16>::type __llvm_libc_20_1_2_::fputil::round_using_specific_rounding_mode<_Float16>(_Float16, int)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_Float16_Float16_type_fputil_round_using_specific_rounding_mode_Float16_Float16_int
{
	public unsafe static Half Invoke(Half x, int rnd)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		sbyte b = 0;
		int num = 0;
		int num2 = 0;
		short num3 = 0;
		short num4 = 0;
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		Half half = default(Half);
		short num5 = 0;
		short num6 = 0;
		short num7 = 0;
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva2, x);
			Half result;
			if (fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)) || fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero_const.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2)))
			{
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_neg_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)) ? ((sbyte)1) : ((sbyte)0));
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_exponent_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2));
				if (num >= 10)
				{
					result = x;
				}
				else if (num <= -1)
				{
					result = rnd switch
					{
						1 => InstructionHelper.Select((b & 1) == 1, default(Half), default(Half)), 
						0 => InstructionHelper.Select((b & 1) == 1, default(Half), default(Half)), 
						2 => InstructionHelper.Select((b & 1) == 1, default(Half), default(Half)), 
						3 => (num >= -1) ? InstructionHelper.Select((b & 1) == 1, default(Half), default(Half)) : InstructionHelper.Select((b & 1) == 1, default(Half), default(Half)), 
						_ => (num > -2 && (ushort)fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)) != 0) ? InstructionHelper.Select((b & 1) == 1, default(Half), default(Half)) : InstructionHelper.Select((b & 1) == 1, default(Half), default(Half)), 
					};
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = checked(10 - num);
					llvm_lifetime_start_p0.Invoke(2L, &num3);
					num3 = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2));
					llvm_lifetime_start_p0.Invoke(2L, &num4);
					num4 = (short)((ushort)num3 >> num2 << num2);
					if ((ushort)num4 == (ushort)num3)
					{
						result = x;
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
						*(short*)(&fputil_FPBits_2fahva3) = -21846;
						fputil_FPBits_Float16_FPBits_unsigned_short_unsigned_short.Invoke(&fputil_FPBits_2fahva3, num4);
						llvm_lifetime_start_p0.Invoke(2L, &half);
						half = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva3);
						llvm_lifetime_start_p0.Invoke(2L, &num5);
						num5 = (short)((ushort)fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)) & (ushort)(short)checked((1 << num2) - 1));
						llvm_lifetime_start_p0.Invoke(2L, &num6);
						num6 = (short)(1 << num2 - 1);
						llvm_lifetime_start_p0.Invoke(2L, &num7);
						num7 = (short)((ushort)fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva3)) & (1 << num2));
						result = rnd switch
						{
							1 => ((b & 1) != 1) ? half : ((Half)((float)half - 1f)), 
							0 => ((b & 1) != 1) ? ((Half)((float)half + 1f)) : half, 
							2 => half, 
							3 => ((ushort)num5 < (ushort)num6) ? half : (((b & 1) != 1) ? ((Half)((float)half + 1f)) : ((Half)((float)half - 1f))), 
							_ => ((ushort)num5 > (ushort)num6) ? (((b & 1) != 1) ? ((Half)((float)half + 1f)) : ((Half)((float)half - 1f))) : (((ushort)num5 != (ushort)num6) ? half : ((num == 0) ? InstructionHelper.Select((b & 1) == 1, default(Half), default(Half)) : ((num7 == 0) ? half : (((b & 1) != 1) ? ((Half)((float)half + 1f)) : ((Half)((float)half - 1f)))))), 
						};
						llvm_lifetime_end_p0.Invoke(2L, &num7);
						llvm_lifetime_end_p0.Invoke(2L, &num6);
						llvm_lifetime_end_p0.Invoke(2L, &num5);
						llvm_lifetime_end_p0.Invoke(2L, &half);
						llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
					}
					llvm_lifetime_end_p0.Invoke(2L, &num4);
					llvm_lifetime_end_p0.Invoke(2L, &num3);
					llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
				llvm_lifetime_end_p0.Invoke(1L, &b);
			}
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result;
		}
	}
}
