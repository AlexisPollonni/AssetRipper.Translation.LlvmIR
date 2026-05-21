using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_3_fputil_FPBits_float128_is_inf_or_nan
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE3ENS0_6FPBitsIgEEE13is_inf_or_nanEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)3, __llvm_libc_20_1_2_::fputil::FPBits<__float128>>::is_inf_or_nan() const")]
	public unsafe static bool Invoke([MangledName("this")] void* This)
	{
		return unchecked((byte)((FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_finite.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)This) ? 1u : 0u) ^ 0xFFFFFFFFu)) != 0;
	}
}
