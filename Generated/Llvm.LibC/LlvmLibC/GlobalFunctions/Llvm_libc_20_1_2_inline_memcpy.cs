using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_inline_memcpy
{
	[MangledName("_ZN19__llvm_libc_20_1_2_13inline_memcpyEPvPKvm")]
	[DemangledName("__llvm_libc_20_1_2_::inline_memcpy(void*, void const*, unsigned long)")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("void*")] void* Dst, [MangledName("src")][NativeType("void const*")] void* Src, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		Llvm_libc_20_1_2_inline_memcpy_x86_maybe_interpose_repmovsb.Invoke(Dst, Src, Count);
	}
}
