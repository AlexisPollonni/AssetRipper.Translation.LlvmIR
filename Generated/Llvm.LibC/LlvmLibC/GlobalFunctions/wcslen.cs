namespace LlvmLibC.GlobalFunctions;

internal static partial class wcslen
{
	public unsafe static long Invoke(void* src)
	{
		return internal_string_length_wchar_t.Invoke(src);
	}
}
