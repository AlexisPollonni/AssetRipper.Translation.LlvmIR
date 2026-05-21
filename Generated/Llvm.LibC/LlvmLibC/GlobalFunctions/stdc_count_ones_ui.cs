namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_count_ones_ui
{
	public static int Invoke(int value)
	{
		return cpp_popcount_unsigned_int.Invoke(value);
	}
}
