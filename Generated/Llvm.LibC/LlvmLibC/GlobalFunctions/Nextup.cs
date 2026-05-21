using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nextup
{
	[MangledName("nextup")]
	[DemangledName("nextup")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_nextupdown_false_double_0.Invoke(X);
	}
}
