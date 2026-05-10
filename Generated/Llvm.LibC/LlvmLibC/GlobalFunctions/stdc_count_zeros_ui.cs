namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_count_zeros_ui
{
	public static int Invoke(int value)
	{
		return cpp_enable_if_cpp_is_unsigned_v_unsigned_int_int_type_count_zeros_unsigned_int_unsigned_int.Invoke(value);
	}
}
