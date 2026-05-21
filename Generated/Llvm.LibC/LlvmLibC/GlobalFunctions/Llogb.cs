using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llogb
{
	[MangledName("llogb")]
	[DemangledName("llogb")]
	public static long Invoke([MangledName("x")] double X)
	{
		return Fputil_intlogb_long_double.Invoke(X);
	}
}
