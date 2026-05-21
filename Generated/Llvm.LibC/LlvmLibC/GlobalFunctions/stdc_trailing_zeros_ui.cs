namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_trailing_zeros_ui
{
	public static int Invoke(int value)
	{
		return cpp_countr_zero_unsigned_int.Invoke(value);
	}
}
