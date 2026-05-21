using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaximum_num
{
	[MangledName("fmaximum_num")]
	[DemangledName("fmaximum_num")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fmaximum_num_double_0.Invoke(X, Y);
	}
}
