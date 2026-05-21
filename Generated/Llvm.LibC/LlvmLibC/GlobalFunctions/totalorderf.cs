namespace LlvmLibC.GlobalFunctions;

internal static partial class totalorderf
{
	public unsafe static int Invoke(void* x, void* y)
	{
		return unchecked(fputil_totalorder_float.Invoke(*(float*)x, *(float*)y)) ? 1 : 0;
	}
}
