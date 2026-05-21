using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayGenericSize_make_array
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_8internal16ArrayGenericSize10make_arrayEmm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayGenericSize::make_array(unsigned long, unsigned long) const")]
	public unsafe static void Invoke([MangledName("agg.result")] scanf_core_ReadBuffer* agg_result, void* @this, long i, long s)
	{
		ArrayGenericSize_Constructor.Invoke(agg_result, ArrayGenericSize_get_internal.Invoke(@this, i), s, unchecked((scanf_core_ReadBuffer*)@this)->buff_cur);
	}
}
