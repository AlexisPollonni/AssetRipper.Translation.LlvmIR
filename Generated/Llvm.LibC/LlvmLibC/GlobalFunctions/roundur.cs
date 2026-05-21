namespace LlvmLibC.GlobalFunctions;

internal static partial class roundur
{
	public static short Invoke(short x, int n)
	{
		return fixed_point_round_unsigned_Fract.Invoke(x, n);
	}
}
