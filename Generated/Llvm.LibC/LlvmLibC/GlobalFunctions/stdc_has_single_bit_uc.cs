namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_has_single_bit_uc
{
	public static bool Invoke(sbyte value)
	{
		return cpp_has_single_bit_unsigned_char.Invoke(value);
	}
}
