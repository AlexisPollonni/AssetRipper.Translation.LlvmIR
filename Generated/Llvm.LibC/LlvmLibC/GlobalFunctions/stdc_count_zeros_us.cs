namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_count_zeros_us
{
	public static int Invoke(short value)
	{
		return count_zeros_unsigned_short.Invoke(value);
	}
}
