using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8fminimumIgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_")]
[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::fminimum<__float128, 0>(__float128, __float128)")]
internal static partial class float128_fputil_fminimum_float128_0_float128_float128
{
	public unsafe static double Invoke(double x, double y)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi3, x);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			*(Int128*)(&fputil_FPBits_ubgsi4) = -6148914691236517206L;
			fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi4, y);
			double result = ((!fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan_const.Invoke(&fputil_FPBits_ubgsi3)) ? ((!fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_nan_const.Invoke(&fputil_FPBits_ubgsi4)) ? cpp_enable_if_cpp_is_floating_point_v_float128_float128_type_fputil_internal_min_float128_float128_float128.Invoke(x, y) : y) : x);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			return result;
		}
	}
}
