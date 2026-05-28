using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memset
{
	[MangledName("memset")]
	[DemangledName("memset")]
	public unsafe static void* Invoke([MangledName("dst")] void* Dst, [MangledName("value")] int Value, [MangledName("count")] long Count)
	{
		Inline_memset_achmsp.Invoke(Dst, unchecked((sbyte)Value), Count);
		return Dst;
	}
}
