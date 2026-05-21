using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Dmull
{
	[MangledName("dmull")]
	[DemangledName("dmull")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_mul_double_long_double.Invoke(X, Y);
	}
}
