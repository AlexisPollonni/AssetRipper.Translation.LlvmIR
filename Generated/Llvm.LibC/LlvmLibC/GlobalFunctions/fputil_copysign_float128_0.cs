using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_copysign_float128_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8copysignIgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_")]
	[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::copysign<__float128, 0>(__float128, __float128)")]
	[return: NativeType("__float128")]
	public unsafe static double Invoke([NativeType("__float128")] double x, [NativeType("__float128")] double y)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		*unchecked((Int128*)(&fputil_FPBits_ubgsi3)) = -6148914691236517206L;
		FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi3, x);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
		FPBits_float128_Constructor.Invoke(&fputil_FPBits_ubgsi4, y);
		anon_izyfb8.val = FPStorage_fputil_FPType_3_sign.Invoke(&fputil_FPBits_ubgsi4);
		FPStorage_fputil_FPType_3_set_sign.Invoke(&fputil_FPBits_ubgsi3, anon_izyfb8.val);
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
		double result = FPBits_float128_get_val.Invoke(&fputil_FPBits_ubgsi3);
		llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		return result;
	}
}
