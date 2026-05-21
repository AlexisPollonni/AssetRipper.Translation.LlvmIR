using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_2_sig_bits
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE2EE8sig_bitsEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)2>::sig_bits() const")]
	public unsafe static long Invoke([MangledName("this")] void* This)
	{
		return unchecked((Llvm_libc_20_1_2_fputil_internal_FPStorage_v3nexn*)This)->Val & 0xFFFFFFFFFFFFFL;
	}
}
