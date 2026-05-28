using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_canonicalize_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12canonicalizeIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiRS4_RKS4_")]
	[DemangledName("int __llvm_libc_20_1_2_::fputil::canonicalize<double, 0>(double&, double const&)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("cx")][NativeType("double&")] void* Cx, [MangledName("x")][NativeType("double const&")] void* X)
	{
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, *(double*)X);
			int result;
			if (Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)), Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				anon_izyfb.Val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm);
				long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(V: FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)), Sign: anon_izyfb.Val);
				fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val;
				*(double*)Cx = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				Fputil_raise_except_if_required.Invoke(1);
				result = 1;
			}
			else
			{
				*(double*)Cx = *(double*)X;
				result = 0;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			return result;
		}
	}
}
