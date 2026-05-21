using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Copysignl
{
	[MangledName("copysignl")]
	[DemangledName("copysignl")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_copysign_long_double_0.Invoke(X, Y);
	}
}
