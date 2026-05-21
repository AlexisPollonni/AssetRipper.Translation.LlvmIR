using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_signaling_nan
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEE16is_signaling_nanEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::is_signaling_nan() const")]
	public unsafe static bool Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_internal_FPRepSem_i7nz4h* This)
	{
		return FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_nan.Invoke(This) ? (unchecked((byte)((FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_quiet_nan.Invoke(This) ? 1u : 0u) ^ 0xFFFFFFFFu)) != 0) : false;
	}
}
