namespace LlvmLibC.GlobalFunctions;

internal static partial class roundhr
{
	public static sbyte Invoke(sbyte x, int n)
	{
		return fixed_point_round_short_Fract.Invoke(x, n);
	}
}
