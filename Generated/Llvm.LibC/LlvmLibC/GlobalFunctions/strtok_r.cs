namespace LlvmLibC.GlobalFunctions;

internal static partial class strtok_r
{
	public unsafe static void* Invoke(void* src, void* delimiter_string, void* saveptr)
	{
		return char_internal_string_token_true_char_char_const_char.Invoke(src, delimiter_string, saveptr);
	}
}
