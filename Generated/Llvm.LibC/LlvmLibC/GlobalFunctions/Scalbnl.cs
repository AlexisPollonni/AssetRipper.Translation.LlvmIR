using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Scalbnl
{
	[MangledName("scalbnl")]
	[DemangledName("scalbnl")]
	public static double Invoke([MangledName("x")] double X, [MangledName("n")] int N)
	{
		return Fputil_ldexp_long_double_int.Invoke(X, N);
	}
}
