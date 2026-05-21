using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Uksqrtui
{
	[MangledName("uksqrtui")]
	[DemangledName("uksqrtui")]
	public static int Invoke([MangledName("x")] int X)
	{
		return Fixed_point_isqrt_unsigned_int.Invoke(X);
	}
}
