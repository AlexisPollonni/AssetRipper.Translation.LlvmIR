namespace LlvmLibC.GlobalFunctions;

internal static partial class truncf
{
	public static float Invoke(float x)
	{
		return fputil_trunc_float_0.Invoke(x);
	}
}
