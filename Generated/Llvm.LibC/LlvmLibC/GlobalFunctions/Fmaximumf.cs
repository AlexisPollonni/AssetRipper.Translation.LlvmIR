using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaximumf
{
	[MangledName("fmaximumf")]
	[DemangledName("fmaximumf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("y")] float Y)
	{
		return Fputil_fmaximum_float_0.Invoke(X, Y);
	}
}
