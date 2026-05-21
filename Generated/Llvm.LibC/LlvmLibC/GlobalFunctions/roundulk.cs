namespace LlvmLibC.GlobalFunctions;

internal static partial class roundulk
{
	public static long Invoke(long x, int n)
	{
		return fixed_point_round_unsigned_long_Accum.Invoke(x, n);
	}
}
