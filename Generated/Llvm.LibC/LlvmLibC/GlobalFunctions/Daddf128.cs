using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Daddf128
{
	[MangledName("daddf128")]
	[DemangledName("daddf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_add_double_float128.Invoke(X, Y);
	}
}
