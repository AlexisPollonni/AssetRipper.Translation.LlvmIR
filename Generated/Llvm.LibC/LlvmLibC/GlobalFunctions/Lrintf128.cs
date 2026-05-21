using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Lrintf128
{
	[MangledName("lrintf128")]
	[DemangledName("lrintf128")]
	public static long Invoke([MangledName("x")] double X)
	{
		return Fputil_round_to_signed_integer_using_current_rounding_mode_float128_long_0.Invoke(X);
	}
}
