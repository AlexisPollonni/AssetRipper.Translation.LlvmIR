namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_leading_zeros_us
{
	public static int Invoke(short value)
	{
		return cpp_countl_zero_unsigned_short.Invoke(value);
	}
}
