using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Inline_memset_n6zrms
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L13inline_memsetEPvhm.163")]
	[DemangledName("__llvm_libc_20_1_2_::inline_memset(void*, unsigned char, unsigned long) (.163)")]
	[CleanName("Inline_memset")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("void*")] void* Dst, [MangledName("value")][NativeType("unsigned char")] sbyte Value, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		Inline_memset_x86_n8av5f.Invoke(Dst, Value, Count);
	}
}
