using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ilogbl
{
	[MangledName("ilogbl")]
	[DemangledName("ilogbl")]
	public static int Invoke([MangledName("x")] double X)
	{
		return Fputil_intlogb_int_long_double.Invoke(X);
	}
}
