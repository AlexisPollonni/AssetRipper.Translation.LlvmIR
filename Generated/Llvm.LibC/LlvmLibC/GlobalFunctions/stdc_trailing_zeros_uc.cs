namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_trailing_zeros_uc
{
	public static int Invoke(sbyte value)
	{
		return cpp_countr_zero_unsigned_char.Invoke(value);
	}
}
