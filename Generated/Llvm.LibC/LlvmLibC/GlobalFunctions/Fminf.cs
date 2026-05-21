using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fminf
{
	[MangledName("fminf")]
	[DemangledName("fminf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("y")] float Y)
	{
		return Fputil_fmin_float_0.Invoke(X, Y);
	}
}
