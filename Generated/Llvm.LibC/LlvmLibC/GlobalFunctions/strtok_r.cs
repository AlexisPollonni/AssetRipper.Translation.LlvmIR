namespace LlvmLibC.GlobalFunctions;

internal static partial class strtok_r
{
	public unsafe static void* Invoke(void* src, void* delimiter_string, void* saveptr)
	{
		return internal_string_token_true.Invoke(src, delimiter_string, saveptr);
	}
}
