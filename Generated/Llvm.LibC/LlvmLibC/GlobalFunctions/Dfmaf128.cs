using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Dfmaf128
{
	[MangledName("dfmaf128")]
	[DemangledName("dfmaf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y, [MangledName("z")] double Z)
	{
		return Fputil_fma_double_float128.Invoke(X, Y, Z);
	}
}
