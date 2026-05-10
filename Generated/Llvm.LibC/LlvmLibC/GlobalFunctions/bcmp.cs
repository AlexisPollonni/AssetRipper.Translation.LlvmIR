namespace LlvmLibC.GlobalFunctions;

internal static partial class bcmp
{
	public unsafe static int Invoke(void* lhs, void* rhs, long count)
	{
		return inline_bcmp_void_const_void_const_unsigned_long.Invoke(lhs, rhs, count);
	}
}
