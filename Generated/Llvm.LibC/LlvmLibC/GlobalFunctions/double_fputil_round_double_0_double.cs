using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5roundIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
[DemangledName("double __llvm_libc_20_1_2_::fputil::round<double, 0>(double)")]
internal static partial class double_fputil_round_double_0_double
{
	public unsafe static double Invoke(double x)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		int num = 0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		int num2 = 0;
		sbyte b = 0;
		long num3 = 0L;
		long num4 = 0L;
		double num5 = 0.0;
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
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent_const.Invoke(&fputil_FPBits_wjhbrm2);
				if (num >= 52)
				{
					result = x;
				}
				else if (num == -1)
				{
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm2);
					long val = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_one_Sign.Invoke(anon_izyfb8.val);
					fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val;
					result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm3);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				}
				else if (num <= -2)
				{
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
					anon_izyfb9.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm2);
					long val2 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero_Sign.Invoke(anon_izyfb9.val);
					fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val2;
					result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm4);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = checked(52 - num);
					llvm_lifetime_start_p0.Invoke(1L, &b);
					b = (((fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke(&fputil_FPBits_wjhbrm2) & (1L << (int)(uint)(num2 - 1))) != 0L) ? ((sbyte)1) : ((sbyte)0));
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
						fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_uintval_unsigned_long.Invoke(&fputil_FPBits_wjhbrm2, num4);
						llvm_lifetime_start_p0.Invoke(8L, &num5);
						num5 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2);
						result = (((b & 1) == 1) ? ((!fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg_const.Invoke(&fputil_FPBits_wjhbrm2)) ? (num5 + 1.0) : (num5 - 1.0)) : num5);
						llvm_lifetime_end_p0.Invoke(8L, &num5);
					}
					llvm_lifetime_end_p0.Invoke(8L, &num4);
					llvm_lifetime_end_p0.Invoke(8L, &num3);
					llvm_lifetime_end_p0.Invoke(1L, &b);
					llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}
