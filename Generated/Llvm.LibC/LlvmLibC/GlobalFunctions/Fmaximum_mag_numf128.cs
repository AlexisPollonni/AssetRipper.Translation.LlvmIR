using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaximum_mag_numf128
{
	[MangledName("fmaximum_mag_numf128")]
	[DemangledName("fmaximum_mag_numf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fmaximum_mag_num_float128_0.Invoke(X, Y);
	}
}
