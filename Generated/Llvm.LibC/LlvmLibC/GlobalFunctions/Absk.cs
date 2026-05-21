using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Absk
{
	[MangledName("absk")]
	[DemangledName("absk")]
	public static int Invoke([MangledName("x")] int X)
	{
		return Fixed_point_abs_Accum.Invoke(X);
	}
}
