namespace LlvmLibC.GlobalFunctions;

internal static partial class totalordermagf128
{
	public unsafe static int Invoke(void* x, void* y)
	{
		return unchecked(fputil_totalordermag_float128.Invoke(*(double*)x, *(double*)y)) ? 1 : 0;
	}
}
