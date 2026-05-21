using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Remquof
{
	[MangledName("remquof")]
	[DemangledName("remquof")]
	public unsafe static float Invoke([MangledName("x")] float X, [MangledName("y")] float Y, [MangledName("exp")] void* Exp)
	{
		return Fputil_remquo_float_0.Invoke(X, Y, Exp);
	}
}
