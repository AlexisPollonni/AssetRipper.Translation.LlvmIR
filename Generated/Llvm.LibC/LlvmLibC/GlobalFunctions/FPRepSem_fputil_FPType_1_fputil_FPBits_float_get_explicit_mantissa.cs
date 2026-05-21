using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_1_fputil_FPBits_float_get_explicit_mantissa
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE1ENS0_6FPBitsIfEEE21get_explicit_mantissaEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)1, __llvm_libc_20_1_2_::fputil::FPBits<float>>::get_explicit_mantissa() const")]
	public unsafe static int Invoke([MangledName("this")] void* This)
	{
		if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_subnormal.Invoke(This))
		{
			return FPStorage_fputil_FPType_1_sig_bits.Invoke(This);
		}
		return 0x800000 | FPStorage_fputil_FPType_1_sig_bits.Invoke(This);
	}
}
