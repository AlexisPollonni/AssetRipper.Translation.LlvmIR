using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_inline_memset_v4bwdv
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L13inline_memsetEPvhm.185")]
	[DemangledName("__llvm_libc_20_1_2_::inline_memset(void*, unsigned char, unsigned long) (.185)")]
	[CleanName("Llvm_libc_20_1_2_inline_memset")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("void*")] void* Dst, [MangledName("value")][NativeType("unsigned char")] sbyte Value, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		Llvm_libc_20_1_2_inline_memset_x86_8at9td.Invoke(Dst, Value, Count);
	}
}
