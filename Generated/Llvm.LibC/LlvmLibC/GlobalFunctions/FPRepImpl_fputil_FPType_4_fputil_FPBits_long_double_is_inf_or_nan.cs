using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE4ENS0_6FPBitsIeEEE13is_inf_or_nanEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::is_inf_or_nan() const")]
	public unsafe static bool Invoke([MangledName("this")] void* This)
	{
		return InstructionHelper.BooleanXor(FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_finite.Invoke(This), right: true);
	}
}
