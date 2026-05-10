namespace LlvmLibC.GlobalFunctions;

internal static partial class memcpy
{
	public unsafe static void* Invoke(void* dst, void* src, long size)
	{
		inline_memcpy_void_void_const_unsigned_long.Invoke(dst, src, size);
		return dst;
	}
}
