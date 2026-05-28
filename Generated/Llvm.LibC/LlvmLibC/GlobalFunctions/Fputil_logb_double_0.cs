using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_logb_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4logbIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::logb<double, 0>(double)")]
	[return: NativeType("double")]
	public unsafe static double Invoke([MangledName("x")][NativeType("double")] double X)
	{
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Fputil_DyadicFloat_syracv fputil_DyadicFloat_syracv = default(Fputil_DyadicFloat_syracv);
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, X);
			double result;
			if (Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)) || FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)), Expected: false))
			{
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
				{
					result = X;
				}
				else
				{
					Fputil_raise_except_if_required.Invoke(4);
					if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
					{
						Fputil_set_errno_if_required.Invoke(34);
						Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_NEG.Pointer, 1L, isVolatile: false);
						long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb.Val);
						fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val;
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
						Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Sign_POS.Pointer, 1L, isVolatile: false);
						long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb2.Val);
						fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val2;
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
						Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					}
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(16L, &fputil_DyadicFloat_syracv);
				*(sbyte*)(&fputil_DyadicFloat_syracv) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_syracv) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_syracv))[1] = -1431655766;
				((long*)(&fputil_DyadicFloat_syracv))[1] = -6148914691236517206L;
				DyadicFloat_64ul_DyadicFloat_double_0.Invoke(&fputil_DyadicFloat_syracv, FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm));
				result = DyadicFloat_64ul_get_unbiased_exponent.Invoke(&fputil_DyadicFloat_syracv);
				Llvm_lifetime_end_p0.Invoke(16L, &fputil_DyadicFloat_syracv);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			return result;
		}
	}
}
