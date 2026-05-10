using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil16issignaling_implIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiRKS4_")]
[DemangledName("int __llvm_libc_20_1_2_::fputil::issignaling_impl<double, 0>(double const&)")]
internal static partial class int_fputil_issignaling_impl_double_0_double_const
{
	public unsafe static int Invoke(void* x)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, *(double*)x);
			bool result = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan_const.Invoke(&fputil_FPBits_wjhbrm2);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result ? 1 : 0;
		}
	}
}
