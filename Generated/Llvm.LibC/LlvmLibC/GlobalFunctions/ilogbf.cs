namespace LlvmLibC.GlobalFunctions;

internal static partial class ilogbf
{
	public static int Invoke(float x)
	{
		return fputil_intlogb_int_float.Invoke(x);
	}
}
