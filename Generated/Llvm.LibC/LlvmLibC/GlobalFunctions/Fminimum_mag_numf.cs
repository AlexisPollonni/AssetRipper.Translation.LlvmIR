using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fminimum_mag_numf
{
	[MangledName("fminimum_mag_numf")]
	[DemangledName("fminimum_mag_numf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("y")] float Y)
	{
		return Fputil_fminimum_mag_num_float_0.Invoke(X, Y);
	}
}
