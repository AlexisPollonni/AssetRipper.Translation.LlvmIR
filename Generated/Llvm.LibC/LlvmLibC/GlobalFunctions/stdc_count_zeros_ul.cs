namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_count_zeros_ul
{
	public static int Invoke(long value)
	{
		return count_zeros_unsigned_long.Invoke(value);
	}
}
