using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmax
{
	[MangledName("fmax")]
	[DemangledName("fmax")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fmax_double_0.Invoke(X, Y);
	}
}
