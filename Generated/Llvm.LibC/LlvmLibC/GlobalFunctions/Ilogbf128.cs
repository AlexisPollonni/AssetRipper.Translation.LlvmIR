using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ilogbf128
{
	[MangledName("ilogbf128")]
	[DemangledName("ilogbf128")]
	public static int Invoke([MangledName("x")] double X)
	{
		return Fputil_intlogb_int_float128.Invoke(X);
	}
}
