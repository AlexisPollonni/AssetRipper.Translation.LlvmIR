namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_has_single_bit_uc
{
	public static bool Invoke(sbyte value)
	{
		return cpp_enable_if_cpp_is_unsigned_v_unsigned_char_bool_type_cpp_has_single_bit_unsigned_char_unsigned_char.Invoke(value);
	}
}
