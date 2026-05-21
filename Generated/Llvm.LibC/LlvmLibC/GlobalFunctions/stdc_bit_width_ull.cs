namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_bit_width_ull
{
	public static int Invoke(long value)
	{
		return cpp_bit_width_unsigned_long_long.Invoke(value);
	}
}
