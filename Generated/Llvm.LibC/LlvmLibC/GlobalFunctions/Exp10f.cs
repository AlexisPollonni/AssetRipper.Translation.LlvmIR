using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Exp10f
{
	[MangledName("exp10f")]
	[DemangledName("exp10f")]
	public static float Invoke([MangledName("x")] float X)
	{
		return Generic_exp10f.Invoke(X);
	}
}
