using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmull
{
	[MangledName("fmull")]
	[DemangledName("fmull")]
	public static float Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_mul_float_long_double.Invoke(X, Y);
	}
}
