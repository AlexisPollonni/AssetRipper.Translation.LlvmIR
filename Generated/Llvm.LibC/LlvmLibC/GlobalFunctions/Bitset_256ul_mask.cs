using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Bitset_256ul_mask
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6bitsetILm256EE4maskEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::bitset<256ul>::mask(unsigned long)")]
	public static long Invoke([NativeType("unsigned long")] long Index)
	{
		return 1L << unchecked((int)((ulong)Index % 64uL));
	}
}
