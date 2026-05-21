using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmaf
{
	[MangledName("fmaf")]
	[DemangledName("fmaf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("y")] float Y, [MangledName("z")] float Z)
	{
		return Fputil_fma_float_float.Invoke(X, Y, Z);
	}
}
