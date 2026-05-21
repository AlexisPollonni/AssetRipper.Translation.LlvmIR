using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Frexpf
{
	[MangledName("frexpf")]
	[DemangledName("frexpf")]
	public unsafe static float Invoke([MangledName("x")] float X, [MangledName("exp")] void* Exp)
	{
		return Fputil_frexp_float_0.Invoke(X, Exp);
	}
}
