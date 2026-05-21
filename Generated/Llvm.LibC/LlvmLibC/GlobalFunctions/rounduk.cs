namespace LlvmLibC.GlobalFunctions;

internal static partial class rounduk
{
	public static int Invoke(int x, int n)
	{
		return fixed_point_round_unsigned_Accum.Invoke(x, n);
	}
}
