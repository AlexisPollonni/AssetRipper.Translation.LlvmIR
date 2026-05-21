using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nextafterf128
{
	[MangledName("nextafterf128")]
	[DemangledName("nextafterf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_nextafter_float128_float128_0.Invoke(X, Y);
	}
}
