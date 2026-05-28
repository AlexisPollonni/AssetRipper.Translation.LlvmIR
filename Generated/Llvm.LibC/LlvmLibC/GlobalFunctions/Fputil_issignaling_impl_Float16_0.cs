using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_issignaling_impl_Float16_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil16issignaling_implIDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiRKS4_")]
	[DemangledName("int __llvm_libc_20_1_2_::fputil::issignaling_impl<_Float16, 0>(_Float16 const&)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("x")][NativeType("_Float16 const&")] void* X)
	{
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva, *(Half*)X);
			bool result = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_signaling_nan.Invoke((Fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva));
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
			return result ? 1 : 0;
		}
	}
}
