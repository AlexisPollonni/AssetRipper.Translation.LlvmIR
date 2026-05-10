using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE1ENS0_6FPBitsIfEEE21get_explicit_mantissaEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>::get_explicit_mantissa() const")]
internal static partial class fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa_const
{
	public unsafe static int Invoke(void* @this)
	{
		if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_subnormal_const.Invoke(@this))
		{
			return fputil_internal_FPStorage_fputil_FPType_1_sig_bits_const.Invoke(@this);
		}
		return 0x800000 | fputil_internal_FPStorage_fputil_FPType_1_sig_bits_const.Invoke(@this);
	}
}
