using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Frexp
{
	[MangledName("frexp")]
	[DemangledName("frexp")]
	public unsafe static double Invoke([MangledName("x")] double X, [MangledName("exp")] void* Exp)
	{
		return Fputil_frexp_double_0.Invoke(X, Exp);
	}
}
