namespace LlvmLibC.GlobalFunctions;

internal static partial class fmodf128
{
	public static double Invoke(double x, double y)
	{
		return fputil_generic_FMod_float128_unsigned_int128_fputil_generic_FModDivisionSimpleHelper_unsigned_int128_eval_float128_float128.Invoke(x, y);
	}
}
