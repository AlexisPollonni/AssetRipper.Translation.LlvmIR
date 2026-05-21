using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ldexpf128
{
	[MangledName("ldexpf128")]
	[DemangledName("ldexpf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("exp")] int Exp)
	{
		return Fputil_ldexp_float128_int.Invoke(X, Exp);
	}
}
