using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Abslr
{
	[MangledName("abslr")]
	[DemangledName("abslr")]
	public static int Invoke([MangledName("x")] int X)
	{
		return Fixed_point_abs_long_Fract.Invoke(X);
	}
}
