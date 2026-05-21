using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_floor_float128_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5floorIgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::floor<__float128, 0>(__float128)")]
	[return: NativeType("__float128")]
	public unsafe static double Invoke([NativeType("__float128")] double x)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		*unchecked((Int128*)(&fputil_FPBits_ubgsi3)) = -6148914691236517206L;
		FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi3, x);
		double result = ((!FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_neg.Invoke(&fputil_FPBits_ubgsi3)) ? fputil_trunc_float128_0.Invoke(x) : (0.0 - fputil_ceil_float128_0.Invoke(0.0 - x)));
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		return result;
	}
}
