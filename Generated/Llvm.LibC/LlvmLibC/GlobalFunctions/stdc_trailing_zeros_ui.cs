namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_trailing_zeros_ui
{
	public static int Invoke(int value)
	{
		return cpp_enable_if_cpp_is_unsigned_v_unsigned_int_int_type_cpp_countr_zero_unsigned_int_unsigned_int.Invoke(value);
	}
}
