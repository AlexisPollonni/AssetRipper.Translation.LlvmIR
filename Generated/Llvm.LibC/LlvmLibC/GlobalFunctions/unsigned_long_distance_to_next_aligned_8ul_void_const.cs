using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_24distance_to_next_alignedILm8EEEmPKv")]
[DemangledName("unsigned long __llvm_libc_20_1_2_::distance_to_next_aligned<8ul>(void const*)")]
internal static partial class unsigned_long_distance_to_next_aligned_8ul_void_const
{
	public unsafe static long Invoke(void* ptr)
	{
		return unchecked(8L - unsigned_long_distance_to_align_down_8ul_void_const.Invoke(ptr));
	}
}
