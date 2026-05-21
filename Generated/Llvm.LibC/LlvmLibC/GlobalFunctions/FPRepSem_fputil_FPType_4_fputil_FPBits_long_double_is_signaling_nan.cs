using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_signaling_nan
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE4ENS0_6FPBitsIeEEE16is_signaling_nanEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::is_signaling_nan() const")]
	public unsafe static bool Invoke(void* @this)
	{
		return FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_nan.Invoke(@this) ? (unchecked((byte)((FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_quiet_nan.Invoke(@this) ? 1u : 0u) ^ 0xFFFFFFFFu)) != 0) : false;
	}
}
