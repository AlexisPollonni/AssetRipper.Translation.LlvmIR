using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6bitsetILm256EE4maskEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::bitset<256ul>::mask(unsigned long)")]
internal static partial class cpp_bitset_256ul_mask_unsigned_long
{
	public static long Invoke(long Index)
	{
		return 1L << unchecked((int)((ulong)Index % 64uL));
	}
}
