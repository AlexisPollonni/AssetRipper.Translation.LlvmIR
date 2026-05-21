using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fminimum_num
{
	[MangledName("fminimum_num")]
	[DemangledName("fminimum_num")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fminimum_num_double_0.Invoke(X, Y);
	}
}
