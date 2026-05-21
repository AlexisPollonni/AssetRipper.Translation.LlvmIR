using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fminimum_magf
{
	[MangledName("fminimum_magf")]
	[DemangledName("fminimum_magf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("y")] float Y)
	{
		return Fputil_fminimum_mag_float_0.Invoke(X, Y);
	}
}
