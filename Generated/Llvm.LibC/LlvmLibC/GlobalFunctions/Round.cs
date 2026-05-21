using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Round
{
	[MangledName("round")]
	[DemangledName("round")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_round_double_0.Invoke(X);
	}
}
