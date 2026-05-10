namespace LlvmLibC.GlobalFunctions;

internal static partial class fmod
{
	public static double Invoke(double x, double y)
	{
		return fputil_generic_FMod_double_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_eval_double_double.Invoke(x, y);
	}
}
