using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Nextupf
{
	[MangledName("nextupf")]
	[DemangledName("nextupf")]
	public static float Invoke([MangledName("x")] float X)
	{
		return Fputil_nextupdown_false_float_0.Invoke(X);
	}
}
