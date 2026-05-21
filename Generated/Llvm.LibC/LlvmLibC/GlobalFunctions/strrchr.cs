namespace LlvmLibC.GlobalFunctions;

internal static partial class strrchr
{
	public unsafe static void* Invoke(void* src, int c)
	{
		return internal_strrchr_implementation_743nz4.Invoke(src, c);
	}
}
