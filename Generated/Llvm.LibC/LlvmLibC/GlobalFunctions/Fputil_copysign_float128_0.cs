using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_copysign_float128_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8copysignIgTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_")]
	[DemangledName("__float128 __llvm_libc_20_1_2_::fputil::copysign<__float128, 0>(__float128, __float128)")]
	[return: NativeType("__float128")]
	public unsafe static double Invoke([MangledName("x")][NativeType("__float128")] double X, [MangledName("y")][NativeType("__float128")] double Y)
	{
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi2 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
		*unchecked((Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)) = -6148914691236517206L;
		FPBits_float128_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, X);
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		FPBits_float128_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2, Y);
		anon_izyfb.Val = FPStorage_fputil_FPType_3_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		FPStorage_fputil_FPType_3_set_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, anon_izyfb.Val);
		Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		double result = FPBits_float128_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
		Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
		return result;
	}
}
