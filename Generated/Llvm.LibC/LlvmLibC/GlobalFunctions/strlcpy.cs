namespace LlvmLibC.GlobalFunctions;

internal static partial class strlcpy
{
	public unsafe static long Invoke(void* dst, void* src, long size)
	{
		return internal_strlcpy.Invoke(dst, src, size);
	}
}
