namespace LlvmLibC.GlobalFunctions;

internal static partial class memchr
{
	public unsafe static void* Invoke(void* src, int c, long n)
	{
		return internal_find_first_character.Invoke(src, unchecked((sbyte)c), n);
	}
}
