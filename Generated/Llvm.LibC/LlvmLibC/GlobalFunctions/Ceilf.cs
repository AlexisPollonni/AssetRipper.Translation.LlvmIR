using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ceilf
{
	[MangledName("ceilf")]
	[DemangledName("ceilf")]
	public static float Invoke([MangledName("x")] float X)
	{
		return Fputil_ceil_float_0.Invoke(X);
	}
}
