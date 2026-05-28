using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_fmaximum_mag_Float16_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12fmaximum_magIDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::fmaximum_mag<_Float16, 0>(_Float16, _Float16)")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("_Float16")] Half X, [MangledName("y")][NativeType("_Float16")] Half Y)
	{
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva, X);
			Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, Y);
			Half result = ((!NumericHelper.FcmpOgt(Fputil_abs_Float16_0.Invoke(X), Fputil_abs_Float16_0.Invoke(Y))) ? ((!NumericHelper.FcmpOgt(Fputil_abs_Float16_0.Invoke(Y), Fputil_abs_Float16_0.Invoke(X))) ? Fputil_fmaximum_Float16_0.Invoke(X, Y) : Y) : X);
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
			return result;
		}
	}
}
