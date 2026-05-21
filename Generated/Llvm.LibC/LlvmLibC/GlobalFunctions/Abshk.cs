using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Abshk
{
	[MangledName("abshk")]
	[DemangledName("abshk")]
	public static short Invoke([MangledName("x")] short X)
	{
		return Fixed_point_abs_short_Accum.Invoke(X);
	}
}
