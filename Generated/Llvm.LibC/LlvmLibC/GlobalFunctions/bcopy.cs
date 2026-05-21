namespace LlvmLibC.GlobalFunctions;

internal static partial class bcopy
{
	public unsafe static void Invoke(void* src, void* dst, long count)
	{
		inline_memmove.Invoke(dst, src, count);
	}
}
