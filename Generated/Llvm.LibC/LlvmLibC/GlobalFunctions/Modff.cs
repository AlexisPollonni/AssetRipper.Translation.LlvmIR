using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Modff
{
	[MangledName("modff")]
	[DemangledName("modff")]
	public unsafe static float Invoke([MangledName("x")] float X, [MangledName("iptr")] void* Iptr)
	{
		return Fputil_modf_float_0.Invoke(X, Iptr);
	}
}
