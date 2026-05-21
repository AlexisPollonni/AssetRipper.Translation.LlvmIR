using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Roundevenl
{
	[MangledName("roundevenl")]
	[DemangledName("roundevenl")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_round_using_specific_rounding_mode_long_double.Invoke(X, 4);
	}
}
