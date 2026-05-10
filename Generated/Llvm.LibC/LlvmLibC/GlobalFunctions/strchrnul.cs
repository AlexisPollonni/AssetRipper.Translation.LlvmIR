namespace LlvmLibC.GlobalFunctions;

internal static partial class strchrnul
{
	public unsafe static void* Invoke(void* src, int c)
	{
		return char_internal_strchr_implementation_false_char_const_int.Invoke(src, c);
	}
}
