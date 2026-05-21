using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Canonicalize
{
	[MangledName("canonicalize")]
	[DemangledName("canonicalize")]
	public unsafe static int Invoke([MangledName("cx")] void* Cx, [MangledName("x")] void* X)
	{
		return Fputil_canonicalize_double_0.Invoke(Cx, X);
	}
}
