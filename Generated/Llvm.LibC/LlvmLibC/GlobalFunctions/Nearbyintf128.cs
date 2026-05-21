using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nearbyintf128
{
	[MangledName("nearbyintf128")]
	[DemangledName("nearbyintf128")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_round_using_current_rounding_mode_float128.Invoke(X);
	}
}
