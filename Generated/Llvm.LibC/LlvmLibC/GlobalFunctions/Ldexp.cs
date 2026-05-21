using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ldexp
{
	[MangledName("ldexp")]
	[DemangledName("ldexp")]
	public static double Invoke([MangledName("x")] double X, [MangledName("exp")] int Exp)
	{
		return Fputil_ldexp_double_int.Invoke(X, Exp);
	}
}
