using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE2ENS0_6FPBitsIdEEE16is_signaling_nanEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::is_signaling_nan() const")]
internal static partial class fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan_const
{
	public unsafe static bool Invoke(fputil_internal_FPRepSem_fq8nhg* @this)
	{
		return fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan_const.Invoke(@this) ? (unchecked((byte)((fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_quiet_nan_const.Invoke(@this) ? 1u : 0u) ^ 0xFFFFFFFFu)) != 0) : false;
	}
}
