using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEE16is_signaling_nanEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::is_signaling_nan() const")]
internal static partial class fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_signaling_nan_const
{
	public unsafe static bool Invoke(void* @this)
	{
		return fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan_const.Invoke(@this) ? (unchecked((byte)((fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_quiet_nan_const.Invoke(@this) ? 1u : 0u) ^ 0xFFFFFFFFu)) != 0) : false;
	}
}
