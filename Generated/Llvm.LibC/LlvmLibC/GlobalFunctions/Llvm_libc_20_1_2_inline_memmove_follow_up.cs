using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_inline_memmove_follow_up
{
	[MangledName("_ZN19__llvm_libc_20_1_2_24inline_memmove_follow_upEPvPKvm")]
	[DemangledName("__llvm_libc_20_1_2_::inline_memmove_follow_up(void*, void const*, unsigned long)")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("void*")] void* Dst, [MangledName("src")][NativeType("void const*")] void* Src, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		Llvm_libc_20_1_2_inline_memmove_follow_up_x86.Invoke(Dst, Src, Count);
	}
}
