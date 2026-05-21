namespace LlvmLibC.GlobalFunctions;

internal static partial class sqrtulr
{
	public static int Invoke(int x)
	{
		return fixed_point_sqrt_unsigned_long_Fract.Invoke(x);
	}
}
