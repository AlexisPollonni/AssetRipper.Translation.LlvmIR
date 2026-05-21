using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fminimum_numf128
{
	[MangledName("fminimum_numf128")]
	[DemangledName("fminimum_numf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fminimum_num_float128_0.Invoke(X, Y);
	}
}
