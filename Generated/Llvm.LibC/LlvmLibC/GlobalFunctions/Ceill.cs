using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ceill
{
	[MangledName("ceill")]
	[DemangledName("ceill")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_ceil_long_double_0.Invoke(X);
	}
}
