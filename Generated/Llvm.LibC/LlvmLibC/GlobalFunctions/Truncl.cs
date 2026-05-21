using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Truncl
{
	[MangledName("truncl")]
	[DemangledName("truncl")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_trunc_long_double_0.Invoke(X);
	}
}
