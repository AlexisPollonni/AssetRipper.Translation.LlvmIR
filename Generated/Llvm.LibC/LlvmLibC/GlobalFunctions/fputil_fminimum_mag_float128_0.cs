using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_fminimum_mag_float128_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12fminimum_magIgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_")]
	[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::fminimum_mag<__float128, 0>(__float128, __float128)")]
	[return: NativeType("__float128")]
	public unsafe static double Invoke([NativeType("__float128")] double x, [NativeType("__float128")] double y)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi3, x);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			*(Int128*)(&fputil_FPBits_ubgsi4) = -6148914691236517206L;
			FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi4, y);
			double result = ((!(fputil_abs_float128_0.Invoke(x) < fputil_abs_float128_0.Invoke(y))) ? ((!(fputil_abs_float128_0.Invoke(y) < fputil_abs_float128_0.Invoke(x))) ? fputil_fminimum_float128_0.Invoke(x, y) : y) : x);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			return result;
		}
	}
}
