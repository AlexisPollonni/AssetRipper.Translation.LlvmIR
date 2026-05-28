using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_abs
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEE3absEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::abs() const")]
	public unsafe static short Invoke([MangledName("this")] Fputil_internal_FPRepImpl_7z3gh9* This)
	{
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva, unchecked((short)((ushort)((Fputil_internal_FPStorage_za9n4f*)This)->field_0 & 0x7FFF)));
		return fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0;
	}
}
