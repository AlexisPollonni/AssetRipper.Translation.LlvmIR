using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_inline_memmove_small_size
{
	[MangledName("_ZN19__llvm_libc_20_1_2_25inline_memmove_small_sizeEPvPKvm")]
	[DemangledName("__llvm_libc_20_1_2_::inline_memmove_small_size(void*, void const*, unsigned long)")]
	public unsafe static bool Invoke([MangledName("dst")][NativeType("void*")] void* Dst, [MangledName("src")][NativeType("void const*")] void* Src, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		return Llvm_libc_20_1_2_inline_memmove_small_size_x86.Invoke(Dst, Src, Count);
	}
}
