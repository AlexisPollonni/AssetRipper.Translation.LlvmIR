using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_modf_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4modfIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_RS4_")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::modf<double, 0>(double, double&)")]
	[return: NativeType("double")]
	public unsafe static double Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("iptr")][NativeType("double&")] void* Iptr)
	{
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, X);
			double result;
			if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
			{
				*(double*)Iptr = X;
				result = X;
			}
			else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
			{
				*(double*)Iptr = X;
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				anon_izyfb.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
				long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero.Invoke(anon_izyfb.Val);
				fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val;
				result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			}
			else
			{
				*(double*)Iptr = Fputil_trunc_double_0.Invoke(X);
				if (X == *(double*)Iptr)
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
					result = X - *(double*)Iptr;
				}
			}
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			return result;
		}
	}
}
