namespace LlvmLibC.GlobalFunctions;

internal static partial class totalorderl
{
	public unsafe static int Invoke(void* x, void* y)
	{
		return unchecked(cpp_enable_if_cpp_is_floating_point_v_long_double_bool_type_fputil_totalorder_long_double_long_double_long_double.Invoke(*(double*)x, *(double*)y)) ? 1 : 0;
	}
}
