namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_leading_zeros_ul
{
	public static int Invoke(long value)
	{
		return cpp_countl_zero_unsigned_long.Invoke(value);
	}
}
