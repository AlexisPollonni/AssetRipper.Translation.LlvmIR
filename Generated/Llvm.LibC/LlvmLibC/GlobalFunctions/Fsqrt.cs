using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fsqrt
{
	[MangledName("fsqrt")]
	[DemangledName("fsqrt")]
	public static float Invoke([MangledName("x")] double X)
	{
		return Fputil_sqrt_float_double.Invoke(X);
	}
}
