using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Roundevenf128
{
	[MangledName("roundevenf128")]
	[DemangledName("roundevenf128")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_round_using_specific_rounding_mode_float128.Invoke(X, 4);
	}
}
