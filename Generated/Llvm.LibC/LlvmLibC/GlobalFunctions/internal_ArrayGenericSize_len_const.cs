using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_8internal16ArrayGenericSize3lenEv")]
[DemangledName("__llvm_libc_20_1_2_::internal::ArrayGenericSize::len() const")]
internal static partial class internal_ArrayGenericSize_len_const
{
	public unsafe static long Invoke(void* @this)
	{
		return unchecked((scanf_core_ReadBuffer*)@this)->buff_len;
	}
}
