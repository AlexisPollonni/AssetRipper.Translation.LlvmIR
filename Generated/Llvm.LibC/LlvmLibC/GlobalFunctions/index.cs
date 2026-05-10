namespace LlvmLibC.GlobalFunctions;

internal static partial class index
{
	public unsafe static void* Invoke(void* src, int c)
	{
		return char_internal_strchr_implementation_true_char_const_int.Invoke(src, c);
	}
}
