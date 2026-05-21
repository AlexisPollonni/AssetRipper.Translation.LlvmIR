namespace LlvmLibC.GlobalFunctions;

internal static partial class totalorder
{
	public unsafe static int Invoke(void* x, void* y)
	{
		return unchecked(fputil_totalorder_double.Invoke(*(double*)x, *(double*)y)) ? 1 : 0;
	}
}
