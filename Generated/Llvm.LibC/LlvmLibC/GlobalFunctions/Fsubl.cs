using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fsubl
{
	[MangledName("fsubl")]
	[DemangledName("fsubl")]
	public static float Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_sub_float_long_double.Invoke(X, Y);
	}
}
