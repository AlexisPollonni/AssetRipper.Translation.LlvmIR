using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nextafterf
{
	[MangledName("nextafterf")]
	[DemangledName("nextafterf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("y")] float Y)
	{
		return Fputil_nextafter_float_float_0.Invoke(X, Y);
	}
}
