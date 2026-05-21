using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class bitset_256ul_set
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6bitsetILm256EE3setEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::bitset<256ul>::set(unsigned long)")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned long")] long Index)
	{
		long num = bitset_256ul_mask.Invoke(Index);
		unchecked(((long*)(&((cpp_array_jgy3xh*)@this)->Data))[(ulong)Index / 64uL]) |= num;
	}
}
