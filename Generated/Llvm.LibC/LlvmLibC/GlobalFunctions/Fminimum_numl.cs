using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fminimum_numl
{
	[MangledName("fminimum_numl")]
	[DemangledName("fminimum_numl")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fminimum_num_long_double_0.Invoke(X, Y);
	}
}
