namespace LlvmLibC.GlobalFunctions;

internal static partial class memmove
{
	public unsafe static void* Invoke(void* dst, void* src, long count)
	{
		if (inline_memmove_small_size.Invoke(dst, src, count))
		{
			return dst;
		}
		if (is_disjoint.Invoke(dst, src, count))
		{
			inline_memcpy.Invoke(dst, src, count);
		}
		else
		{
			inline_memmove_follow_up.Invoke(dst, src, count);
		}
		return dst;
	}
}
