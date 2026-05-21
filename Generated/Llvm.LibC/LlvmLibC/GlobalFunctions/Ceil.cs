using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ceil
{
	[MangledName("ceil")]
	[DemangledName("ceil")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_ceil_double_0.Invoke(X);
	}
}
