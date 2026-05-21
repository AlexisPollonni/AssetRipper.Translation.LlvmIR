using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Faddl
{
	[MangledName("faddl")]
	[DemangledName("faddl")]
	public static float Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_add_float_long_double.Invoke(X, Y);
	}
}
