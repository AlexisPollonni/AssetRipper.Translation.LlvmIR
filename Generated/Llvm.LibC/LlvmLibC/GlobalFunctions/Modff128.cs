using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Modff128
{
	[MangledName("modff128")]
	[DemangledName("modff128")]
	public unsafe static double Invoke([MangledName("x")] double X, [MangledName("iptr")] void* Iptr)
	{
		return Fputil_modf_float128_0.Invoke(X, Iptr);
	}
}
