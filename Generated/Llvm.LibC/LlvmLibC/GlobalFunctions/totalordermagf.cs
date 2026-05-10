namespace LlvmLibC.GlobalFunctions;

internal static partial class totalordermagf
{
	public unsafe static int Invoke(void* x, void* y)
	{
		return unchecked(cpp_enable_if_cpp_is_floating_point_v_float_bool_type_fputil_totalordermag_float_float_float.Invoke(*(float*)x, *(float*)y)) ? 1 : 0;
	}
}
