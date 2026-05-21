using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Roundf
{
	[MangledName("roundf")]
	[DemangledName("roundf")]
	public static float Invoke([MangledName("x")] float X)
	{
		return Fputil_round_float_0.Invoke(X);
	}
}
