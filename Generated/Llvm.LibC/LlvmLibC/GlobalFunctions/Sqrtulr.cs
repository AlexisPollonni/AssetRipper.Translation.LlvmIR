using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sqrtulr
{
	[MangledName("sqrtulr")]
	[DemangledName("sqrtulr")]
	public static int Invoke([MangledName("x")] int X)
	{
		return Fixed_point_sqrt_unsigned_long_Fract.Invoke(X);
	}
}
