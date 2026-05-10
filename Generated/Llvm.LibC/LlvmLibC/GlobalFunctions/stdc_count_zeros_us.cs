namespace LlvmLibC.GlobalFunctions;

internal static partial class stdc_count_zeros_us
{
	public static int Invoke(short value)
	{
		return cpp_enable_if_cpp_is_unsigned_v_unsigned_short_int_type_count_zeros_unsigned_short_unsigned_short.Invoke(value);
	}
}
