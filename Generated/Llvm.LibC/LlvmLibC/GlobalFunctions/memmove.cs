namespace LlvmLibC.GlobalFunctions;

internal static partial class memmove
{
	public unsafe static void* Invoke(void* dst, void* src, long count)
	{
		if (inline_memmove_small_size_void_void_const_unsigned_long.Invoke(dst, src, count))
		{
			return dst;
		}
		if (is_disjoint_void_const_void_const_unsigned_long.Invoke(dst, src, count))
		{
			inline_memcpy_void_void_const_unsigned_long.Invoke(dst, src, count);
		}
		else
		{
			inline_memmove_follow_up_void_void_const_unsigned_long.Invoke(dst, src, count);
		}
		return dst;
	}
}
