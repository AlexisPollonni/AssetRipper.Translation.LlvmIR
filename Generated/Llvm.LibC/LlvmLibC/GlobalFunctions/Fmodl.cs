using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmodl
{
	[MangledName("fmodl")]
	[DemangledName("fmodl")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return FMod_long_double_unsigned_int128_fputil_generic_FModDivisionSimpleHelper_unsigned_int128_eval.Invoke(X, Y);
	}
}
