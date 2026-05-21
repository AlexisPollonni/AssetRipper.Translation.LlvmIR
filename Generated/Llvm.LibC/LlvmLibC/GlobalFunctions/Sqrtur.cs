using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sqrtur
{
	[MangledName("sqrtur")]
	[DemangledName("sqrtur")]
	public static short Invoke([MangledName("x")] short X)
	{
		return Fixed_point_sqrt_unsigned_Fract.Invoke(X);
	}
}
