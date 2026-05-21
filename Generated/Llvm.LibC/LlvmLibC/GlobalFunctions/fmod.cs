namespace LlvmLibC.GlobalFunctions;

internal static partial class fmod
{
	public static double Invoke(double x, double y)
	{
		return FMod_double_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_eval.Invoke(x, y);
	}
}
