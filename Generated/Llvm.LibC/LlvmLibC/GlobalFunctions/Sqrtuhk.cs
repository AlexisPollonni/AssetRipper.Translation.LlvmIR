using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sqrtuhk
{
	[MangledName("sqrtuhk")]
	[DemangledName("sqrtuhk")]
	public static short Invoke([MangledName("x")] short X)
	{
		return Fixed_point_sqrt_unsigned_short_Accum.Invoke(X);
	}
}
