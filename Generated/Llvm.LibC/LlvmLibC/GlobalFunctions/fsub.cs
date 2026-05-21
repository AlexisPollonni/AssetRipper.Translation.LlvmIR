namespace LlvmLibC.GlobalFunctions;

internal static partial class fsub
{
	public static float Invoke(double x, double y)
	{
		return generic_sub_float_double.Invoke(x, y);
	}
}
