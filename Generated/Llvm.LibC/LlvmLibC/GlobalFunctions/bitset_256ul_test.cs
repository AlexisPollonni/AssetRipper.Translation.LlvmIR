using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class bitset_256ul_test
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp6bitsetILm256EE4testEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::bitset<256ul>::test(unsigned long) const")]
	public unsafe static bool Invoke(void* @this, [NativeType("unsigned long")] long Index)
	{
		return (unchecked(((long*)(&((cpp_array_jgy3xh*)@this)->Data))[(ulong)Index / 64uL]) & bitset_256ul_mask.Invoke(Index)) != 0L;
	}
}
