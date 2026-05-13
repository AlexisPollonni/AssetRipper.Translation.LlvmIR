using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil16issignaling_implIfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiRKS4_")]
[DemangledName("int __llvm_libc_20_1_2_::fputil::issignaling_impl<float, 0>(float const&)")]
internal static partial class int_fputil_issignaling_impl_float_0_float_const
{
	public unsafe static int Invoke(void* x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, *(float*)x);
			bool result = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan_const.Invoke(&fputil_FPBits_5nkvcs2);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result ? 1 : 0;
		}
	}
}
