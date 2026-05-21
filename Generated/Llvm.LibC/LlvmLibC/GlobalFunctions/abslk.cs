namespace LlvmLibC.GlobalFunctions;

internal static partial class abslk
{
	public static long Invoke(long x)
	{
		return fixed_point_abs_long_Accum.Invoke(x);
	}
}
