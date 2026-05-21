using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE2ENS0_6FPBitsIdEEE21get_explicit_mantissaEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)2, __llvm_libc_20_1_2_::fputil::FPBits<double>>::get_explicit_mantissa() const")]
	public unsafe static long Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg* This)
	{
		if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_subnormal.Invoke(This))
		{
			return FPStorage_fputil_FPType_2_sig_bits.Invoke(This);
		}
		return 0x10000000000000L | FPStorage_fputil_FPType_2_sig_bits.Invoke(This);
	}
}
