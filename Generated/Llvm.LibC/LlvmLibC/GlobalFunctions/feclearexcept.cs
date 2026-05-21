namespace LlvmLibC.GlobalFunctions;

internal static partial class feclearexcept
{
	public static int Invoke(int e)
	{
		return fputil_clear_except.Invoke(e);
	}
}
