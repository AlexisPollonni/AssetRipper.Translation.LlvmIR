using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ilogb
{
	[MangledName("ilogb")]
	[DemangledName("ilogb")]
	public static int Invoke([MangledName("x")] double X)
	{
		return Fputil_intlogb_int_double.Invoke(X);
	}
}
