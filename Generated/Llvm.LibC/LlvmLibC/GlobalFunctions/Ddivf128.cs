using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ddivf128
{
	[MangledName("ddivf128")]
	[DemangledName("ddivf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_div_double_float128.Invoke(X, Y);
	}
}
