using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaximumf128
{
	[MangledName("fmaximumf128")]
	[DemangledName("fmaximumf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fmaximum_float128_0.Invoke(X, Y);
	}
}
