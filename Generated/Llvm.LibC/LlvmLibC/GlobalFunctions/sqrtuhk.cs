namespace LlvmLibC.GlobalFunctions;

internal static partial class sqrtuhk
{
	public static short Invoke(short x)
	{
		return fixed_point_sqrt_unsigned_short_Accum.Invoke(x);
	}
}
