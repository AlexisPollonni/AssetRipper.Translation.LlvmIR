namespace LlvmLibC.GlobalFunctions;

internal static partial class bzero
{
	public unsafe static void Invoke(void* ptr, long count)
	{
		inline_bzero_vdhkgh.Invoke(ptr, count);
	}
}
