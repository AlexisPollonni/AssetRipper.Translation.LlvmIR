using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fdivl
{
	[MangledName("fdivl")]
	[DemangledName("fdivl")]
	public static float Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_div_float_long_double.Invoke(X, Y);
	}
}
