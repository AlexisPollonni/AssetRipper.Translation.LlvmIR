using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_uintval
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEE7uintvalEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::uintval() const")]
	public unsafe static short Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9* This)
	{
		return unchecked((short)((ushort)((Llvm_libc_20_1_2_fputil_internal_FPStorage_za9n4f*)This)->field_0 & 0xFFFF));
	}
}
