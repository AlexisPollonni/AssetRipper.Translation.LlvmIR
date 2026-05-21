using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_distance_to_next_aligned_8ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_24distance_to_next_alignedILm8EEEmPKv")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::distance_to_next_aligned<8ul>(void const*)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([MangledName("ptr")][NativeType("void const*")] void* Ptr)
	{
		return unchecked(8L - Llvm_libc_20_1_2_distance_to_align_down_8ul.Invoke(Ptr));
	}
}
