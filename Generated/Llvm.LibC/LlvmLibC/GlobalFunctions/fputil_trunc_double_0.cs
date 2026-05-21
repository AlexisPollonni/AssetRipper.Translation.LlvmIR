using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_trunc_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5truncIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::trunc<double, 0>(double)")]
	[return: NativeType("double")]
	public unsafe static double Invoke([NativeType("double")] double x)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		int num = 0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num2 = 0;
		long mantVal = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, x);
			double result;
			if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)))
			{
				result = x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
				if (num >= 52)
				{
					result = x;
				}
				else if (num <= -1)
				{
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					anon_izyfb8.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
					long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero.Invoke(anon_izyfb8.val);
					fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = checked(52 - num);
					llvm_lifetime_start_p0.Invoke(8L, &mantVal);
					mantVal = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) >>> (int)(uint)num2 << (int)(uint)num2;
					FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2), mantVal);
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
					llvm_lifetime_end_p0.Invoke(8L, &mantVal);
					llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}
