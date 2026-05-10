namespace LlvmLibC.GlobalFunctions;

internal static partial class fmodf
{
	public static float Invoke(float x, float y)
	{
		return fputil_generic_FMod_float_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_eval_float_float.Invoke(x, y);
	}
}
