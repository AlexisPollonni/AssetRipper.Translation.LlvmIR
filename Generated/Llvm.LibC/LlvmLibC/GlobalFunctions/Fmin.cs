using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmin
{
	[MangledName("fmin")]
	[DemangledName("fmin")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fmin_double_0.Invoke(X, Y);
	}
}
