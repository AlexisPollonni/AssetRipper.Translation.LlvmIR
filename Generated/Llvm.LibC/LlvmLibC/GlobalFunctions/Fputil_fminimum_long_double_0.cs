using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_fminimum_long_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8fminimumIeTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_")]
	[DemangledName("long double __llvm_libc_20_1_2_::fputil::fminimum<long double, 0>(long double, long double)")]
	[return: NativeType("long double")]
	public unsafe static double Invoke([MangledName("x")][NativeType("long double")] double X, [MangledName("y")][NativeType("long double")] double Y)
	{
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi2 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
		unchecked
		{
			*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, X);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
			*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2, Y);
			double result = ((!FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi)) ? ((!FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2)) ? Internal_min_long_double.Invoke(X, Y) : Y) : X);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
			return result;
		}
	}
}
