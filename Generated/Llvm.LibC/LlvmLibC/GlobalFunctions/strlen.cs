namespace LlvmLibC.GlobalFunctions;

internal static partial class strlen
{
	public unsafe static long Invoke(void* src)
	{
		return unsigned_long_internal_string_length_char_char_const.Invoke(src);
	}
}
