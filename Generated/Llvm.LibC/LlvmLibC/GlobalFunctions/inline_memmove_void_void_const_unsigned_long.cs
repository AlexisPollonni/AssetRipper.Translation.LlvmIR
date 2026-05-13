using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14inline_memmoveEPvPKvm")]
[DemangledName("__llvm_libc_20_1_2_::inline_memmove(void*, void const*, unsigned long)")]
internal static partial class inline_memmove_void_void_const_unsigned_long
{
	public unsafe static void Invoke(void* dst, void* src, long count)
	{
		if (!inline_memmove_small_size_void_void_const_unsigned_long.Invoke(dst, src, count))
		{
			inline_memmove_follow_up_void_void_const_unsigned_long.Invoke(dst, src, count);
		}
	}
}
