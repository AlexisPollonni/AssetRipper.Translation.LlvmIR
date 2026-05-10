using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEE7is_zeroEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::is_zero() const")]
internal static partial class fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_zero_const
{
	public unsafe static bool Invoke(void* @this)
	{
		return unchecked((ushort)fputil_internal_FPStorage_fputil_FPType_0_exp_sig_bits_const.Invoke(@this)) == 0;
	}
}
