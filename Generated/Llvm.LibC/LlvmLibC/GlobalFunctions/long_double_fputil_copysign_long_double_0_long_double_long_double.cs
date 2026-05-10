using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8copysignIeTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_")]
[DemangledName("long double __llvm_libc_20_1_2_::fputil::copysign<long double, 0>(long double, long double)")]
internal static partial class long_double_fputil_copysign_long_double_0_long_double_long_double
{
	public unsafe static double Invoke(double x, double y)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		*unchecked((Int128*)(&fputil_FPBits_ubgsi3)) = -6148914691236517206L;
		fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi3, x);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
		fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi4, y);
		anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi4);
		fputil_internal_FPStorage_fputil_FPType_4_set_sign_Sign.Invoke(&fputil_FPBits_ubgsi3, anon_izyfb8.val);
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
		double result = fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi3);
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		return result;
	}
}
