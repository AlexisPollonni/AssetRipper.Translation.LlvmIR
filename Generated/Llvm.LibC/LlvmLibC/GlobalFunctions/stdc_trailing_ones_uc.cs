namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_trailing_ones_uc
{
	public static int Invoke(sbyte value)
	{
		return cpp_countr_one_unsigned_char.Invoke(value);
	}
}
