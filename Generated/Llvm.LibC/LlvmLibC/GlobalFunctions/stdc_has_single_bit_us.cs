namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_has_single_bit_us
{
	public static bool Invoke(short value)
	{
		return cpp_has_single_bit_unsigned_short.Invoke(value);
	}
}
