using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Dsubl
{
	[MangledName("dsubl")]
	[DemangledName("dsubl")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_sub_double_long_double.Invoke(X, Y);
	}
}
