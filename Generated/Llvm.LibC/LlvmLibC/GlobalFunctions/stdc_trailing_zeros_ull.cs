namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_trailing_zeros_ull
{
	public static int Invoke(long value)
	{
		return cpp_countr_zero_unsigned_long_long.Invoke(value);
	}
}
