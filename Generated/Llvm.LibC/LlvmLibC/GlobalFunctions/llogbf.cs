namespace LlvmLibC.GlobalFunctions;

internal static partial class llogbf
{
	public static long Invoke(float x)
	{
		return fputil_intlogb_long_float.Invoke(x);
	}
}
