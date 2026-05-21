using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ffma
{
	[MangledName("ffma")]
	[DemangledName("ffma")]
	public static float Invoke([MangledName("x")] double X, [MangledName("y")] double Y, [MangledName("z")] double Z)
	{
		return Fputil_fma_float_double.Invoke(X, Y, Z);
	}
}
