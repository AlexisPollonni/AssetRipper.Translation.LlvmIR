using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE4ENS0_6FPBitsIeEEE16is_signaling_nanEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::is_signaling_nan() const")]
internal static partial class fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_signaling_nan_const
{
	public unsafe static bool Invoke(void* @this)
	{
		return fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan_const.Invoke(@this) ? (unchecked((byte)((fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_quiet_nan_const.Invoke(@this) ? 1u : 0u) ^ 0xFFFFFFFFu)) != 0) : false;
	}
}
