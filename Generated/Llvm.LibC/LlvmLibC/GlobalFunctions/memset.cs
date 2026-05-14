namespace LlvmLibC.GlobalFunctions;

internal static partial class memset
{
	public unsafe static void* Invoke(void* dst, int value, long count)
	{
		inline_memset_void_unsigned_char_unsigned_long_208.Invoke(dst, unchecked((sbyte)value), count);
		return dst;
	}
}
