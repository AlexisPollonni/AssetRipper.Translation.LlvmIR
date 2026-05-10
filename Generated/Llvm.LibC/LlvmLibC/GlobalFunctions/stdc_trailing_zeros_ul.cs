namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_trailing_zeros_ul
{
	public static int Invoke(long value)
	{
		return cpp_enable_if_cpp_is_unsigned_v_unsigned_long_int_type_cpp_countr_zero_unsigned_long_unsigned_long.Invoke(value);
	}
}
