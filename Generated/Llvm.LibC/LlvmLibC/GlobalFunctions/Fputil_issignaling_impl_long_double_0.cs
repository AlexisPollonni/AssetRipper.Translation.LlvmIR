using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_issignaling_impl_long_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil16issignaling_implIeTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEEiRKS4_")]
	[DemangledName("int __llvm_libc_20_1_2_::fputil::issignaling_impl<long double, 0>(long double const&)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("x")][NativeType("long double const&")] void* X)
	{
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi, *(double*)X);
			bool result = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_signaling_nan.Invoke(&fputil_FPBits_ubgsi);
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi);
			return result ? 1 : 0;
		}
	}
}
