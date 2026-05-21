using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fsqrtf128
{
	[MangledName("fsqrtf128")]
	[DemangledName("fsqrtf128")]
	public static float Invoke([MangledName("x")] double X)
	{
		return Fputil_sqrt_float_float128.Invoke(X);
	}
}
