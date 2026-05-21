using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llrintl
{
	[MangledName("llrintl")]
	[DemangledName("llrintl")]
	public static long Invoke([MangledName("x")] double X)
	{
		return Fputil_round_to_signed_integer_using_current_rounding_mode_long_double_long_long_0.Invoke(X);
	}
}
