using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_signaling_nan
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE1ENS0_6FPBitsIfEEE16is_signaling_nanEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>::is_signaling_nan() const")]
	public unsafe static bool Invoke([MangledName("this")] void* This)
	{
		return FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(This) && InstructionHelper.BooleanXor(FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_quiet_nan.Invoke(This), right: true);
	}
}
