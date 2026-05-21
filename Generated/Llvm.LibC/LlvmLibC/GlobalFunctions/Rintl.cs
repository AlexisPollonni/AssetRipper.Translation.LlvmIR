using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Rintl
{
	[MangledName("rintl")]
	[DemangledName("rintl")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_round_using_current_rounding_mode_long_double.Invoke(X);
	}
}
