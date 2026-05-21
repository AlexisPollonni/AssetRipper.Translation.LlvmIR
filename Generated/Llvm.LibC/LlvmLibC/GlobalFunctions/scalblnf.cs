namespace LlvmLibC.GlobalFunctions;

internal static partial class scalblnf
{
	public static float Invoke(float x, long n)
	{
		return fputil_ldexp_float_long.Invoke(x, n);
	}
}
