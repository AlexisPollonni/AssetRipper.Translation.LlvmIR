using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memcpy
{
	[MangledName("memcpy")]
	[DemangledName("memcpy")]
	public unsafe static void* Invoke([MangledName("dst")] void* Dst, [MangledName("src")] void* Src, [MangledName("size")] long Size)
	{
		Inline_memcpy.Invoke(Dst, Src, Size);
		return Dst;
	}
}
