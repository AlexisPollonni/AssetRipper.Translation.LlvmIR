namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_count_zeros_ull
{
	public static int Invoke(long value)
	{
		return cpp_enable_if_cpp_is_unsigned_v_unsigned_long_long_int_type_count_zeros_unsigned_long_long_unsigned_long_long.Invoke(value);
	}
}
