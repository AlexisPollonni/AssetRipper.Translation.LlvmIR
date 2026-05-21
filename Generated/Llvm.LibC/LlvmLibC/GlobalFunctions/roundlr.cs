namespace LlvmLibC.GlobalFunctions;

internal static partial class roundlr
{
	public static int Invoke(int x, int n)
	{
		return fixed_point_round_long_Fract.Invoke(x, n);
	}
}
