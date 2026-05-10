namespace LlvmLibC.GlobalFunctions;

internal static partial class memchr
{
	public unsafe static void* Invoke(void* src, int c, long n)
	{
		return internal_find_first_character_unsigned_char_const_unsigned_char_unsigned_long.Invoke(src, unchecked((sbyte)c), n);
	}
}
