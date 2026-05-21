using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Remquof128
{
	[MangledName("remquof128")]
	[DemangledName("remquof128")]
	public unsafe static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y, [MangledName("exp")] void* Exp)
	{
		return Fputil_remquo_float128_0.Invoke(X, Y, Exp);
	}
}
