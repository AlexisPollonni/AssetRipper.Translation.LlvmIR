namespace LlvmLibC.GlobalFunctions;

internal static partial class truncf128
{
	public static double Invoke(double x)
	{
		return fputil_trunc_float128_0.Invoke(x);
	}
}
