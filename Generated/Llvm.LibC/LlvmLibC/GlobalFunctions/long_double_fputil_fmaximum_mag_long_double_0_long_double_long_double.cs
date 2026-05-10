using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12fmaximum_magIeTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_")]
[DemangledName("long double __llvm_libc_20_1_2_::fputil::fmaximum_mag<long double, 0>(long double, long double)")]
internal static partial class long_double_fputil_fmaximum_mag_long_double_0_long_double_long_double
{
	public unsafe static double Invoke(double x, double y)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi3, x);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			*(Int128*)(&fputil_FPBits_ubgsi4) = -6148914691236517206L;
			fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi4, y);
			double result = ((!(long_double_fputil_abs_long_double_0_long_double.Invoke(x) > long_double_fputil_abs_long_double_0_long_double.Invoke(y))) ? ((!(long_double_fputil_abs_long_double_0_long_double.Invoke(y) > long_double_fputil_abs_long_double_0_long_double.Invoke(x))) ? long_double_fputil_fmaximum_long_double_0_long_double_long_double.Invoke(x, y) : y) : x);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			return result;
		}
	}
}
