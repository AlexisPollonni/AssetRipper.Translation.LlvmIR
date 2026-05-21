using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llogbf
{
	[MangledName("llogbf")]
	[DemangledName("llogbf")]
	public static long Invoke([MangledName("x")] float X)
	{
		return Fputil_intlogb_long_float.Invoke(X);
	}
}
