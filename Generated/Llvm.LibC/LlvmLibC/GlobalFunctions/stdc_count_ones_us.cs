namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_count_ones_us
{
	public static int Invoke(short value)
	{
		return cpp_popcount_unsigned_short.Invoke(value);
	}
}
