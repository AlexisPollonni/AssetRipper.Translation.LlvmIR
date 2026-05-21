namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_has_single_bit_ui
{
	public static bool Invoke(int value)
	{
		return cpp_has_single_bit_unsigned_int.Invoke(value);
	}
}
