namespace LlvmLibC.GlobalFunctions;

internal static partial class memcpy
{
	public unsafe static void* Invoke(void* dst, void* src, long size)
	{
		inline_memcpy.Invoke(dst, src, size);
		return dst;
	}
}
