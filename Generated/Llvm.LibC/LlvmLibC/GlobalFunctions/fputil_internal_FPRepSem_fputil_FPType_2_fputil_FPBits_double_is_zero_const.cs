using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE2ENS0_6FPBitsIdEEE7is_zeroEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::is_zero() const")]
internal static partial class fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero_const
{
	public unsafe static bool Invoke(void* @this)
	{
		return fputil_internal_FPStorage_fputil_FPType_2_exp_sig_bits_const.Invoke(@this) == 0L;
	}
}
