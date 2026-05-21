using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fsqrtl
{
	[MangledName("fsqrtl")]
	[DemangledName("fsqrtl")]
	public static float Invoke([MangledName("x")] double X)
	{
		return Fputil_sqrt_float_long_double.Invoke(X);
	}
}
