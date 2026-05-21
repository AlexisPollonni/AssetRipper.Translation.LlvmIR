using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaximuml
{
	[MangledName("fmaximuml")]
	[DemangledName("fmaximuml")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fmaximum_long_double_0.Invoke(X, Y);
	}
}
