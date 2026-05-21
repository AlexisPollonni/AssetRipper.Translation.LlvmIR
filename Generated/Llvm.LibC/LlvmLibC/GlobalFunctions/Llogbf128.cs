using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llogbf128
{
	[MangledName("llogbf128")]
	[DemangledName("llogbf128")]
	public static long Invoke([MangledName("x")] double X)
	{
		return Fputil_intlogb_long_float128.Invoke(X);
	}
}
