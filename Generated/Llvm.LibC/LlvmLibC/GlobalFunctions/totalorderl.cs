namespace LlvmLibC.GlobalFunctions;

internal static partial class totalorderl
{
	public unsafe static int Invoke(void* x, void* y)
	{
		return unchecked(fputil_totalorder_long_double.Invoke(*(double*)x, *(double*)y)) ? 1 : 0;
	}
}
