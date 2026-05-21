using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_floor_float128_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5floorIgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::floor<__float128, 0>(__float128)")]
	[return: NativeType("__float128")]
	public unsafe static double Invoke([MangledName("x")][NativeType("__float128")] double X)
	{
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
		*unchecked((Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)) = -6148914691236517206L;
		FPBits_float128_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, X);
		double result = ((!FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_neg.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)) ? Fputil_trunc_float128_0.Invoke(X) : (0.0 - Fputil_ceil_float128_0.Invoke(0.0 - X)));
		Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
		return result;
	}
}
