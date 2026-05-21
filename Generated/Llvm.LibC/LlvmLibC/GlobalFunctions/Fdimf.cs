using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fdimf
{
	[MangledName("fdimf")]
	[DemangledName("fdimf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("y")] float Y)
	{
		return Fputil_fdim_float_0.Invoke(X, Y);
	}
}
