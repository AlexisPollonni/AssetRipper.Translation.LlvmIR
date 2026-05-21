using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fmodf128
{
	[MangledName("fmodf128")]
	[DemangledName("fmodf128")]
	public static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		return FMod_float128_unsigned_int128_fputil_generic_FModDivisionSimpleHelper_unsigned_int128_eval.Invoke(X, Y);
	}
}
