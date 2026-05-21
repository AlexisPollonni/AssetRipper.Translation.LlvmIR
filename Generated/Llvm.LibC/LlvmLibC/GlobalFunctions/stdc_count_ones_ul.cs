namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_count_ones_ul
{
	public static int Invoke(long value)
	{
		return cpp_popcount_unsigned_long.Invoke(value);
	}
}
