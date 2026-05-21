using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fminimumf
{
	[MangledName("fminimumf")]
	[DemangledName("fminimumf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("y")] float Y)
	{
		return Fputil_fminimum_float_0.Invoke(X, Y);
	}
}
