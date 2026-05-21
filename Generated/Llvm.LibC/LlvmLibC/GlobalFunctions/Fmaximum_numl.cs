using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaximum_numl
{
	[MangledName("fmaximum_numl")]
	[DemangledName("fmaximum_numl")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fmaximum_num_long_double_0.Invoke(X, Y);
	}
}
