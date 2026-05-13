using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_8internal16ArrayGenericSize12get_internalEm")]
[DemangledName("__llvm_libc_20_1_2_::internal::ArrayGenericSize::get_internal(unsigned long) const")]
internal static partial class internal_ArrayGenericSize_get_internal_unsigned_long_const
{
	public unsafe static void* Invoke(void* @this, long i)
	{
		return unchecked((byte*)((scanf_core_ReadBuffer*)@this)->buffer + i * ((scanf_core_ReadBuffer*)@this)->buff_cur);
	}
}
