using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Ilogbf
{
	[MangledName("ilogbf")]
	[DemangledName("ilogbf")]
	public static int Invoke([MangledName("x")] float X)
	{
		return Fputil_intlogb_int_float.Invoke(X);
	}
}
