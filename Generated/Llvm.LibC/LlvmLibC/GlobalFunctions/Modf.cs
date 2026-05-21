using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Modf
{
	[MangledName("modf")]
	[DemangledName("modf")]
	public unsafe static double Invoke([MangledName("x")] double X, [MangledName("iptr")] void* Iptr)
	{
		return Fputil_modf_double_0.Invoke(X, Iptr);
	}
}
