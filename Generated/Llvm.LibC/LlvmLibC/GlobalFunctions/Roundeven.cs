using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Roundeven
{
	[MangledName("roundeven")]
	[DemangledName("roundeven")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_round_using_specific_rounding_mode_double.Invoke(X, 4);
	}
}
