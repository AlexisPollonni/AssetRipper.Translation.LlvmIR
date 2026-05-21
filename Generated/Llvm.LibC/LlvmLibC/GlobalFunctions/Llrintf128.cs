using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llrintf128
{
	[MangledName("llrintf128")]
	[DemangledName("llrintf128")]
	public static long Invoke([MangledName("x")] double X)
	{
		return Fputil_round_to_signed_integer_using_current_rounding_mode_float128_long_long_0.Invoke(X);
	}
}
