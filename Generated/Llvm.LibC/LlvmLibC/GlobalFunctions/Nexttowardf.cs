using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nexttowardf
{
	[MangledName("nexttowardf")]
	[DemangledName("nexttowardf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("y")] double Y)
	{
		return Fputil_nextafter_float_long_double_0.Invoke(X, Y);
	}
}
