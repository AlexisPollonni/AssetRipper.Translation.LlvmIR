using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEE13is_inf_or_nanEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::is_inf_or_nan() const")]
internal static partial class fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_is_inf_or_nan_const
{
	public unsafe static bool Invoke(fputil_internal_FPRepImpl_7z3gh9* @this)
	{
		return unchecked((byte)((fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_finite_const.Invoke((fputil_internal_FPRepSem_i7nz4h*)@this) ? 1u : 0u) ^ 0xFFFFFFFFu)) != 0;
	}
}
