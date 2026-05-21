using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_0_exp_sig_bits
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE0EE12exp_sig_bitsEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)0>::exp_sig_bits() const")]
	public unsafe static short Invoke(void* @this)
	{
		return unchecked((short)((ushort)((fputil_internal_FPStorage_za9n4f*)@this)->field_0 & 0x7FFF));
	}
}
