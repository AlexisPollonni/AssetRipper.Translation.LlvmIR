using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Rintf128
{
	[MangledName("rintf128")]
	[DemangledName("rintf128")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_round_using_current_rounding_mode_float128.Invoke(X);
	}
}
