using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8copysignIDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_")]
[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::copysign<_Float16, 0>(_Float16, _Float16)")]
internal static partial class Float16_fputil_copysign_Float16_0_Float16_Float16
{
	public unsafe static Half Invoke(Half x, Half y)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		*unchecked((short*)(&fputil_FPBits_2fahva2)) = -21846;
		fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva2, x);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
		fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva3, y);
		anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_0_sign_const.Invoke(&fputil_FPBits_2fahva3);
		fputil_internal_FPStorage_fputil_FPType_0_set_sign_Sign.Invoke(&fputil_FPBits_2fahva2, anon_izyfb8.val);
		llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
		Half result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva2);
		llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		return result;
	}
}
