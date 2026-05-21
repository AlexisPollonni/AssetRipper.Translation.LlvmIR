namespace LlvmLibC.GlobalFunctions;

internal static partial class strlen
{
	public unsafe static long Invoke(void* src)
	{
		return internal_string_length_char.Invoke(src);
	}
}
