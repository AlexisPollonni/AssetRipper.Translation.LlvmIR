using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Canonicalizef128
{
	[MangledName("canonicalizef128")]
	[DemangledName("canonicalizef128")]
	public unsafe static int Invoke([MangledName("cx")] void* Cx, [MangledName("x")] void* X)
	{
		return Fputil_canonicalize_float128_0.Invoke(Cx, X);
	}
}
