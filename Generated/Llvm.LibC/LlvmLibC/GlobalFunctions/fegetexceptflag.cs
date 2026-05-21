namespace LlvmLibC.GlobalFunctions;

internal static partial class fegetexceptflag
{
	public unsafe static int Invoke(void* flagp, int excepts)
	{
		unchecked
		{
			*(short*)flagp = (short)(fputil_test_except.Invoke(61) & excepts);
			return 0;
		}
	}
}
