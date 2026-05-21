using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Roundl
{
	[MangledName("roundl")]
	[DemangledName("roundl")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_round_long_double_0.Invoke(X);
	}
}
