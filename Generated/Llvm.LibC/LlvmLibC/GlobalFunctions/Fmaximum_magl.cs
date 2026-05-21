using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaximum_magl
{
	[MangledName("fmaximum_magl")]
	[DemangledName("fmaximum_magl")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fmaximum_mag_long_double_0.Invoke(X, Y);
	}
}
