namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_leading_zeros_ui
{
	public static int Invoke(int value)
	{
		return cpp_countl_zero_unsigned_int.Invoke(value);
	}
}
