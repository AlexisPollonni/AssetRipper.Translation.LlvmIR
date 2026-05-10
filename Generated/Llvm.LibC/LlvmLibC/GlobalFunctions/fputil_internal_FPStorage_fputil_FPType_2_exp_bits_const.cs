using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE8exp_bitsEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::exp_bits() const")]
internal static partial class fputil_internal_FPStorage_fputil_FPType_2_exp_bits_const
{
	public unsafe static long Invoke(void* @this)
	{
		return unchecked((fputil_internal_FPStorage_v3nexn*)@this)->val & 0x7FF0000000000000L;
	}
}
