using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class inline_memmove_follow_up
{
	[MangledName("_ZN19__llvm_libc_20_1_2_24inline_memmove_follow_upEPvPKvm")]
	[DemangledName("__llvm_libc_20_1_2_::inline_memmove_follow_up(void*, void const*, unsigned long)")]
	public unsafe static void Invoke([NativeType("void*")] void* dst, [NativeType("void const*")] void* src, [NativeType("unsigned long")] long count)
	{
		inline_memmove_follow_up_x86.Invoke(dst, src, count);
	}
}
