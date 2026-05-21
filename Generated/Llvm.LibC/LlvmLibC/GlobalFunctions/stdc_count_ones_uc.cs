namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_count_ones_uc
{
	public static int Invoke(sbyte value)
	{
		return cpp_popcount_unsigned_char.Invoke(value);
	}
}
