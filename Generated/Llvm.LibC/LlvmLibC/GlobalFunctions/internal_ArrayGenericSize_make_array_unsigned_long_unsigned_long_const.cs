using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_8internal16ArrayGenericSize10make_arrayEmm")]
[DemangledName("__llvm_libc_20_1_2_::internal::ArrayGenericSize::make_array(unsigned long, unsigned long) const")]
internal static partial class internal_ArrayGenericSize_make_array_unsigned_long_unsigned_long_const
{
	public unsafe static void Invoke([MangledName("agg.result")] scanf_core_ReadBuffer* agg_result, void* @this, long i, long s)
	{
		internal_ArrayGenericSize_ArrayGenericSize_void_unsigned_long_unsigned_long.Invoke(agg_result, internal_ArrayGenericSize_get_internal_unsigned_long_const.Invoke(@this, i), s, unchecked((scanf_core_ReadBuffer*)@this)->buff_cur);
	}
}
