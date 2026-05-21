using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sqrtuhr
{
	[MangledName("sqrtuhr")]
	[DemangledName("sqrtuhr")]
	public static sbyte Invoke([MangledName("x")] sbyte X)
	{
		return Fixed_point_sqrt_unsigned_short_Fract.Invoke(X);
	}
}
