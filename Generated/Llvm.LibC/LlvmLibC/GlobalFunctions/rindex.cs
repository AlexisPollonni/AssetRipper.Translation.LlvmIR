namespace LlvmLibC.GlobalFunctions;

internal static partial class rindex
{
	public unsafe static void* Invoke(void* src, int c)
	{
		return internal_strrchr_implementation_vj8pat.Invoke(src, c);
	}
}
