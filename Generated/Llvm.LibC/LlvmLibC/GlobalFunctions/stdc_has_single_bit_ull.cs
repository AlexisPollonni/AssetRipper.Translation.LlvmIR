namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_has_single_bit_ull
{
	public static bool Invoke(long value)
	{
		return cpp_has_single_bit_unsigned_long_long.Invoke(value);
	}
}
