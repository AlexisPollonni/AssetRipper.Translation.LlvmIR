using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fsub
{
	[MangledName("fsub")]
	[DemangledName("fsub")]
	public static float Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_sub_float_double.Invoke(X, Y);
	}
}
