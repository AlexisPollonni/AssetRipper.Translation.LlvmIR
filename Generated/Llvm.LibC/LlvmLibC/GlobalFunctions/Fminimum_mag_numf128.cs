using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fminimum_mag_numf128
{
	[MangledName("fminimum_mag_numf128")]
	[DemangledName("fminimum_mag_numf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fminimum_mag_num_float128_0.Invoke(X, Y);
	}
}
