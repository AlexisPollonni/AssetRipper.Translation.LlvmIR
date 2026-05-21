using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Abslk
{
	[MangledName("abslk")]
	[DemangledName("abslk")]
	public static long Invoke([MangledName("x")] long X)
	{
		return Fixed_point_abs_long_Accum.Invoke(X);
	}
}
