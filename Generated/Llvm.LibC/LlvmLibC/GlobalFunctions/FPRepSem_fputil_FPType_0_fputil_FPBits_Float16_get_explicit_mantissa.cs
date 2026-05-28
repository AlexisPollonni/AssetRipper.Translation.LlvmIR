using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_get_explicit_mantissa
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal8FPRepSemILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEE21get_explicit_mantissaEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepSem<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::get_explicit_mantissa() const")]
	public unsafe static short Invoke([MangledName("this")] Fputil_internal_FPRepSem_i7nz4h* This)
	{
		if (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_subnormal.Invoke(This))
		{
			return FPStorage_fputil_FPType_0_sig_bits.Invoke(This);
		}
		return unchecked((short)(0x400 | (ushort)FPStorage_fputil_FPType_0_sig_bits.Invoke(This)));
	}
}
