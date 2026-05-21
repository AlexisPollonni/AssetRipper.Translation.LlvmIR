using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaximum_mag_numl
{
	[MangledName("fmaximum_mag_numl")]
	[DemangledName("fmaximum_mag_numl")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fmaximum_mag_num_long_double_0.Invoke(X, Y);
	}
}
