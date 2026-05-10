namespace LlvmLibC.GlobalFunctions;

internal static partial class bcopy
{
	public unsafe static void Invoke(void* src, void* dst, long count)
	{
		inline_memmove_void_void_const_unsigned_long.Invoke(dst, src, count);
	}
}
