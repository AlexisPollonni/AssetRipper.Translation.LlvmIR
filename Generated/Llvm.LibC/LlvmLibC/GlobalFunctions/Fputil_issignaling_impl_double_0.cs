using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_issignaling_impl_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil16issignaling_implIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiRKS4_")]
	[DemangledName("int __llvm_libc_20_1_2_::fputil::issignaling_impl<double, 0>(double const&)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("x")][NativeType("double const&")] void* X)
	{
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, *(double*)X);
			bool result = FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm));
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			return result ? 1 : 0;
		}
	}
}
