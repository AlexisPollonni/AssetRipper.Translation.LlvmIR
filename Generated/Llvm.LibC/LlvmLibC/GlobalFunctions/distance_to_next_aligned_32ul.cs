using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class distance_to_next_aligned_32ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_24distance_to_next_alignedILm32EEEmPKv")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::distance_to_next_aligned<32ul>(void const*)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([NativeType("void const*")] void* ptr)
	{
		return unchecked(32L - distance_to_align_down_32ul.Invoke(ptr));
	}
}
