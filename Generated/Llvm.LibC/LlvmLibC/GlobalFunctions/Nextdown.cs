using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nextdown
{
	[MangledName("nextdown")]
	[DemangledName("nextdown")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_nextupdown_true_double_0.Invoke(X);
	}
}
