using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Dmulf128
{
	[MangledName("dmulf128")]
	[DemangledName("dmulf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_mul_double_float128.Invoke(X, Y);
	}
}
