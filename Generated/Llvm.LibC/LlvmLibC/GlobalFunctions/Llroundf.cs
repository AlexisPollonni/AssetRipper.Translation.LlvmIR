using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llroundf
{
	[MangledName("llroundf")]
	[DemangledName("llroundf")]
	public static long Invoke([MangledName("x")] float X)
	{
		return Fputil_round_to_signed_integer_float_long_long_0.Invoke(X);
	}
}
