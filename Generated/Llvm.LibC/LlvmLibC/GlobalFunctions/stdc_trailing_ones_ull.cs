namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_trailing_ones_ull
{
	public static int Invoke(long value)
	{
		return cpp_countr_one_unsigned_long_long.Invoke(value);
	}
}
