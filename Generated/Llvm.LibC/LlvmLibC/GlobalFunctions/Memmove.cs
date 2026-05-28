using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memmove
{
	[MangledName("memmove")]
	[DemangledName("memmove")]
	public unsafe static void* Invoke([MangledName("dst")] void* Dst, [MangledName("src")] void* Src, [MangledName("count")] long Count)
	{
		if (Inline_memmove_small_size.Invoke(Dst, Src, Count))
		{
			return Dst;
		}
		if (Is_disjoint.Invoke(Dst, Src, Count))
		{
			Inline_memcpy.Invoke(Dst, Src, Count);
		}
		else
		{
			Inline_memmove_follow_up.Invoke(Dst, Src, Count);
		}
		return Dst;
	}
}
