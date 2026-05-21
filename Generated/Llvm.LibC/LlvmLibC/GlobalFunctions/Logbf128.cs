using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Logbf128
{
	[MangledName("logbf128")]
	[DemangledName("logbf128")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_logb_float128_0.Invoke(X);
	}
}
