using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Truncf
{
	[MangledName("truncf")]
	[DemangledName("truncf")]
	public static float Invoke([MangledName("x")] float X)
	{
		return Fputil_trunc_float_0.Invoke(X);
	}
}
