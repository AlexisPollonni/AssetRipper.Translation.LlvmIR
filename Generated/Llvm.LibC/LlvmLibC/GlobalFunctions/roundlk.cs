namespace LlvmLibC.GlobalFunctions;

internal static partial class roundlk
{
	public static long Invoke(long x, int n)
	{
		return fixed_point_round_long_Accum.Invoke(x, n);
	}
}
