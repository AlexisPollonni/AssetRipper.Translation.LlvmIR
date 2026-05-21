namespace LlvmLibC.GlobalFunctions;

internal static partial class fadd
{
	public static float Invoke(double x, double y)
	{
		return generic_add_float_double.Invoke(x, y);
	}
}
