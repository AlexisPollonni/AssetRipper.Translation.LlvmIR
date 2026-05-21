using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Remquol
{
	[MangledName("remquol")]
	[DemangledName("remquol")]
	public unsafe static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y, [MangledName("exp")] void* Exp)
	{
		return Fputil_remquo_long_double_0.Invoke(X, Y, Exp);
	}
}
