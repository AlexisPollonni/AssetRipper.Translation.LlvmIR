using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Logbf
{
	[MangledName("logbf")]
	[DemangledName("logbf")]
	public static float Invoke([MangledName("x")] float X)
	{
		return Fputil_logb_float_0.Invoke(X);
	}
}
