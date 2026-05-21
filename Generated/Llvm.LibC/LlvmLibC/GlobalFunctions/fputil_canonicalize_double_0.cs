using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_canonicalize_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12canonicalizeIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiRS4_RKS4_")]
	[DemangledName("int __llvm_libc_20_1_2_::fputil::canonicalize<double, 0>(double&, double const&)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([NativeType("double&")] void* cx, [NativeType("double const&")] void* x)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, *(double*)x);
			int result;
			if (details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)), expected: false))
			{
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				anon_izyfb8.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
				long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(v: FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)), sign: anon_izyfb8.val);
				fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val;
				*(double*)cx = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				fputil_raise_except_if_required.Invoke(1);
				result = 1;
			}
			else
			{
				*(double*)cx = *(double*)x;
				result = 0;
			}
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}
