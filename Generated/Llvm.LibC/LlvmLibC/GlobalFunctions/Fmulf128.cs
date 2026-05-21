using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmulf128
{
	[MangledName("fmulf128")]
	[DemangledName("fmulf128")]
	public static float Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return Generic_mul_float_float128.Invoke(X, Y);
	}
}
