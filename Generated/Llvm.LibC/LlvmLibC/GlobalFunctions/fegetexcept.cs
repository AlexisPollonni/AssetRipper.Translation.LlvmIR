namespace LlvmLibC.GlobalFunctions;

internal static partial class fegetexcept
{
	public static int Invoke()
	{
		return fputil_get_except.Invoke();
	}
}
