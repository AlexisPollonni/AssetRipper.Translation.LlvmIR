using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fminimum_magl
{
	[MangledName("fminimum_magl")]
	[DemangledName("fminimum_magl")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fminimum_mag_long_double_0.Invoke(X, Y);
	}
}
