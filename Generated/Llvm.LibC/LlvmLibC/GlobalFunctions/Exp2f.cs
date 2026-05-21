using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Exp2f
{
	[MangledName("exp2f")]
	[DemangledName("exp2f")]
	public static float Invoke([MangledName("x")] float X)
	{
		return Generic_exp2f.Invoke(X);
	}
}
