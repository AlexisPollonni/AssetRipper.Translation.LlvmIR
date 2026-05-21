using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memmove
{
	[MangledName("memmove")]
	[DemangledName("memmove")]
	public unsafe static void* Invoke([MangledName("dst")] void* Dst, [MangledName("src")] void* Src, [MangledName("count")] long Count)
	{
		if (Llvm_libc_20_1_2_inline_memmove_small_size.Invoke(Dst, Src, Count))
		{
			return Dst;
		}
		if (Llvm_libc_20_1_2_is_disjoint.Invoke(Dst, Src, Count))
		{
			Llvm_libc_20_1_2_inline_memcpy.Invoke(Dst, Src, Count);
		}
		else
		{
			Llvm_libc_20_1_2_inline_memmove_follow_up.Invoke(Dst, Src, Count);
		}
		return Dst;
	}
}
