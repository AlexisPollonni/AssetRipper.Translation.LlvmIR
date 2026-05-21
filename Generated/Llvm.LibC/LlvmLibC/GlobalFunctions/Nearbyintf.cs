using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nearbyintf
{
	[MangledName("nearbyintf")]
	[DemangledName("nearbyintf")]
	public static float Invoke([MangledName("x")] float X)
	{
		return Fputil_round_using_current_rounding_mode_float.Invoke(X);
	}
}
