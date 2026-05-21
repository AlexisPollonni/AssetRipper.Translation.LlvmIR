using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Rint
{
	[MangledName("rint")]
	[DemangledName("rint")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_round_using_current_rounding_mode_double.Invoke(X);
	}
}
