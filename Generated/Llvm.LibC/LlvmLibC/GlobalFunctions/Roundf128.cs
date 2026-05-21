using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Roundf128
{
	[MangledName("roundf128")]
	[DemangledName("roundf128")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_round_float128_0.Invoke(X);
	}
}
