namespace LlvmLibC.GlobalFunctions;

internal static partial class roundulr
{
	public static int Invoke(int x, int n)
	{
		return fixed_point_round_unsigned_long_Fract.Invoke(x, n);
	}
}
