namespace LlvmLibC.GlobalFunctions;

internal static partial class roundhk
{
	public static short Invoke(short x, int n)
	{
		return fixed_point_round_short_Accum.Invoke(x, n);
	}
}
