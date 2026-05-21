using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fadd
{
	[MangledName("fadd")]
	[DemangledName("fadd")]
	public static float Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_add_float_double.Invoke(X, Y);
	}
}
