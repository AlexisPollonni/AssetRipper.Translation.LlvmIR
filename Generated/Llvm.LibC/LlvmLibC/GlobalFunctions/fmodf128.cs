namespace LlvmLibC.GlobalFunctions;

internal static partial class fmodf128
{
	public static double Invoke(double x, double y)
	{
		return FMod_float128_unsigned_int128_fputil_generic_FModDivisionSimpleHelper_unsigned_int128_eval.Invoke(x, y);
	}
}
