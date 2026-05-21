using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strcspn
{
	[MangledName("strcspn")]
	[DemangledName("strcspn")]
	public unsafe static long Invoke([MangledName("src")] void* Src, [MangledName("segment")] void* Segment)
	{
		return Internal_complementary_span.Invoke(Src, Segment);
	}
}
