using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_nextupdown_true_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10nextupdownILb1EdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::nextupdown<true, double, 0>(double)")]
	[return: NativeType("double")]
	public unsafe static double Invoke([MangledName("x")][NativeType("double")] double X)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Fputil_internal_FPRepImpl_ucubaq fputil_internal_FPRepImpl_ucubaq = default(Fputil_internal_FPRepImpl_ucubaq);
		Fputil_internal_FPRepImpl_ucubaq fputil_internal_FPRepImpl_ucubaq2 = default(Fputil_internal_FPRepImpl_ucubaq);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Fputil_internal_FPRepImpl_ucubaq fputil_internal_FPRepImpl_ucubaq3 = default(Fputil_internal_FPRepImpl_ucubaq);
		Fputil_internal_FPRepImpl_ucubaq fputil_internal_FPRepImpl_ucubaq4 = default(Fputil_internal_FPRepImpl_ucubaq);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
		unchecked
		{
			*(sbyte*)(&anon_izyfb) = 1;
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, X);
			bool num = FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			int num2;
			if (num)
			{
				num2 = 1;
			}
			else
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_ucubaq, &fputil_FPBits_wjhbrm, 8L, isVolatile: false);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &anon_izyfb, 1L, isVolatile: false);
				long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_max_normal.Invoke(anon_izyfb2.Val);
				fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val;
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_ucubaq2, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
				if (Internal_Equals_r4buia.Invoke(fputil_internal_FPRepImpl_ucubaq.FPRepSem.FPStorage.Val, fputil_internal_FPRepImpl_ucubaq2.FPRepSem.FPStorage.Val))
				{
					num2 = 1;
				}
				else
				{
					Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_ucubaq3, &fputil_FPBits_wjhbrm, 8L, isVolatile: false);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, &anon_izyfb, 1L, isVolatile: false);
					long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb3.Val);
					fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val2;
					Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_ucubaq4, &fputil_FPBits_wjhbrm3, 8L, isVolatile: false);
					num2 = (Internal_Equals_r4buia.Invoke(fputil_internal_FPRepImpl_ucubaq3.FPRepSem.FPStorage.Val, fputil_internal_FPRepImpl_ucubaq4.FPRepSem.FPStorage.Val) ? 1 : 0);
				}
			}
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			double result;
			if (num2 != 0)
			{
				result = X;
			}
			else
			{
				if (NumericHelper.IsUnorderedOrNotEquals(X, 0.0))
				{
					anon_izyfb4.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, &anon_izyfb, 1L, isVolatile: false);
					if (Equals_fy8fvt.Invoke(anon_izyfb4.Val, anon_izyfb5.Val))
					{
						Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
						FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm4, FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) + 1L);
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm, &fputil_FPBits_wjhbrm4, 8L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
						FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm5, FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) - 1L);
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm, &fputil_FPBits_wjhbrm5, 8L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
					}
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, &anon_izyfb, 1L, isVolatile: false);
					long val3 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_min_subnormal.Invoke(anon_izyfb6.Val);
					fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.Val = val3;
					Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm, &fputil_FPBits_wjhbrm6, 8L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
				}
				result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
			return result;
		}
	}
}
