namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_trailing_ones_ul
{
	public static int Invoke(long value)
	{
		return cpp_countr_one_unsigned_long.Invoke(value);
	}
}
