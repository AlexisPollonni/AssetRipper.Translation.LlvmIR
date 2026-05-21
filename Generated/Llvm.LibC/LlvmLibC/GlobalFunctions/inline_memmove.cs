using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class inline_memmove
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14inline_memmoveEPvPKvm")]
	[DemangledName("__llvm_libc_20_1_2_::inline_memmove(void*, void const*, unsigned long)")]
	public unsafe static void Invoke([NativeType("void*")] void* dst, [NativeType("void const*")] void* src, [NativeType("unsigned long")] long count)
	{
		if (!inline_memmove_small_size.Invoke(dst, src, count))
		{
			inline_memmove_follow_up.Invoke(dst, src, count);
		}
	}
}
