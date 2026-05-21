using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Scalblnf
{
	[MangledName("scalblnf")]
	[DemangledName("scalblnf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("n")] long N)
	{
		return Fputil_ldexp_float_long.Invoke(X, N);
	}
}
