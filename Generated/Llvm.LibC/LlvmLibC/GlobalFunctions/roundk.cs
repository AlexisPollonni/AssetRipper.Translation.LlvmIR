namespace LlvmLibC.GlobalFunctions;

internal static partial class roundk
{
	public static int Invoke(int x, int n)
	{
		return fixed_point_round_Accum.Invoke(x, n);
	}
}
