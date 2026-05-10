namespace LlvmLibC.GlobalFunctions;

internal static partial class memcmp
{
	public unsafe static int Invoke(void* lhs, void* rhs, long count)
	{
		return inline_memcmp_void_const_void_const_unsigned_long.Invoke(lhs, rhs, count);
	}
}
