namespace LlvmLibC.GlobalFunctions;

internal static partial class rounduhr
{
	public static sbyte Invoke(sbyte x, int n)
	{
		return fixed_point_round_unsigned_short_Fract.Invoke(x, n);
	}
}
