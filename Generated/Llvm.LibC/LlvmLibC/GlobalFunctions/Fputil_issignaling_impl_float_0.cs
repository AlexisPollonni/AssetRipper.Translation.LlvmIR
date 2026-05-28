using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_issignaling_impl_float_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil16issignaling_implIfTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiRKS4_")]
	[DemangledName("int __llvm_libc_20_1_2_::fputil::issignaling_impl<float, 0>(float const&)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("x")][NativeType("float const&")] void* X)
	{
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs, *(float*)X);
			bool result = FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan.Invoke(&fputil_FPBits_5nkvcs);
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
			return result ? 1 : 0;
		}
	}
}
