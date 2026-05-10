namespace LlvmLibC.GlobalFunctions;

internal static partial class strlcpy
{
	public unsafe static long Invoke(void* dst, void* src, long size)
	{
		return internal_strlcpy_char_char_const_unsigned_long.Invoke(dst, src, size);
	}
}
