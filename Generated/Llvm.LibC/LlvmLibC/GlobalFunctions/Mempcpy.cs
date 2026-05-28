using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Mempcpy
{
	public unsafe static readonly void* __pointer = (delegate*<void*, void*, long, void*>)(&Invoke);

	[MangledName("mempcpy")]
	[DemangledName("mempcpy")]
	public unsafe static void* Invoke([MangledName("dst")] void* Dst, [MangledName("src")] void* Src, [MangledName("count")] long Count)
	{
		Inline_memcpy.Invoke(Dst, Src, Count);
		return unchecked((byte*)Dst) + Count;
	}
}
