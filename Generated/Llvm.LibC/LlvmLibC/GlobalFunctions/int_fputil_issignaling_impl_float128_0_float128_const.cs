using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil16issignaling_implIgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiRKS4_")]
[DemangledName("int __llvm_libc_20_1_2_::fputil::issignaling_impl<__float128, 0>(__float128 const&)")]
internal static partial class int_fputil_issignaling_impl_float128_0_float128_const
{
	public unsafe static int Invoke(void* x)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi3, *(double*)x);
			bool result = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_signaling_nan_const.Invoke(&fputil_FPBits_ubgsi3);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			return result ? 1 : 0;
		}
	}
}
