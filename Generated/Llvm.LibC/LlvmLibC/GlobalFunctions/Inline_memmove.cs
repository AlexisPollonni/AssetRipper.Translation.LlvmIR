using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Inline_memmove
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14inline_memmoveEPvPKvm")]
	[DemangledName("__llvm_libc_20_1_2_::inline_memmove(void*, void const*, unsigned long)")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("void*")] void* Dst, [MangledName("src")][NativeType("void const*")] void* Src, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		if (!Inline_memmove_small_size.Invoke(Dst, Src, Count))
		{
			Inline_memmove_follow_up.Invoke(Dst, Src, Count);
		}
	}
}
