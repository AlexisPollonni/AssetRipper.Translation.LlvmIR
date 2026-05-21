using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ldexpf
{
	[MangledName("ldexpf")]
	[DemangledName("ldexpf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("exp")] int Exp)
	{
		return Fputil_ldexp_float_int.Invoke(X, Exp);
	}
}
