using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Inline_memset_t7nzzw
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L13inline_memsetEPvhm.204")]
	[DemangledName("__llvm_libc_20_1_2_::inline_memset(void*, unsigned char, unsigned long) (.204)")]
	[CleanName("Inline_memset")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("void*")] void* Dst, [MangledName("value")][NativeType("unsigned char")] sbyte Value, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		Inline_memset_x86_2p7qxy.Invoke(Dst, Value, Count);
	}
}
