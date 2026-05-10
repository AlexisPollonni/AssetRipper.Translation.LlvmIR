using LlvmLibC.GlobalVariables;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strtok
{
	public unsafe static void* Invoke(void* src, void* delimiter_string)
	{
		return char_internal_string_token_true_char_char_const_char.Invoke(src, delimiter_string, strtok_str.Pointer);
	}
}
