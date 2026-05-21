using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_inline_bzero_vdhkgh
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L12inline_bzeroEPvm")]
	[DemangledName("__llvm_libc_20_1_2_::inline_bzero(void*, unsigned long)")]
	[CleanName("Llvm_libc_20_1_2_inline_bzero")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("void*")] void* Dst, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		Llvm_libc_20_1_2_inline_bzero_ak295j.Invoke(Dst, Count);
	}
}
