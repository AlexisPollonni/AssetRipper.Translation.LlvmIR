using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llrintf
{
	[MangledName("llrintf")]
	[DemangledName("llrintf")]
	public static long Invoke([MangledName("x")] float X)
	{
		return Fputil_round_to_signed_integer_using_current_rounding_mode_float_long_long_0.Invoke(X);
	}
}
