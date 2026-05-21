using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fminimuml
{
	[MangledName("fminimuml")]
	[DemangledName("fminimuml")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fminimum_long_double_0.Invoke(X, Y);
	}
}
