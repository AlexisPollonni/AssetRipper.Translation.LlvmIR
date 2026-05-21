using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Canonicalizef16
{
	[MangledName("canonicalizef16")]
	[DemangledName("canonicalizef16")]
	public unsafe static int Invoke([MangledName("cx")] void* Cx, [MangledName("x")] void* X)
	{
		return Fputil_canonicalize_Float16_0.Invoke(Cx, X);
	}
}
