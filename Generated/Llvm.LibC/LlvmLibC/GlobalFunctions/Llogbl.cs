using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llogbl
{
	[MangledName("llogbl")]
	[DemangledName("llogbl")]
	public static long Invoke([MangledName("x")] double X)
	{
		return Fputil_intlogb_long_long_double.Invoke(X);
	}
}
