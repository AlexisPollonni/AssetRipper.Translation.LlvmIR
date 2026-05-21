using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fminf128
{
	[MangledName("fminf128")]
	[DemangledName("fminf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fmin_float128_0.Invoke(X, Y);
	}
}
