using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_fminimum_mag_Float16_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12fminimum_magIDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::fminimum_mag<_Float16, 0>(_Float16, _Float16)")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke([NativeType("_Float16")] Half x, [NativeType("_Float16")] Half y)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, x);
			llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			*(short*)(&fputil_FPBits_2fahva3) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva3, y);
			Half result = ((!NumericHelper.FcmpOlt(fputil_abs_Float16_0.Invoke(x), fputil_abs_Float16_0.Invoke(y))) ? ((!NumericHelper.FcmpOlt(fputil_abs_Float16_0.Invoke(y), fputil_abs_Float16_0.Invoke(x))) ? fputil_fminimum_Float16_0.Invoke(x, y) : y) : x);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return result;
		}
	}
}
