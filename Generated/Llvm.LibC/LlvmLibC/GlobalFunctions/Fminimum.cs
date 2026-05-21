using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fminimum
{
	[MangledName("fminimum")]
	[DemangledName("fminimum")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fminimum_double_0.Invoke(X, Y);
	}
}
