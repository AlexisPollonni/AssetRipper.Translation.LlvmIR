using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nextupl
{
	[MangledName("nextupl")]
	[DemangledName("nextupl")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_nextupdown_false.Invoke(X);
	}
}
