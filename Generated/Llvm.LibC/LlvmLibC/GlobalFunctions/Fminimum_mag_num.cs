using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fminimum_mag_num
{
	[MangledName("fminimum_mag_num")]
	[DemangledName("fminimum_mag_num")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fminimum_mag_num_double_0.Invoke(X, Y);
	}
}
