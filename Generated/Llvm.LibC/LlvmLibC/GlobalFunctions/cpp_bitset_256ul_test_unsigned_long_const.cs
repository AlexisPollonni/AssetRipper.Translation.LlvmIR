using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp6bitsetILm256EE4testEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::bitset<256ul>::test(unsigned long) const")]
internal static partial class cpp_bitset_256ul_test_unsigned_long_const
{
	public unsafe static bool Invoke(void* @this, long Index)
	{
		return (unchecked(((long*)(&((cpp_array_jgy3xh*)@this)->Data))[(ulong)Index / 64uL]) & cpp_bitset_256ul_mask_unsigned_long.Invoke(Index)) != 0L;
	}
}
