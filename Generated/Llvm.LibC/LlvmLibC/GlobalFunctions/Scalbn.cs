using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Scalbn
{
	[MangledName("scalbn")]
	[DemangledName("scalbn")]
	public static double Invoke([MangledName("x")] double X, [MangledName("n")] int N)
	{
		return Fputil_ldexp_double_int.Invoke(X, N);
	}
}
