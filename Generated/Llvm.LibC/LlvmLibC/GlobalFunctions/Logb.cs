using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Logb
{
	[MangledName("logb")]
	[DemangledName("logb")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_logb_double_0.Invoke(X);
	}
}
