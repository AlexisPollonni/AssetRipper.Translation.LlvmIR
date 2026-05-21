using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ffmaf128
{
	[MangledName("ffmaf128")]
	[DemangledName("ffmaf128")]
	public static float Invoke([MangledName("x")] double X, [MangledName("y")] double Y, [MangledName("z")] double Z)
	{
		return Fputil_fma_float_float128.Invoke(X, Y, Z);
	}
}
