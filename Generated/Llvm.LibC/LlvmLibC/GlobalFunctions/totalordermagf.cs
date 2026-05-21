namespace LlvmLibC.GlobalFunctions;

internal static partial class totalordermagf
{
	public unsafe static int Invoke(void* x, void* y)
	{
		return unchecked(fputil_totalordermag_float.Invoke(*(float*)x, *(float*)y)) ? 1 : 0;
	}
}
