namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_count_ones_uc
{
	public static int Invoke(sbyte value)
	{
		return cpp_enable_if_cpp_is_unsigned_v_unsigned_char_int_type_cpp_popcount_unsigned_char_unsigned_char.Invoke(value);
	}
}
