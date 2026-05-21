using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fdivf128
{
	[MangledName("fdivf128")]
	[DemangledName("fdivf128")]
	public static float Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_div_float_float128.Invoke(X, Y);
	}
}
