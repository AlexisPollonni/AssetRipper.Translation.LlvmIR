namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_has_single_bit_ui
{
	public static bool Invoke(int value)
	{
		return cpp_enable_if_cpp_is_unsigned_v_unsigned_int_bool_type_cpp_has_single_bit_unsigned_int_unsigned_int.Invoke(value);
	}
}
