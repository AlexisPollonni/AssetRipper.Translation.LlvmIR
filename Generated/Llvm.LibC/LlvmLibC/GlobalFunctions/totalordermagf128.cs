namespace LlvmLibC.GlobalFunctions;

internal static partial class totalordermagf128
{
	public unsafe static int Invoke(void* x, void* y)
	{
		return unchecked(cpp_enable_if_cpp_is_floating_point_v_float128_bool_type_fputil_totalordermag_float128_float128_float128.Invoke(*(double*)x, *(double*)y)) ? 1 : 0;
	}
}
