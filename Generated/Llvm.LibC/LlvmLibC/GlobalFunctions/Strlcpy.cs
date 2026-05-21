using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strlcpy
{
	[MangledName("strlcpy")]
	[DemangledName("strlcpy")]
	public unsafe static long Invoke([MangledName("dst")] void* Dst, [MangledName("src")] void* Src, [MangledName("size")] long Size)
	{
		return Internal_strlcpy.Invoke(Dst, Src, Size);
	}
}
