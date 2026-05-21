using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nextupf128
{
	[MangledName("nextupf128")]
	[DemangledName("nextupf128")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_nextupdown_false_float128_0.Invoke(X);
	}
}
