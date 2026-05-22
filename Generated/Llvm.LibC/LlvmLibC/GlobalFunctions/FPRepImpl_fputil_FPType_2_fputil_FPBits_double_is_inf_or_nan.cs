using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE2ENS0_6FPBitsIdEEE13is_inf_or_nanEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::is_inf_or_nan() const")]
	public unsafe static bool Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq* This)
	{
		return InstructionHelper.BooleanXor(FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_finite.Invoke(unchecked((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)This)), right: true);
	}
}
