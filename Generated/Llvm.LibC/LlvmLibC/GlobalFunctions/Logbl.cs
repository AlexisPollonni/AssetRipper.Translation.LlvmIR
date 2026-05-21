using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Logbl
{
	[MangledName("logbl")]
	[DemangledName("logbl")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_logb_long_double_0.Invoke(X);
	}
}
