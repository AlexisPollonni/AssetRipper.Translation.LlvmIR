using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Lrintf
{
	[MangledName("lrintf")]
	[DemangledName("lrintf")]
	public static long Invoke([MangledName("x")] float X)
	{
		return Fputil_round_to_signed_integer_using_current_rounding_mode_float_long_0.Invoke(X);
	}
}
