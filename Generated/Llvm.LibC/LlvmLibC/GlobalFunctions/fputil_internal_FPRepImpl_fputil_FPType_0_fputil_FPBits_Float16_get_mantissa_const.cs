using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPRepImplILNS0_6FPTypeE0ENS0_6FPBitsIDF16_EEE12get_mantissaEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPRepImpl<(__llvm_libc_20_1_2_::fputil::FPType)0, __llvm_libc_20_1_2_::fputil::FPBits<_Float16>>::get_mantissa() const")]
internal static partial class fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa_const
{
	public unsafe static short Invoke(fputil_internal_FPRepImpl_7z3gh9* @this)
	{
		return unchecked((short)((ushort)((fputil_internal_FPStorage_za9n4f*)@this)->field_0 & 0x3FF));
	}
}
