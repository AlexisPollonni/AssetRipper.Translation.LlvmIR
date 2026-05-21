using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sqrt
{
	[MangledName("sqrt")]
	[DemangledName("sqrt")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_sqrt_double_double.Invoke(X);
	}
}
