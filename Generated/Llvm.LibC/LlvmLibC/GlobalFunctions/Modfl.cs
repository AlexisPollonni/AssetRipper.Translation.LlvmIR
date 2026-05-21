using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Modfl
{
	[MangledName("modfl")]
	[DemangledName("modfl")]
	public unsafe static double Invoke([MangledName("x")] double X, [MangledName("iptr")] void* Iptr)
	{
		return Fputil_modf_long_double_0.Invoke(X, Iptr);
	}
}
