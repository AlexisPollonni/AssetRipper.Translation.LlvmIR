using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class AuxvFdGuard_get
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_11AuxvFdGuard3getEv")]
	[DemangledName("__llvm_libc_20_1_2_::AuxvFdGuard::get() const")]
	public unsafe static int Invoke(void* @this)
	{
		return unchecked((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0;
	}
}
