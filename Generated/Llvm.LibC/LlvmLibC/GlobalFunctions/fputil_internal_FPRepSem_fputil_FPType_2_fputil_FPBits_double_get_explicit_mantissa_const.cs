using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE2ENS0_6FPBitsIdEEE21get_explicit_mantissaEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::get_explicit_mantissa() const")]
internal static partial class fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa_const
{
	public unsafe static long Invoke(fputil_internal_FPRepSem_fq8nhg* @this)
	{
		if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_subnormal_const.Invoke(@this))
		{
			return fputil_internal_FPStorage_fputil_FPType_2_sig_bits_const.Invoke(@this);
		}
		return 0x10000000000000L | fputil_internal_FPStorage_fputil_FPType_2_sig_bits_const.Invoke(@this);
	}
}
