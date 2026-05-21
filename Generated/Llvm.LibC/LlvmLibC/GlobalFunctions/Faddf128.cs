using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Faddf128
{
	[MangledName("faddf128")]
	[DemangledName("faddf128")]
	public static float Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_add_float_float128.Invoke(X, Y);
	}
}
