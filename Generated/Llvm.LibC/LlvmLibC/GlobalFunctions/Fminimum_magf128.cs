using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fminimum_magf128
{
	[MangledName("fminimum_magf128")]
	[DemangledName("fminimum_magf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fminimum_mag_float128_0.Invoke(X, Y);
	}
}
