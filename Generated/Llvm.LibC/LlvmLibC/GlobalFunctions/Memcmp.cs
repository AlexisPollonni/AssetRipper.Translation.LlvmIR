using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memcmp
{
	[MangledName("memcmp")]
	[DemangledName("memcmp")]
	public unsafe static int Invoke([MangledName("lhs")] void* Lhs, [MangledName("rhs")] void* Rhs, [MangledName("count")] long Count)
	{
		return Inline_memcmp.Invoke(Lhs, Rhs, Count);
	}
}
