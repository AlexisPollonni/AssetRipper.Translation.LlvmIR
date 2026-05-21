namespace LlvmLibC.GlobalFunctions;

internal static partial class ldexpf
{
	public static float Invoke(float x, int exp)
	{
		return fputil_ldexp_float_int.Invoke(x, exp);
	}
}
