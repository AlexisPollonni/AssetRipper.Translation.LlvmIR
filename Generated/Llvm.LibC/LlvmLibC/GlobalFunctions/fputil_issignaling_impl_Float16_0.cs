using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_issignaling_impl_Float16_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil16issignaling_implIDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiRKS4_")]
	[DemangledName("int __llvm_libc_20_1_2_::fputil::issignaling_impl<_Float16, 0>(_Float16 const&)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([NativeType("_Float16 const&")] void* x)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, *(Half*)x);
			bool result = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_signaling_nan.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2));
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result ? 1 : 0;
		}
	}
}
