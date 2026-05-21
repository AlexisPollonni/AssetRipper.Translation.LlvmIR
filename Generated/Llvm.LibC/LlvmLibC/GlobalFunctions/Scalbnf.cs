using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Scalbnf
{
	[MangledName("scalbnf")]
	[DemangledName("scalbnf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("n")] int N)
	{
		return Fputil_ldexp_float_int.Invoke(X, N);
	}
}
