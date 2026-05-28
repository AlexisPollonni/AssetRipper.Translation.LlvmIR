using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FPStorage_fputil_FPType_1_exp_bits
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil8internal9FPStorageILNS0_6FPTypeE1EE8exp_bitsEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage<(__llvm_libc_20_1_2_::fputil::FPType)1>::exp_bits() const")]
	public unsafe static int Invoke([MangledName("this")] void* This)
	{
		return unchecked((Fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)This)->field_0 & 0x7F800000;
	}
}
