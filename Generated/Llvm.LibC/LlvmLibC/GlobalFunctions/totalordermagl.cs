namespace LlvmLibC.GlobalFunctions;

internal static partial class totalordermagl
{
	public unsafe static int Invoke(void* x, void* y)
	{
		return unchecked(fputil_totalordermag_long_double.Invoke(*(double*)x, *(double*)y)) ? 1 : 0;
	}
}
