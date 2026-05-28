using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_abs_Float16_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil3absIDF16_TnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::fputil::abs<_Float16, 0>(_Float16)")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("_Float16")] Half X)
	{
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, X);
		short field_ = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_abs.Invoke(unchecked((Fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva2)));
		fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
		Half result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva);
		Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
		return result;
	}
}
