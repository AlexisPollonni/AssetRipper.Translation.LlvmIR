using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5floorIgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::floor<__float128, 0>(__float128)")]
internal static partial class float128_fputil_floor_float128_0_float128
{
	public unsafe static double Invoke(double x)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		*unchecked((Int128*)(&fputil_FPBits_ubgsi3)) = -6148914691236517206L;
		fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi3, x);
		double result = ((!fputil_internal_FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_neg_const.Invoke(&fputil_FPBits_ubgsi3)) ? float128_fputil_trunc_float128_0_float128.Invoke(x) : (0.0 - float128_fputil_ceil_float128_0_float128.Invoke(0.0 - x)));
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		return result;
	}
}
