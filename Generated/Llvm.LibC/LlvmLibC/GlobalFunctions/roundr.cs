namespace LlvmLibC.GlobalFunctions;

internal static partial class roundr
{
	public static short Invoke(short x, int n)
	{
		return Fract_fixed_point_round_Fract_Fract_int.Invoke(x, n);
	}
}
