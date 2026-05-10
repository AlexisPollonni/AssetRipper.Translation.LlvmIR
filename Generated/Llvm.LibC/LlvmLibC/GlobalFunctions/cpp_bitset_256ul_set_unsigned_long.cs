using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp6bitsetILm256EE3setEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::bitset<256ul>::set(unsigned long)")]
internal static partial class cpp_bitset_256ul_set_unsigned_long
{
	public unsafe static void Invoke(void* @this, long Index)
	{
		long num = cpp_bitset_256ul_mask_unsigned_long.Invoke(Index);
		unchecked(((long*)(&((cpp_array_jgy3xh*)@this)->Data))[(ulong)Index / 64uL]) |= num;
	}
}
