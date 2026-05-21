namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_count_ones_ull
{
	public static int Invoke(long value)
	{
		return cpp_popcount_unsigned_long_long.Invoke(value);
	}
}
