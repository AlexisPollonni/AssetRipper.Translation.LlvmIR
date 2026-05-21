using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fabsl
{
	[MangledName("fabsl")]
	[DemangledName("fabsl")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_abs_long_double_0.Invoke(X);
	}
}
