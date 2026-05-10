using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil34round_using_specific_rounding_modeIdEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EES4_E4typeES4_i")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double>, double>::type __llvm_libc_20_1_2_::fputil::round_using_specific_rounding_mode<double>(double, int)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_double_double_type_fputil_round_using_specific_rounding_mode_double_double_int
{
	public unsafe static double Invoke(double x, int rnd)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		sbyte b = 0;
		int num = 0;
		int num2 = 0;
		long num3 = 0L;
		long num4 = 0L;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		double num5 = 0.0;
		long num6 = 0L;
		long num7 = 0L;
		long num8 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x);
			double result;
			if (fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan_const.Invoke(&fputil_FPBits_wjhbrm2) || fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero_const.Invoke(&fputil_FPBits_wjhbrm2))
			{
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg_const.Invoke(&fputil_FPBits_wjhbrm2) ? ((sbyte)1) : ((sbyte)0));
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent_const.Invoke(&fputil_FPBits_wjhbrm2);
				if (num >= 52)
				{
					result = x;
				}
				else if (num <= -1)
				{
					result = rnd switch
					{
						1 => InstructionHelper.Select((b & 1) == 1, -1.0, 0.0), 
						0 => InstructionHelper.Select((b & 1) == 1, -0.0, 1.0), 
						2 => InstructionHelper.Select((b & 1) == 1, -0.0, 0.0), 
						3 => (num >= -1) ? InstructionHelper.Select((b & 1) == 1, -1.0, 1.0) : InstructionHelper.Select((b & 1) == 1, -0.0, 0.0), 
						_ => (num > -2 && fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke(&fputil_FPBits_wjhbrm2) != 0L) ? InstructionHelper.Select((b & 1) == 1, -1.0, 1.0) : InstructionHelper.Select((b & 1) == 1, -0.0, 0.0), 
					};
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = checked(52 - num);
					llvm_lifetime_start_p0.Invoke(8L, &num3);
					num3 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke(&fputil_FPBits_wjhbrm2);
					llvm_lifetime_start_p0.Invoke(8L, &num4);
					num4 = num3 >>> (int)(uint)num2 << (int)(uint)num2;
					if (num4 == num3)
					{
						result = x;
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
						*(long*)(&fputil_FPBits_wjhbrm3) = -6148914691236517206L;
						fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm3, num4);
						llvm_lifetime_start_p0.Invoke(8L, &num5);
						num5 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm3);
						llvm_lifetime_start_p0.Invoke(8L, &num6);
						num6 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke(&fputil_FPBits_wjhbrm2) & ((1L << (int)(uint)num2) - 1L);
						llvm_lifetime_start_p0.Invoke(8L, &num7);
						num7 = 1L << (int)(uint)(num2 - 1);
						llvm_lifetime_start_p0.Invoke(8L, &num8);
						num8 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke(&fputil_FPBits_wjhbrm3) & (1L << (int)(uint)num2);
						result = rnd switch
						{
							1 => ((b & 1) != 1) ? num5 : (num5 - 1.0), 
							0 => ((b & 1) != 1) ? (num5 + 1.0) : num5, 
							2 => num5, 
							3 => ((ulong)num6 < (ulong)num7) ? num5 : (((b & 1) != 1) ? (num5 + 1.0) : (num5 - 1.0)), 
							_ => ((ulong)num6 > (ulong)num7) ? (((b & 1) != 1) ? (num5 + 1.0) : (num5 - 1.0)) : ((num6 != num7) ? num5 : ((num == 0) ? InstructionHelper.Select((b & 1) == 1, -2.0, 2.0) : ((num8 == 0L) ? num5 : (((b & 1) != 1) ? (num5 + 1.0) : (num5 - 1.0))))), 
						};
						llvm_lifetime_end_p0.Invoke(8L, &num8);
						llvm_lifetime_end_p0.Invoke(8L, &num7);
						llvm_lifetime_end_p0.Invoke(8L, &num6);
						llvm_lifetime_end_p0.Invoke(8L, &num5);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					}
					llvm_lifetime_end_p0.Invoke(8L, &num4);
					llvm_lifetime_end_p0.Invoke(8L, &num3);
					llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
				llvm_lifetime_end_p0.Invoke(1L, &b);
			}
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}
