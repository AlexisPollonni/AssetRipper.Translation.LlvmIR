using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_round_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5roundIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::round<double, 0>(double)")]
	[return: NativeType("double")]
	public unsafe static double Invoke([MangledName("x")][NativeType("double")] double X)
	{
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		int num = 0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		int num2 = 0;
		sbyte b = 0;
		long num3 = 0L;
		long num4 = 0L;
		double num5 = 0.0;
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, X);
			double result;
			if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
			{
				result = X;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
				if (num >= 52)
				{
					result = X;
				}
				else if (num == -1)
				{
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
					anon_izyfb.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
					long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_one.Invoke(anon_izyfb.Val);
					fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				}
				else if (num <= -2)
				{
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					anon_izyfb2.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
					long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero.Invoke(anon_izyfb2.Val);
					fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val2;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = checked(52 - num);
					Llvm_lifetime_start_p0.Invoke(1L, &b);
					b = (((FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) & (1L << (int)(uint)(num2 - 1))) != 0L) ? ((sbyte)1) : ((sbyte)0));
					Llvm_lifetime_start_p0.Invoke(8L, &num3);
					num3 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
					Llvm_lifetime_start_p0.Invoke(8L, &num4);
					num4 = num3 >>> (int)(uint)num2 << (int)(uint)num2;
					if (num4 == num3)
					{
						result = X;
					}
					else
					{
						FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm), num4);
						Llvm_lifetime_start_p0.Invoke(8L, &num5);
						num5 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm);
						result = (((b & 1) == 1) ? ((!FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm))) ? (num5 + 1.0) : (num5 - 1.0)) : num5);
						Llvm_lifetime_end_p0.Invoke(8L, &num5);
					}
					Llvm_lifetime_end_p0.Invoke(8L, &num4);
					Llvm_lifetime_end_p0.Invoke(8L, &num3);
					Llvm_lifetime_end_p0.Invoke(1L, &b);
					Llvm_lifetime_end_p0.Invoke(4L, &num2);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			return result;
		}
	}
}
