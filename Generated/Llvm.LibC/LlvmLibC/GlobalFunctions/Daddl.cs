using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Daddl
{
	[MangledName("daddl")]
	[DemangledName("daddl")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_add_double_long_double.Invoke(X, Y);
	}
}
