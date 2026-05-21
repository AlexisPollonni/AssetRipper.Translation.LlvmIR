namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_trailing_zeros_us
{
	public static int Invoke(short value)
	{
		return cpp_countr_zero_unsigned_short.Invoke(value);
	}
}
