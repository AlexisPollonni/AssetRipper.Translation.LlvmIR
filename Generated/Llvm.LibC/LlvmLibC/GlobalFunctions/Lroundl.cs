using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Lroundl
{
	[MangledName("lroundl")]
	[DemangledName("lroundl")]
	public static long Invoke([MangledName("x")] double X)
	{
		return Fputil_round_to_signed_integer_long_double_long_0.Invoke(X);
	}
}
