namespace LlvmLibC.GlobalFunctions;

internal static partial class abslr
{
	public static int Invoke(int x)
	{
		return fixed_point_abs_long_Fract.Invoke(x);
	}
}
