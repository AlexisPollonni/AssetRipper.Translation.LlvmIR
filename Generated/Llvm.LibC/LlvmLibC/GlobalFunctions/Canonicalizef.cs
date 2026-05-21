using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Canonicalizef
{
	[MangledName("canonicalizef")]
	[DemangledName("canonicalizef")]
	public unsafe static int Invoke([MangledName("cx")] void* Cx, [MangledName("x")] void* X)
	{
		return Fputil_canonicalize_float_0.Invoke(Cx, X);
	}
}
