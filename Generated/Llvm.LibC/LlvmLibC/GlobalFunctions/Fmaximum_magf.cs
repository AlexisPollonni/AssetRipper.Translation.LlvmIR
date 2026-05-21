using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaximum_magf
{
	[MangledName("fmaximum_magf")]
	[DemangledName("fmaximum_magf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("y")] float Y)
	{
		return Fputil_fmaximum_mag_float_0.Invoke(X, Y);
	}
}
