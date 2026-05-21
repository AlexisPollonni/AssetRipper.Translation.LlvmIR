using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Trunc
{
	[MangledName("trunc")]
	[DemangledName("trunc")]
	public static double Invoke([MangledName("x")] double X)
	{
		return Fputil_trunc_double_0.Invoke(X);
	}
}
