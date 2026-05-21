using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Scalbnf128
{
	[MangledName("scalbnf128")]
	[DemangledName("scalbnf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("n")] int N)
	{
		return Fputil_ldexp_float128_int.Invoke(X, N);
	}
}
