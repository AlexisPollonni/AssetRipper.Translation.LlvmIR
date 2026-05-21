using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fma
{
	[MangledName("fma")]
	[DemangledName("fma")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y, [MangledName("z")] double Z)
	{
		return Fputil_fma_double_double.Invoke(X, Y, Z);
	}
}
