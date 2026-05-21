using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Canonicalizel
{
	[MangledName("canonicalizel")]
	[DemangledName("canonicalizel")]
	public unsafe static int Invoke([MangledName("cx")] void* Cx, [MangledName("x")] void* X)
	{
		return Fputil_canonicalize_long_double_0.Invoke(Cx, X);
	}
}
