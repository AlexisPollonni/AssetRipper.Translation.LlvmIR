using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmod
{
	[MangledName("fmod")]
	[DemangledName("fmod")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return FMod_double_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_eval.Invoke(X, Y);
	}
}
