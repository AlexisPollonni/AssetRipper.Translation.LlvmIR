namespace LlvmLibC.GlobalFunctions;

internal static partial class totalorderf128
{
	public unsafe static int Invoke(void* x, void* y)
	{
		return unchecked(fputil_totalorder_float128.Invoke(*(double*)x, *(double*)y)) ? 1 : 0;
	}
}
