using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_11AuxvFdGuard5validEv")]
[DemangledName("__llvm_libc_20_1_2_::AuxvFdGuard::valid() const")]
internal static partial class AuxvFdGuard_valid_const
{
	public unsafe static bool Invoke(void* @this)
	{
		return unchecked((fputil_internal_FPStorage_fputil_FPType_IEEE754_Binary128_TypedInt*)@this)->field_0 != -1;
	}
}
