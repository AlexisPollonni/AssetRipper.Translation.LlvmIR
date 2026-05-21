using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nextdownl
{
	[MangledName("nextdownl")]
	[DemangledName("nextdownl")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_nextupdown_true.Invoke(X);
	}
}
