using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaximum_numf128
{
	[MangledName("fmaximum_numf128")]
	[DemangledName("fmaximum_numf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fmaximum_num_float128_0.Invoke(X, Y);
	}
}
