using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fminimumf128
{
	[MangledName("fminimumf128")]
	[DemangledName("fminimumf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fminimum_float128_0.Invoke(X, Y);
	}
}
