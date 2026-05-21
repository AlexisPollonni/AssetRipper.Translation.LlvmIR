namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_count_zeros_uc
{
	public static int Invoke(sbyte value)
	{
		return count_zeros_unsigned_char.Invoke(value);
	}
}
