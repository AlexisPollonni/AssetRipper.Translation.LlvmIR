namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_trailing_ones_ui
{
	public static int Invoke(int value)
	{
		return cpp_countr_one_unsigned_int.Invoke(value);
	}
}
