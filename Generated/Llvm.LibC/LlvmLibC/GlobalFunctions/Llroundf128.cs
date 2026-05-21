using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llroundf128
{
	[MangledName("llroundf128")]
	[DemangledName("llroundf128")]
	public static long Invoke([MangledName("x")] double X)
	{
		return Fputil_round_to_signed_integer_float128_long_long_0.Invoke(X);
	}
}
