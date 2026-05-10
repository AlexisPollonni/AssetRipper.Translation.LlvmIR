namespace LlvmLibC.GlobalFunctions;

internal static partial class bzero
{
	public unsafe static void Invoke(void* ptr, long count)
	{
		inline_bzero_void_unsigned_long.Invoke(ptr, count);
	}
}
