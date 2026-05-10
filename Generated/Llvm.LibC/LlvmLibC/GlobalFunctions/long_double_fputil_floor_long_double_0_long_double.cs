using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5floorIeTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
[DemangledName("long double __llvm_libc_20_1_2_::fputil::floor<long double, 0>(long double)")]
internal static partial class long_double_fputil_floor_long_double_0_long_double
{
	public unsafe static double Invoke(double x)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		*unchecked((Int128*)(&fputil_FPBits_ubgsi3)) = -6148914691236517206L;
		fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi3, x);
		double result = ((!fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_neg_const.Invoke(&fputil_FPBits_ubgsi3)) ? long_double_fputil_trunc_long_double_0_long_double.Invoke(x) : (0.0 - long_double_fputil_ceil_long_double_0_long_double.Invoke(0.0 - x)));
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		return result;
	}
}
