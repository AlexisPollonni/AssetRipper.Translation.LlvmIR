using LlvmLibC.GlobalVariables;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strtok
{
	public unsafe static void* Invoke(void* src, void* delimiter_string)
	{
		return internal_string_token_true.Invoke(src, delimiter_string, strtok_str.Pointer);
	}
}
