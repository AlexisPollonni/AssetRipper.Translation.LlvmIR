using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Hypot
{
	[MangledName("hypot")]
	[DemangledName("hypot")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_hypot_double_0.Invoke(X, Y);
	}
}
