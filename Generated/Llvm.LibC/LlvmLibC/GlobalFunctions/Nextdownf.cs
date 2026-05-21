using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nextdownf
{
	[MangledName("nextdownf")]
	[DemangledName("nextdownf")]
	public static float Invoke([MangledName("x")] float X)
	{
		return Fputil_nextupdown_true_float_0.Invoke(X);
	}
}
