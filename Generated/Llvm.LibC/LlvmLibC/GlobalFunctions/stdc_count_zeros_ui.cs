namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_count_zeros_ui
{
	public static int Invoke(int value)
	{
		return count_zeros_unsigned_int.Invoke(value);
	}
}
