using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEE21get_explicit_mantissaEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::get_explicit_mantissa() const")]
internal static partial class fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_get_explicit_mantissa_const
{
	public unsafe static short Invoke(void* @this)
	{
		if (fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_subnormal_const.Invoke(@this))
		{
			return fputil_internal_FPStorage_fputil_FPType_0_sig_bits_const.Invoke(@this);
		}
		return unchecked((short)(0x400 | (ushort)fputil_internal_FPStorage_fputil_FPType_0_sig_bits_const.Invoke(@this)));
	}
}
