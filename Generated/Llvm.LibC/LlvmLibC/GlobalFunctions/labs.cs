namespace LlvmLibC.GlobalFunctions;

internal static partial class labs
{
	public static long Invoke(long n)
	{
		return cpp_enable_if_cpp_is_integral_v_long_long_type_integer_abs_long_long.Invoke(n);
	}
}
