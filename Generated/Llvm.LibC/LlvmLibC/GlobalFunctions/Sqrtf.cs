using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sqrtf
{
	[MangledName("sqrtf")]
	[DemangledName("sqrtf")]
	public static float Invoke([MangledName("x")] float X)
	{
		return Fputil_sqrt_float_float.Invoke(X);
	}
}
