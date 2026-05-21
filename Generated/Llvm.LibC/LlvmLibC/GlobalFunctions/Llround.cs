using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llround
{
	[MangledName("llround")]
	[DemangledName("llround")]
	public static long Invoke([MangledName("x")] double X)
	{
		return Fputil_round_to_signed_integer_double_long_long_0.Invoke(X);
	}
}
