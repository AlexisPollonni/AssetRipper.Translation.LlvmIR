namespace LlvmLibC.GlobalFunctions;

internal static partial class rounduhk
{
	public static short Invoke(short x, int n)
	{
		return fixed_point_round_unsigned_short_Accum.Invoke(x, n);
	}
}
