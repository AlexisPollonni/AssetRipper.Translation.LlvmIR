using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaximum
{
	[MangledName("fmaximum")]
	[DemangledName("fmaximum")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fmaximum_double_0.Invoke(X, Y);
	}
}
