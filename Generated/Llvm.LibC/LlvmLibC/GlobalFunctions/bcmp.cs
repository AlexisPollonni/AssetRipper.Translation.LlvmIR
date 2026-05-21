namespace LlvmLibC.GlobalFunctions;

internal static partial class bcmp
{
	public unsafe static int Invoke(void* lhs, void* rhs, long count)
	{
		return inline_bcmp.Invoke(lhs, rhs, count);
	}
}
