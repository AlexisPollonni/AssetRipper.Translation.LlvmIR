using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmul
{
	[MangledName("fmul")]
	[DemangledName("fmul")]
	public static float Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_mul_float_double.Invoke(X, Y);
	}
}
