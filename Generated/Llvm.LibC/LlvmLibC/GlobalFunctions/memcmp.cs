namespace LlvmLibC.GlobalFunctions;

internal static partial class memcmp
{
	public unsafe static int Invoke(void* lhs, void* rhs, long count)
	{
		return inline_memcmp.Invoke(lhs, rhs, count);
	}
}
