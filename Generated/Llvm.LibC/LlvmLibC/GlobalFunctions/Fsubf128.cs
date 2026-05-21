using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fsubf128
{
	[MangledName("fsubf128")]
	[DemangledName("fsubf128")]
	public static float Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_sub_float_float128.Invoke(X, Y);
	}
}
