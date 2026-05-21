using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayGenericSize_make_array
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_8internal16ArrayGenericSize10make_arrayEmm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayGenericSize::make_array(unsigned long, unsigned long) const")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_scanf_core_ReadBuffer* Agg_result, [MangledName("this")] void* This, [MangledName("i")] long I, [MangledName("s")] long S)
	{
		ArrayGenericSize_Constructor.Invoke(Agg_result, ArrayGenericSize_get_internal.Invoke(This, I), S, unchecked((Llvm_libc_20_1_2_scanf_core_ReadBuffer*)This)->Buff_cur);
	}
}
