using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12fmaximum_magIDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_")]
[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::fmaximum_mag<_Float16, 0>(_Float16, _Float16)")]
internal static partial class Float16_fputil_fmaximum_mag_Float16_0_Float16_Float16
{
	public unsafe static Half Invoke(Half x, Half y)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva2, x);
			llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			*(short*)(&fputil_FPBits_2fahva3) = -21846;
			fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva3, y);
			Half result = ((!NumericHelper.FcmpOgt(Float16_fputil_abs_Float16_0_Float16.Invoke(x), Float16_fputil_abs_Float16_0_Float16.Invoke(y))) ? ((!NumericHelper.FcmpOgt(Float16_fputil_abs_Float16_0_Float16.Invoke(y), Float16_fputil_abs_Float16_0_Float16.Invoke(x))) ? Float16_fputil_fmaximum_Float16_0_Float16_Float16.Invoke(x, y) : y) : x);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result;
		}
	}
}
