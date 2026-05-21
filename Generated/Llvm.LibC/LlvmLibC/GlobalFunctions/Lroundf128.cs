using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Lroundf128
{
	[MangledName("lroundf128")]
	[DemangledName("lroundf128")]
	public static long Invoke([MangledName("x")] double X)
	{
		return Fputil_round_to_signed_integer_float128_long_0.Invoke(X);
	}
}
