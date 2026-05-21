namespace LlvmLibC.GlobalFunctions;

internal static partial class strchrnul
{
	public unsafe static void* Invoke(void* src, int c)
	{
		return internal_strchr_implementation_false.Invoke(src, c);
	}
}
