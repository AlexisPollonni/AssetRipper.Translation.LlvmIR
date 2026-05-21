namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_first_leading_zero_ul
{
	public static int Invoke(long value)
	{
		return first_leading_zero_unsigned_long.Invoke(value);
	}
}
