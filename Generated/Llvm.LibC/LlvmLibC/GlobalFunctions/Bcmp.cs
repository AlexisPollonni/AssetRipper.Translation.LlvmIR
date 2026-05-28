using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Bcmp
{
	[MangledName("bcmp")]
	[DemangledName("bcmp")]
	public unsafe static int Invoke([MangledName("lhs")] void* Lhs, [MangledName("rhs")] void* Rhs, [MangledName("count")] long Count)
	{
		return Inline_bcmp.Invoke(Lhs, Rhs, Count);
	}
}
