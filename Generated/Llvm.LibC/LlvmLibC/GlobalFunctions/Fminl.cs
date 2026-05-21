using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fminl
{
	[MangledName("fminl")]
	[DemangledName("fminl")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Fputil_fmin_long_double_0.Invoke(X, Y);
	}
}
