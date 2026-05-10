namespace LlvmLibC.GlobalFunctions;

internal static partial class abs
{
	public static int Invoke(int n)
	{
		return cpp_enable_if_cpp_is_integral_v_int_int_type_integer_abs_int_int.Invoke(n);
	}
}
