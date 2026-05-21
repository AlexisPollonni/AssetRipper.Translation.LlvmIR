using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Abshr
{
	[MangledName("abshr")]
	[DemangledName("abshr")]
	public static sbyte Invoke([MangledName("x")] sbyte X)
	{
		return Fixed_point_abs_short_Fract.Invoke(X);
	}
}
