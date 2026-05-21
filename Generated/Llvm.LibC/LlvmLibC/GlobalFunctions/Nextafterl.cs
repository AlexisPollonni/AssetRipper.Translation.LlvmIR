using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nextafterl
{
	[MangledName("nextafterl")]
	[DemangledName("nextafterl")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_nextafter.Invoke(X, Y);
	}
}
