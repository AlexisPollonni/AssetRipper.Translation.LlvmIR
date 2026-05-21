namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_trailing_ones_us
{
	public static int Invoke(short value)
	{
		return cpp_countr_one_unsigned_short.Invoke(value);
	}
}
