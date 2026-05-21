using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ddivl
{
	[MangledName("ddivl")]
	[DemangledName("ddivl")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_div_double_long_double.Invoke(X, Y);
	}
}
