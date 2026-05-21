namespace LlvmLibC.GlobalFunctions;

internal static partial class scalbnf
{
	public static float Invoke(float x, int n)
	{
		return fputil_ldexp_float_int.Invoke(x, n);
	}
}
