using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaximum_mag
{
	[MangledName("fmaximum_mag")]
	[DemangledName("fmaximum_mag")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fmaximum_mag_double_0.Invoke(X, Y);
	}
}
