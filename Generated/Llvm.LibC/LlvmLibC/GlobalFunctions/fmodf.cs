namespace LlvmLibC.GlobalFunctions;

internal static partial class fmodf
{
	public static float Invoke(float x, float y)
	{
		return FMod_float_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_eval.Invoke(x, y);
	}
}
