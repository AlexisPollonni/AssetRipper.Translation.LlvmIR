namespace LlvmLibC.GlobalFunctions;

internal static partial class wcslen
{
	public unsafe static long Invoke(void* src)
	{
		return unsigned_long_internal_string_length_wchar_t_wchar_t_const.Invoke(src);
	}
}
