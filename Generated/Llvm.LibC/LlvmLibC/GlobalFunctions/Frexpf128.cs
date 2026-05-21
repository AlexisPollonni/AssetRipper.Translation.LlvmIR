using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Frexpf128
{
	[MangledName("frexpf128")]
	[DemangledName("frexpf128")]
	public unsafe static double Invoke([MangledName("x")] double X, [MangledName("exp")] void* Exp)
	{
		return Fputil_frexp_float128_0.Invoke(X, Exp);
	}
}
