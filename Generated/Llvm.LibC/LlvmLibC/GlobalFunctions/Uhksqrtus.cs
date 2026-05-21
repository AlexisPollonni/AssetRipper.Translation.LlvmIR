using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Uhksqrtus
{
	[MangledName("uhksqrtus")]
	[DemangledName("uhksqrtus")]
	public static short Invoke([MangledName("x")] short X)
	{
		return Fixed_point_isqrt_unsigned_short.Invoke(X);
	}
}
