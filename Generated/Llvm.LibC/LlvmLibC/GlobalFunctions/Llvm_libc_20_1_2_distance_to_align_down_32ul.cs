using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_distance_to_align_down_32ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_22distance_to_align_downILm32EEEmPKv")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::distance_to_align_down<32ul>(void const*)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([MangledName("ptr")][NativeType("void const*")] void* Ptr)
	{
		return unchecked((long)Ptr) & 0x1FL;
	}
}
