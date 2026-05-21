using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Absr
{
	[MangledName("absr")]
	[DemangledName("absr")]
	public static short Invoke([MangledName("x")] short X)
	{
		return Fixed_point_abs_Fract.Invoke(X);
	}
}
