using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE2ENS0_6FPBitsIdEEE16is_signaling_nanEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::is_signaling_nan() const")]
	public unsafe static bool Invoke([MangledName("this")] Fputil_internal_FPRepSem_fq8nhg* This)
	{
		return FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke(This) && InstructionHelper.BooleanXor(FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_quiet_nan.Invoke(This), right: true);
	}
}
