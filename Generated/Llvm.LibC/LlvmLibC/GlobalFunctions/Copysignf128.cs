using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Copysignf128
{
	[MangledName("copysignf128")]
	[DemangledName("copysignf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_copysign_float128_0.Invoke(X, Y);
	}
}
