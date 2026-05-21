namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_count_zeros_ull
{
	public static int Invoke(long value)
	{
		return count_zeros_unsigned_long_long.Invoke(value);
	}
}
