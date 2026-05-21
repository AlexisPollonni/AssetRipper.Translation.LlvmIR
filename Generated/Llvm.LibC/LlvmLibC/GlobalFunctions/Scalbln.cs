using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Scalbln
{
	[MangledName("scalbln")]
	[DemangledName("scalbln")]
	public static double Invoke([MangledName("x")] double X, [MangledName("n")] long N)
	{
		return Fputil_ldexp_double_long.Invoke(X, N);
	}
}
