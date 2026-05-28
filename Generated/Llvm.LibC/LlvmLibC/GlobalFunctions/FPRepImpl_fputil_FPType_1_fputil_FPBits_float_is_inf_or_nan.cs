using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE1ENS0_6FPBitsIfEEE13is_inf_or_nanEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>::is_inf_or_nan() const")]
	public unsafe static bool Invoke([MangledName("this")] Fputil_internal_FPRepImpl_vhj4tm* This)
	{
		return InstructionHelper.BooleanXor(FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_finite.Invoke(This), right: true);
	}
}
