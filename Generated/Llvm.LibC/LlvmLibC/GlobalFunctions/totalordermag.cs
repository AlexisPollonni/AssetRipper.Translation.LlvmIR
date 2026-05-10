namespace LlvmLibC.GlobalFunctions;

internal static partial class totalordermag
{
	public unsafe static int Invoke(void* x, void* y)
	{
		return unchecked(cpp_enable_if_cpp_is_floating_point_v_double_bool_type_fputil_totalordermag_double_double_double.Invoke(*(double*)x, *(double*)y)) ? 1 : 0;
	}
}
