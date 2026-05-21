namespace LlvmLibC.GlobalFunctions;

internal static partial class llabs
{
	public static long Invoke(long n)
	{
		return integer_abs_long_long.Invoke(n);
	}
}
