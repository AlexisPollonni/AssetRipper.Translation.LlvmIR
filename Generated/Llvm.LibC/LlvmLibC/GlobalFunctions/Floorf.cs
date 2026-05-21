using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Floorf
{
	[MangledName("floorf")]
	[DemangledName("floorf")]
	public static float Invoke([MangledName("x")] float X)
	{
		return Fputil_floor_float_0.Invoke(X);
	}
}
