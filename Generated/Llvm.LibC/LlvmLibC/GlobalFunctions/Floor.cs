using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Floor
{
	[MangledName("floor")]
	[DemangledName("floor")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_floor_double_0.Invoke(X);
	}
}
