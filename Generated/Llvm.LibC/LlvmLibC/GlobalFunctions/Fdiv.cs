using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fdiv
{
	[MangledName("fdiv")]
	[DemangledName("fdiv")]
	public static float Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_div_float_double.Invoke(X, Y);
	}
}
