using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_22distance_to_align_downILm32EEEmPKv")]
[DemangledName("unsigned long __llvm_libc_20_1_2_::distance_to_align_down<32ul>(void const*)")]
internal static partial class unsigned_long_distance_to_align_down_32ul_void_const
{
	public unsafe static long Invoke(void* ptr)
	{
		return unchecked((long)ptr) & 0x1FL;
	}
}
