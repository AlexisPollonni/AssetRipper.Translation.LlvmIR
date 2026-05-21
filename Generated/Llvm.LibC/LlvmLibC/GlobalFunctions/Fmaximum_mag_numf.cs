using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaximum_mag_numf
{
	[MangledName("fmaximum_mag_numf")]
	[DemangledName("fmaximum_mag_numf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("y")] float Y)
	{
		return Fputil_fmaximum_mag_num_float_0.Invoke(X, Y);
	}
}
