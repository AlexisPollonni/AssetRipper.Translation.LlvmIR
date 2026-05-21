using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nexttoward
{
	[MangledName("nexttoward")]
	[DemangledName("nexttoward")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_nextafter_double_long_double_0.Invoke(X, Y);
	}
}
