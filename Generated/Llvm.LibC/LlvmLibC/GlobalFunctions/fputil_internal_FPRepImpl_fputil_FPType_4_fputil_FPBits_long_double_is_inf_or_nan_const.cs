using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE4ENS0_6FPBitsIeEEE13is_inf_or_nanEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)4, __llvm_libc_20_1_2_::fputil::FPBits<long double>>::is_inf_or_nan() const")]
internal static partial class fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_is_inf_or_nan_const
{
	public unsafe static bool Invoke(void* @this)
	{
		return unchecked((byte)((fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_finite_const.Invoke(@this) ? 1u : 0u) ^ 0xFFFFFFFFu)) != 0;
	}
}
