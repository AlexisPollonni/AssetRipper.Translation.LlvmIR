using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sqrtuk
{
	[MangledName("sqrtuk")]
	[DemangledName("sqrtuk")]
	public static int Invoke([MangledName("x")] int X)
	{
		return Fixed_point_sqrt_unsigned_Accum.Invoke(X);
	}
}
