using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3absIDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::abs<_Float16, 0>(_Float16)")]
internal static partial class Float16_fputil_abs_Float16_0_Float16
{
	public unsafe static Half Invoke(Half x)
	{
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
		fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva3, x);
		short field_ = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_abs_const.Invoke(unchecked((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva3)));
		fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
		Half result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva2);
		llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
		llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		return result;
	}
}
