using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Roundevenf
{
	[MangledName("roundevenf")]
	[DemangledName("roundevenf")]
	public static float Invoke([MangledName("x")] float X)
	{
		return Fputil_round_using_specific_rounding_mode_float.Invoke(X, 4);
	}
}
