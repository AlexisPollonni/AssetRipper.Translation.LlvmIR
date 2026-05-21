using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Rintf
{
	[MangledName("rintf")]
	[DemangledName("rintf")]
	public static float Invoke([MangledName("x")] float X)
	{
		return Fputil_round_using_current_rounding_mode_float.Invoke(X);
	}
}
