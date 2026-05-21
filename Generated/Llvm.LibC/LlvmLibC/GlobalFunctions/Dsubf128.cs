using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Dsubf128
{
	[MangledName("dsubf128")]
	[DemangledName("dsubf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_sub_double_float128.Invoke(X, Y);
	}
}
