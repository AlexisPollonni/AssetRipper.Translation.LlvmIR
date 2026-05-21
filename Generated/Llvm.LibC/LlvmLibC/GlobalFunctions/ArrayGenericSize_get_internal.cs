using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayGenericSize_get_internal
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_8internal16ArrayGenericSize12get_internalEm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayGenericSize::get_internal(unsigned long) const")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned long")] long i)
	{
		return unchecked((byte*)((scanf_core_ReadBuffer*)@this)->buffer + i * ((scanf_core_ReadBuffer*)@this)->buff_cur);
	}
}
