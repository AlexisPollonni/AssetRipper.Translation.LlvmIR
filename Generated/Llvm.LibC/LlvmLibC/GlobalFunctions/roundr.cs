namespace LlvmLibC.GlobalFunctions;

internal static partial class roundr
{
	public static short Invoke(short x, int n)
	{
		return fixed_point_round_Fract.Invoke(x, n);
	}
}
