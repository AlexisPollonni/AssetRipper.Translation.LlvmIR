using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Remquo
{
	[MangledName("remquo")]
	[DemangledName("remquo")]
	public unsafe static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y, [MangledName("exp")] void* Exp)
	{
		return Fputil_remquo_double_0.Invoke(X, Y, Exp);
	}
}
