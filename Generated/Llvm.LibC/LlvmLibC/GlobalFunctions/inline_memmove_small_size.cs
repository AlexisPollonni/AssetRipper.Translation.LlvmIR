using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class inline_memmove_small_size
{
	[MangledName("_ZN19__llvm_libc_20_1_2_25inline_memmove_small_sizeEPvPKvm")]
	[DemangledName("__llvm_libc_20_1_2_::inline_memmove_small_size(void*, void const*, unsigned long)")]
	public unsafe static bool Invoke([NativeType("void*")] void* dst, [NativeType("void const*")] void* src, [NativeType("unsigned long")] long count)
	{
		return inline_memmove_small_size_x86.Invoke(dst, src, count);
	}
}
