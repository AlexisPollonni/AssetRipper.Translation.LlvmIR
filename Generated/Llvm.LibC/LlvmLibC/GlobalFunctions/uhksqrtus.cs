namespace LlvmLibC.GlobalFunctions;

internal static partial class uhksqrtus
{
	public static short Invoke(short x)
	{
		return fixed_point_isqrt_unsigned_short.Invoke(x);
	}
}
