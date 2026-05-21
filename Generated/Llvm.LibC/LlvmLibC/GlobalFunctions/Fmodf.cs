using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmodf
{
	[MangledName("fmodf")]
	[DemangledName("fmodf")]
	public static float Invoke([MangledName("x")] float X, [MangledName("y")] float Y)
	{
		return FMod_float_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_eval.Invoke(X, Y);
	}
}
