using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fminimum_mag
{
	[MangledName("fminimum_mag")]
	[DemangledName("fminimum_mag")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fminimum_mag_double_0.Invoke(X, Y);
	}
}
