using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AuxvFdGuard_valid
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_11AuxvFdGuard5validEv")]
	[DemangledName("__llvm_libc_20_1_2_::AuxvFdGuard::valid() const")]
	public unsafe static bool Invoke([MangledName("this")] void* This)
	{
		return unchecked((Llvm_libc_20_1_2_fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)This)->field_0 != -1;
	}
}
