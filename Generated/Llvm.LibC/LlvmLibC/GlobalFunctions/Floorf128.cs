using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Floorf128
{
	[MangledName("floorf128")]
	[DemangledName("floorf128")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_floor_float128_0.Invoke(X);
	}
}
